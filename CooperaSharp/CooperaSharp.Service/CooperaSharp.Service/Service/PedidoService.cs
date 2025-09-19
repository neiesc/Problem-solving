namespace CooperaSharp.Service;

public class PedidoService
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IEstoqueService _estoqueService;
    private readonly IPagamentoService _pagamentoService;
    private readonly INotificacaoService _notificacaoService;
    private readonly IFreteService _freteService;
    private readonly IMapper _mapper;
    private readonly IAuditoriaService _auditoriaService;
    private readonly IClienteService _clienteService;

    public PedidoService(
        IClienteService clienteService,
        IPedidoRepository pedidoRepository,
        IEstoqueService estoqueService,
        IPagamentoService pagamentoService,
        INotificacaoService notificacaoService,
        IFreteService freteService,
        IMapper mapper,
        IAuditoriaService auditoriaService)
    {
        _clienteService = clienteService;
        _pedidoRepository = pedidoRepository;
        _estoqueService = estoqueService;
        _pagamentoService = pagamentoService;
        _notificacaoService = notificacaoService;
        _freteService = freteService;
        _mapper = mapper;
        _auditoriaService = auditoriaService;
    }

    public (bool isValid, string descrition) ProcessarPedido(PedidoDto dto)
    {
        var clienteValido = _clienteService.ObterPorId(dto.ClienteId);
        if (!clienteValido.isValid)
        {
            return (false, Validation.ClienteNaoEncontrado);
        }

        var pedido = _mapper.Map<Pedido>(dto);

        _estoqueService.ReservarItens(pedido.Itens);

        var valorFrete = _freteService.CalcularFrete(dto.EnderecoEntrega);
        pedido.AdicionarFrete(valorFrete);

        var pagamentoOk = _pagamentoService.Processar(pedido);

        if (!pagamentoOk)
        {
            _notificacaoService.Enviar("Falha no pagamento");
            return (false, "Falha no pagamento");
        }

        _pedidoRepository.Salvar(pedido);

        _clienteService.EnviarConfirmacao(clienteValido.result);
        _auditoriaService.Registrar("Pedido criado", pedido.Id.ToString());

        return (true, "Sucesso");
    }
}