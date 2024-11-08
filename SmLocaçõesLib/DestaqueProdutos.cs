using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class DestaqueProdutos
    {
        public string? Destaque {  get; set; }


        public string[] produtoDestaque { get; set; }

        public DestaqueProdutos() {
            produtoDestaque = new string[] { "Sim", "Não" };
        }
    }
}
