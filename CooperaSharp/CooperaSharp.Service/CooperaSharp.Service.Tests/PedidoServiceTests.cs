using System;
using Xunit;

namespace CooperaSharp.Service.Tests;

public class PedidoServiceTests
{
    private class FakeClienteRepository : IClienteRepository
    {
        public Client? ClienteToReturn;
        public int LastRequestedId;
        public Client ObterPorId(int dtoClienteId)
        {
            LastRequestedId = dtoClienteId;
            return ClienteToReturn!;
        }
    }

    private class FakePedidoRepository : IPedidoRepository
    {
        public Pedido? SavedPedido;
        public void Salvar(Pedido pedido)
        {
            SavedPedido = pedido;
        }
    }

    private class FakeEstoqueService : IEstoqueService
    {
        public object ReservedItens;
        public void ReservarItens(object itens)
        {
            ReservedItens = itens;
        }
    }

    private class FakePagamentoService : IPagamentoService
    {
        public bool Result = true;
        public object? LastPedido;
        public bool Processar(object pedido)
        {
            LastPedido = pedido;
            return Result;
        }
    }

    private class FakeEmailService : IEmailService
    {
        public object? LastEmail;
        public void EnviarConfirmacao(object email)
        {
            LastEmail = email;
        }
    }

    private class FakeNotificacaoService : INotificacaoService
    {
        public string? LastMessage;
        public void Enviar(string falhaNoPagamento)
        {
            LastMessage = falhaNoPagamento;
        }
    }

    private class FakeLogger : ILogger
    {
        public string? LastLog;
        public void Log(string clienteNaoEncontrado)
        {
            LastLog = clienteNaoEncontrado;
        }
    }

    private class FakeFreteService : IFreteService
    {
        public object? LastEndereco;
        public object ValorToReturn = 10m;
        public object CalcularFrete(string dtoEnderecoEntrega)
        {
            LastEndereco = dtoEnderecoEntrega;
            return ValorToReturn;
        }
    }

    private class FakeMapper : IMapper
    {
        public Pedido? LastPedidoCreated;
        public T Map<T>(PedidoDto dto)
        {
            var pedido = new Pedido
            {
                Id = 123,
                Itens = new object()
            };
            LastPedidoCreated = pedido;
            return (T)(object)pedido;
        }
    }

    private class FakeAuditoria : IAuditoriaService
    {
        public (string? Acao, object? Id)? LastRegistro;
        public void Registrar(string pedidoCriado, object toString)
        {
            LastRegistro = (pedidoCriado, toString);
        }
    }

    private static PedidoService CreateService(
        FakeClienteRepository clienteRepo,
        FakePedidoRepository pedidoRepo,
        FakeEstoqueService estoque,
        FakePagamentoService pagamento,
        FakeEmailService email,
        FakeNotificacaoService notificacao,
        FakeLogger logger,
        FakeFreteService frete,
        FakeMapper mapper,
        FakeAuditoria auditoria)
    {
        return new PedidoService(
            clienteRepo,
            pedidoRepo,
            estoque,
            pagamento,
            email,
            notificacao,
            logger,
            frete,
            mapper,
            auditoria);
    }

    [Fact]
    public void ProcessarPedido_ClienteNaoEncontrado_DeveLogarENaoProsseguir()
    {
        var clienteRepo = new FakeClienteRepository { ClienteToReturn = null };
        var pedidoRepo = new FakePedidoRepository();
        var estoque = new FakeEstoqueService();
        var pagamento = new FakePagamentoService();
        var email = new FakeEmailService();
        var notificacao = new FakeNotificacaoService();
        var logger = new FakeLogger();
        var frete = new FakeFreteService();
        var mapper = new FakeMapper();
        var auditoria = new FakeAuditoria();
        var service = CreateService(clienteRepo, pedidoRepo, estoque, pagamento, email, notificacao, logger, frete, mapper, auditoria);

        var dto = new PedidoDto { ClienteId = 1, EnderecoEntrega = "Rua 1" };

        service.ProcessarPedido(dto);

        Assert.Equal("Cliente não encontrado", logger.LastLog);
        Assert.Null(mapper.LastPedidoCreated);
        Assert.Null(estoque.ReservedItens);
        Assert.Null(pagamento.LastPedido);
        Assert.Null(pedidoRepo.SavedPedido);
        Assert.Null(email.LastEmail);
        Assert.Null(auditoria.LastRegistro);
        Assert.Null(notificacao.LastMessage);
    }

    [Fact]
    public void ProcessarPedido_PagamentoFalha_DeveNotificarENaoSalvarNemEnviarEmail()
    {
        var clienteRepo = new FakeClienteRepository { ClienteToReturn = new Client { Email = "x@x.com" } };
        var pedidoRepo = new FakePedidoRepository();
        var estoque = new FakeEstoqueService();
        var pagamento = new FakePagamentoService { Result = false };
        var email = new FakeEmailService();
        var notificacao = new FakeNotificacaoService();
        var logger = new FakeLogger();
        var frete = new FakeFreteService { ValorToReturn = 42m };
        var mapper = new FakeMapper();
        var auditoria = new FakeAuditoria();
        var service = CreateService(clienteRepo, pedidoRepo, estoque, pagamento, email, notificacao, logger, frete, mapper, auditoria);

        var dto = new PedidoDto { ClienteId = 1, EnderecoEntrega = "Rua 2" };

        service.ProcessarPedido(dto);

        // Fez etapas até pagamento
        Assert.NotNull(mapper.LastPedidoCreated);
        Assert.Equal(mapper.LastPedidoCreated!.Itens, estoque.ReservedItens);
        Assert.Equal("Rua 2", frete.LastEndereco);
        // Notificou falha
        Assert.Equal("Falha no pagamento", notificacao.LastMessage);
        // Não salvou nem enviou email nem auditou
        Assert.Null(pedidoRepo.SavedPedido);
        Assert.Null(email.LastEmail);
        Assert.Null(auditoria.LastRegistro);
    }

    [Fact]
    public void ProcessarPedido_Sucesso_DeveExecutarTodoFluxo()
    {
        var clienteRepo = new FakeClienteRepository { ClienteToReturn = new Client { Email = "ok@ok.com" } };
        var pedidoRepo = new FakePedidoRepository();
        var estoque = new FakeEstoqueService();
        var pagamento = new FakePagamentoService { Result = true };
        var email = new FakeEmailService();
        var notificacao = new FakeNotificacaoService();
        var logger = new FakeLogger();
        var frete = new FakeFreteService { ValorToReturn = 99m };
        var mapper = new FakeMapper();
        var auditoria = new FakeAuditoria();
        var service = CreateService(clienteRepo, pedidoRepo, estoque, pagamento, email, notificacao, logger, frete, mapper, auditoria);

        var dto = new PedidoDto { ClienteId = 77, EnderecoEntrega = "Rua 3" };

        service.ProcessarPedido(dto);

        // Reservou itens
        Assert.Equal(mapper.LastPedidoCreated!.Itens, estoque.ReservedItens);
        // Calculou frete e adicionou
        Assert.Equal("Rua 3", frete.LastEndereco);
        Assert.Equal(99m, mapper.LastPedidoCreated!.Frete);
        // Processou pagamento com o pedido
        Assert.Same(mapper.LastPedidoCreated, pagamento.LastPedido);
        // Salvou
        Assert.Same(mapper.LastPedidoCreated, pedidoRepo.SavedPedido);
        // Enviou email
        Assert.Equal("ok@ok.com", email.LastEmail);
        // Auditou
        Assert.Equal(("Pedido criado", "123"), auditoria.LastRegistro);
        // Não deve ter registrado erro/notificação extra
        Assert.Null(logger.LastLog);
        Assert.Null(notificacao.LastMessage);
    }
}
