using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class TipoCartao
    {
        public string? Tipo_Cartao {  get; set; }

        public string[] TipodeCartao { get; set; }

        public TipoCartao()
        {
            TipodeCartao = new string[] {"Crédito","Débito" };
        }
    }
}
