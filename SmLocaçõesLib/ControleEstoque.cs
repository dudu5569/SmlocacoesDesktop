using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SmLocaçõesLib
{
    public class ControleEstoque
    {

        public int ID { get; set; }
        public int Quantidade {  get; set; }

        public ControleEstoque() { }
        public ControleEstoque(int iD, int quantidade)
        {
            ID = iD;
            Quantidade = quantidade;
        }

        public void DescontaEstoque(int id, int quantidade)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Update produtos set unidade_venda = {quantidade} where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void ConsultaItensPedido(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select quantidade from items_locacoes where id_locacao = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) Quantidade = dr.GetInt32(0);
            cmd.Connection.Close();
        }


        public void DevolverEstoque(int idproduto, int quantidade)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Update produtos set unidade_venda = {quantidade} where id = {idproduto}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
