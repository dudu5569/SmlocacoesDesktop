using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class ControleEstoque
    {

        public int ID { get; set; }
        public int Quantidade {  get; set; }
        public ControleEstoque(int iD, int quantidade)
        {
            ID = iD;
            Quantidade = quantidade;
        }

    }
}
