using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace SmLocaçõesLib
{
    public class TiposEnderecos
    {

        public string? Tipo { get; set; }

        public string? Nome_tipo {  get; set; }


        public string[] tiposdeEnderecos { get; set; }
        public TiposEnderecos()
        {
            tiposdeEnderecos = new string[]{"RES - Residencial" ,"COR - Corporativo"};
        }

    }
}
