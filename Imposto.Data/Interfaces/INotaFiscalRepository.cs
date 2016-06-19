using Imposto.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imposto.Data
{
    public interface INotaFiscalRepository : IDisposable
    {
        void SalvarNotaFiscal(NotaFiscal nota);
        void SalvarItem(NotaFiscalItem item);
    }
}
