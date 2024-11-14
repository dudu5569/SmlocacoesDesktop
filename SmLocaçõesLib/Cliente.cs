using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Cliente
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public DateTime? Data_Nascimento { get; set; }
        public DateTime? Data_Cadastro{ get; set; }

        public Cliente () { }
        public Cliente(int id, string? nome, string? cpf, DateTime? data_Nascimento, DateTime? data_Cadastro)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_Nascimento;
            Data_Cadastro = data_Cadastro;
        }
        public Cliente(string? nome, string? cpf, DateTime? data_Nascimento, DateTime? data_Cadastro)
        {
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_Nascimento;
            Data_Cadastro = data_Cadastro;
        }

        public Cliente(int id)
        {
            Id = id;
        }

        public void InserirCliente()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_clientes";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nascimento);
            cmd.Parameters.AddWithValue("spdata_cadastro", Data_Cadastro);

            var dr = cmd.ExecuteReader();
            if (dr.Read()) Id = dr.GetInt32(0);
        }

        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0)
                    );
            }
            return cliente;
        }
        public static List<Cliente> ObterLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where nome like '%{nome}%' order by nome";


            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDateTime(3),
                        dr.GetDateTime(4)                        
                        )
                    );
            }

            return lista;
        }


    }
}
