namespace CooperaSharp.Service;

public interface IPagamentoService
{
    bool Processar(object pedido);
}