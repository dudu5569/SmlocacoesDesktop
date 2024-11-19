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

        public void RepoeEstoque(int id, int quantidade)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Update produtos set unidade_venda = {quantidade} where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
