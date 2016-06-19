namespace Imposto.Core.Interfaces
{
    public interface INotaFiscalService
    {
        bool GerarNotaFiscal(Domain.Pedido pedido);
    }
}