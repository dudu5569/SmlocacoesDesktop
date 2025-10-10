using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Pedidos
    {
        public int Id { get; set; }
       public Cliente Id_Cliente { get; set; }
        public Funcionario Id_Funcionario { get; set; }
        public DateTime? Data_Retirada { get; set; }
        public DateTime? Data_Entrega { get; set; }

        public string? Status_Pedido { get; set; }

        public Pedidos () { }

        public Pedidos(Cliente id_Cliente, Funcionario id_Funcionario, DateTime? data_Retirada, DateTime? data_Entrega, string? status_Pedido)
        {
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Retirada = data_Retirada;
            Data_Entrega = data_Entrega;
            Status_Pedido = status_Pedido;
        }

        public Pedidos(int id, Cliente id_Cliente, Funcionario id_Funcionario, DateTime? data_Retirada, DateTime? data_Entrega, string? status_Pedido)
        {
            Id = id;
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Retirada = data_Retirada;
            Data_Entrega = data_Entrega;
            Status_Pedido = status_Pedido;
        }

        public void InserirPedido()
        {
            using(var cmd = Banco.Abrir())
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_inserir_locacoes";
                cmd.Parameters.AddWithValue("spid_cliente", Id_Cliente);
                cmd.Parameters.AddWithValue("spid_funcionario", Id_Funcionario);
                cmd.Parameters.AddWithValue("spdata_retirada", Data_Retirada);
                cmd.Parameters.AddWithValue("spdata_entrega", Data_Entrega);
                cmd.Parameters.AddWithValue("spstatus_pedido", Status_Pedido);
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) Id = dr.GetInt32(0);
                }
            }
        }


        public static Pedidos ObterIdPedido(int id)
        {
            using(var cmd = Banco.Abrir())
            {
                Pedidos pedido = new();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"Select * from locacoes where id = {id}";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        pedido = new(
                            dr.GetInt32(0),
                            Cliente.ObterPorId(dr.GetInt32(1)),
                            Funcionario.ObterporId(dr.GetInt32(2)),
                            dr.GetDateTime(3),
                            dr.GetDateTime(4),
                            dr.GetString(5)
                            );
                    }
                }
                return pedido;
            }
        }

        public static List<Pedidos> ListarPedidos()
        {
            using (var cmd = Banco.Abrir())
            {
                List<Pedidos> lista = new();
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = "Select * from locacoes order by id";



                using (var dr = cmd.ExecuteReader())
                {
                int indexId = dr.GetOrdinal("id");
                int indexCliente = dr.GetOrdinal("id_cliente");
                int indexFuncionario = dr.GetOrdinal("id_funcionario");
                int indexRetirada = dr.GetOrdinal("data_retirada");
                int indexEntrega = dr.GetOrdinal("data_entrega");
                int indexStatus = dr.GetOrdinal("status_pedido");

                while (dr.Read())
                {
                    lista.Add(new Pedidos(
                        dr.GetInt32(indexId),
                        Cliente.ObterPorId(dr.GetInt32(indexCliente)),
                        Funcionario.ObterporId(dr.GetInt32(indexFuncionario)),
                        dr.GetDateTime(indexRetirada),
                        dr.GetDateTime(indexEntrega),
                        dr.GetString(indexStatus)
                        ));
                }
                }

                return lista;
            }
        }

        public void AtualizarStatusPedido(int id,string status)
        {
            using(var cmd = Banco.Abrir())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"Update locacoes set status_pedido = '{status}' where id = {id}";
                cmd.ExecuteNonQuery();
            }
        }



    }
}
