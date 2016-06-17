using System;
using System.Data;
using Imposto.Core.Domain;

namespace TesteImposto
{
    public class ProcessarNota
    {
        private readonly FormImposto _formImposto;
        public event FormImposto.DelegateAtulizarProgressBar AtulizarProgressBar;

        public ProcessarNota(FormImposto formImposto, FormImposto.DelegateAtulizarProgressBar atulizarProgressBar)
        {
            _formImposto = formImposto;
            AtulizarProgressBar += new FormImposto.DelegateAtulizarProgressBar(atulizarProgressBar);
            //AtulizarProgressBar?.Invoke("Processando nota, Aguarde", 0);
        }

        public void AdicionarPedidos(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row["Brinde"] == DBNull.Value)
                    row["Brinde"] = false;

                _formImposto.Pedido.ItensDoPedido.Add(
                    new PedidoItem()
                    {

                        Brinde = Convert.ToBoolean(row["Brinde"]),
                        CodigoProduto = row["Codigo do produto"]?.ToString(),
                        NomeProduto = row["Nome do produto"]?.ToString(),
                        ValorItemPedido = Convert.ToDouble(row["Valor"])
                    });

                AtulizarProgressBar?.Invoke("Processando nota, Aguarde", 0);
                // _formImposto.progressBarCalcular.Value++;
            }
        }
    }
}