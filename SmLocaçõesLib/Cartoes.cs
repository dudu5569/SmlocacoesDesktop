using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Cartoes
    {

        public int ID { get; set; }
        Cliente Id_cliente { get; set; }
        public string? Nome_Cartao { get; set; }
        public string? Bandeira { get; set; }
        public int? Numero_Cartao { get; set; }
        public int? Validade { get; set; }
        public string? Tipo { get; set; }

        public Cartoes () { }
        public Cartoes(Cliente cliente, string? nome_Cartao, string? bandeira, int? numero_Cartao, int? validade, string? tipo)
        {
            Id_cliente = cliente;
            Nome_Cartao = nome_Cartao;
            Bandeira = bandeira;
            Numero_Cartao = numero_Cartao;
            Validade = validade;
            Tipo = tipo;
        }


    }
}
