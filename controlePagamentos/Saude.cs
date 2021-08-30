using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlePagamentos
{
    class Saude : Pagamento
    {
        public string estabelecimento { get; set; }
        public double faturamento { get; set; }
    }
}
