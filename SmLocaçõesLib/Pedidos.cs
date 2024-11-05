using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Pedidos
    {
        public int Id { get; set; }
        Cliente Id_Cliente { get; set; }
        Funcionario Id_Funcionario { get; set; }
        DateTime? Data_Retirada { get; set; }
        DateTime? Data_Entrega { get; set; }

        public Pedidos(Cliente id_Cliente, Funcionario id_Funcionario, DateTime? data_Retirada, DateTime? data_Entrega)
        {
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Retirada = data_Retirada;
            Data_Entrega = data_Entrega;
        }

        public Pedidos(int id, Cliente id_Cliente, Funcionario id_Funcionario, DateTime? data_Retirada, DateTime? data_Entrega)
        {
            Id = id;
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Retirada = data_Retirada;
            Data_Entrega = data_Entrega;
        }

    }
}
