using Imposto.Core.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Imposto.Core.Service
{
    public class NotaFiscalService
    {
        public NotaFiscalService(string caminhoxml)
        {
            Caminhoxml = caminhoxml;
        }
        private NotaFiscal _notaFiscal;

        public string Caminhoxml { get; private set; }

        public bool GerarNotaFiscal(Domain.Pedido pedido)
        {
            try
            {
                _notaFiscal = new NotaFiscal();
                _notaFiscal.ItensDaNotaFiscal = _notaFiscal.EmitirNotaFiscal(pedido);

                if (!GerarNotaFiscalXml(_notaFiscal))
                    return false;
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
        public bool GerarNotaFiscalXml(NotaFiscal notaFiscalItem)
        {
            try
            {
                var xsSubmit = new XmlSerializer(typeof(NotaFiscal));

                if (!Directory.Exists(Caminhoxml))
                    Directory.CreateDirectory(Caminhoxml);

                var fileXml = Caminhoxml + notaFiscalItem.NomeCliente + DateTime.Now.Millisecond + ".xml";

              
                using (var writer = new StreamWriter(fileXml))
                {
                    xsSubmit.Serialize(writer, notaFiscalItem);
                }
            }
            catch
            {
                return false;
            }

            return true;
        
        }
    }
}
