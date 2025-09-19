namespace CooperaSharp.Service;

public class PedidoService
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IEstoqueService _estoqueService;
    private readonly IPagamentoService _pagamentoService;
    private readonly IEmailService _emailService;
    private readonly INotificacaoService _notificacaoService;
    private readonly ILogger _logger;
    private readonly IFreteService _freteService;
    private readonly IMapper _mapper;
    private readonly IAuditoriaService _auditoriaService;

    public PedidoService(
        IClienteRepository clienteRepository,
        IPedidoRepository pedidoRepository,
        IEstoqueService estoqueService,
        IPagamentoService pagamentoService,
        IEmailService emailService,
        INotificacaoService notificacaoService,
        ILogger logger,
        IFreteService freteService,
        IMapper mapper,
        IAuditoriaService auditoriaService)
    {
        _clienteRepository = clienteRepository;
        _pedidoRepository = pedidoRepository;
        _estoqueService = estoqueService;
        _pagamentoService = pagamentoService;
        _emailService = emailService;
        _notificacaoService = notificacaoService;
        _logger = logger;
        _freteService = freteService;
        _mapper = mapper;
        _auditoriaService = auditoriaService;
    }

    public void ProcessarPedido(PedidoDto dto)
    {
        var cliente = _clienteRepository.ObterPorId(dto.ClienteId);

        if (cliente == null)
        {
            _logger.Log("Cliente não encontrado");
            return;
        }

        var pedido = _mapper.Map<Pedido>(dto);

        _estoqueService.ReservarItens(pedido.Itens);

        var valorFrete = _freteService.CalcularFrete(dto.EnderecoEntrega);
        pedido.AdicionarFrete(valorFrete);

        var pagamentoOk = _pagamentoService.Processar(pedido);

        if (!pagamentoOk)
        {
            _notificacaoService.Enviar("Falha no pagamento");
            return;
        }

        _pedidoRepository.Salvar(pedido);

        _emailService.EnviarConfirmacao(cliente.Email);
        _auditoriaService.Registrar("Pedido criado", pedido.Id.ToString());
    }
}