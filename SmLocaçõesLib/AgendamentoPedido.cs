﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class AgendamentoPedido
    {
        public int ID { get; set; }
        public Cliente cliente { get; set; }

        public Funcionario funcionario { get; set; }

        public DateTime Data_Retirada { get; set; }
        public DateTime Data_Entrega { get; set; }

        public string? Status_Pedido { get; set; }

        public AgendamentoPedido() { }

        public AgendamentoPedido(int iD, Cliente cliente, Funcionario funcionario, DateTime data_Retirada, DateTime data_Entrega, string? status_Pedido)
        {
            ID = iD;
            this.cliente = cliente;
            this.funcionario = funcionario;
            Data_Retirada = data_Retirada;
            Data_Entrega = data_Entrega;
            Status_Pedido = status_Pedido;
        }

        public AgendamentoPedido(Cliente cliente, Funcionario funcionario, DateTime data_Retirada, DateTime data_Entrega, string? status_Pedido)
        {
            this.cliente = cliente;
            this.funcionario = funcionario;
            Data_Retirada = data_Retirada;
            Data_Entrega = data_Entrega;
            Status_Pedido= status_Pedido;
        }

        public void InserirPedido()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_locacoes";
            cmd.Parameters.AddWithValue("spid_cliente", cliente.Id);
            cmd.Parameters.AddWithValue("spid_funcionario", funcionario.ID);
            cmd.Parameters.AddWithValue("spdata_retirada", Data_Retirada);
            cmd.Parameters.AddWithValue("spdata_entrega", Data_Entrega);
            cmd.Parameters.AddWithValue("spstatus_pedido", Status_Pedido);
            var dr = cmd.ExecuteReader();
            if (dr.Read()) ID = dr.GetInt32(0);
        }


    }
}
