using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class UnidadeVenda
    {
        public string? tipoVenda { get; set; }

        public string[] tipodeVenda {  get; set; }

        public UnidadeVenda()
        {
            tipodeVenda = new string[] { "Unidade", "Qualquer quantidade acima de 50"};
        }
    }
}
