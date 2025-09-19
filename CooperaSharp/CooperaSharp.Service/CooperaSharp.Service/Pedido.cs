namespace CooperaSharp.Service;

public class Pedido
{
    public object? Frete { get; private set; }

    public void AdicionarFrete(object valorFrete)
    {
        // Armazena o valor do frete sem lógica adicional para permitir testes
        Frete = valorFrete;
    }

    public object Itens { get; set; }
    public int Id { get; set; }
}