using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain
{
    public class Estado
    {
        // ReSharper disable once FunctionRecursiveOnAllPaths
        public List<Estado> GerarEstado()
        {
            EstadosList = new List<Estado>
            {
                new Estado {Uf = "AC", Descricao = "Acre"},
                new Estado {Uf = "AL", Descricao = "Alagoas"},
                new Estado {Uf = "AM", Descricao = "Amazonas"},
                new Estado {Uf = "AP", Descricao = "Amapá"},
                new Estado {Uf = "BA", Descricao = "Bahia"},
                new Estado {Uf = "CE", Descricao = "Ceará"},
                new Estado {Uf = "DF", Descricao = "Distrito Federal"},
                new Estado {Uf = "GO", Descricao = "Espírito Santo"},
                new Estado {Uf = "MA", Descricao = "Maranhão"},
                new Estado {Uf = "MG", Descricao = "Minas Gerais"},
                new Estado {Uf = "MS", Descricao = "Mato Grosso do Sul"},
                new Estado {Uf = "MT", Descricao = "Mato Grosso"},
                new Estado {Uf = "PA", Descricao = "Pará"},
                new Estado {Uf = "PB", Descricao = "Paraíba"},
                new Estado {Uf = "PE", Descricao = "Pernambuco"},
                new Estado {Uf = "PI", Descricao = "Piauí"},
                new Estado {Uf = "PR", Descricao = "Paraná"},
                new Estado {Uf = "RJ", Descricao = "Rio de Janeiro"},
                new Estado {Uf = "RN", Descricao = "Rio Grande do Norte"},
                new Estado {Uf = "RO", Descricao = "Rondônia"},
                new Estado {Uf = "RR", Descricao = "Roraima"},
                new Estado {Uf = "RS", Descricao = "Rio Grande do Sul"},
                new Estado {Uf = "SC", Descricao = "Santa Catarina"},
                new Estado {Uf = "SE", Descricao = "Sergipe"},
                new Estado {Uf = "SP", Descricao = "São Paulo"},
                new Estado {Uf = "TO", Descricao = "Tocantins"}
            };

            return EstadosList;
        }
        
         public List<Estado> EstadosList { get; set; }

        public string Uf { get; set; }

        public string Descricao { get; set; }
    }
}
