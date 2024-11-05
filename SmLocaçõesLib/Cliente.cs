using System;
using System.Collections.Generic;
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
        public DateTime? Data_Cadastro { get; set; }
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

        public void InserirCliente()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_clientes";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nascimento);
            var dr = cmd.ExecuteReader();
            if (dr.Read()) Id = dr.GetInt32(0);
        }


    }
}
