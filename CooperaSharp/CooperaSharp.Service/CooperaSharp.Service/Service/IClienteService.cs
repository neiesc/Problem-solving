namespace CooperaSharp.Service;

public interface IClienteService
{
    void EnviarConfirmacao(Client cliente);
    (bool isValid, Client result) ObterPorId(int dtoClienteId);
}

public class ClienteService : IClienteService
{
    private readonly IEmailService _emailService;
    private readonly IClienteRepository _clienteRepository;
    private ILogger _logger;

    public ClienteService(IClienteRepository _clienteRepository, IEmailService emailService, ILogger logger)
    {
        _emailService = emailService;
        _logger = logger;
    }

    public void EnviarConfirmacao(Client cliente) => _emailService.EnviarConfirmacao(cliente.Email);
    public (bool isValid, Client result) ObterPorId(int clienteId)
    {
        var cliente = _clienteRepository.ObterPorId(clienteId);
        if (cliente == null)
        {
            _logger.Log(Validation.ClienteNaoEncontrado);
            return (false, null);
        }

        return (false, cliente);
    }
}