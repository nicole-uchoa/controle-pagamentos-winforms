using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlePagamentos
{
    class Alimentacao : Pagamento
    {
        public string descricao { get; set; }
        public double faturamento { get; set; }


    }
}
