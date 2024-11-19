﻿using System;
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

        public List<int> ConsultaItensPedido(int id)
        {
            var cmd = Banco.Abrir();
            var quantidades = new List<int>(); // Lista para armazenar as quantidades

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT quantidade FROM items_locacoes WHERE id_locacao = {id}";
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    quantidades.Add(dr.GetInt32(0)); // Adiciona cada valor de quantidade encontrado
                }
            }
            finally
            {
                cmd.Connection.Close();
            }

            return quantidades; // Retorna a lista com as quantidades
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
