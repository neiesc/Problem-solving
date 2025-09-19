namespace CooperaSharp.Service;

public interface IMapper
{
    T Map<T>(PedidoDto dto);
}