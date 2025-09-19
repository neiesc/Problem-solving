namespace CooperaSharp.Service;

public interface IClienteRepository
{
    Client ObterPorId(int dtoClienteId);
}