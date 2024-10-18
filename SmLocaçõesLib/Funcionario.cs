using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;

namespace SmLocaçõesLib
{
    public class Funcionario
    {

        int ID {  get; set; }

        Niveis Id_Nivel { get; set; }

        string? Nome {  get; set; }
        string? CPF { get; set; }

        DateTime? Data_Nascimento { get; set; }

        DateTime? Data_Cadastro {  get; set; } = DateTime.Now;

        bool? Ativo {  get; set; }

        public Funcionario() { }
        public Funcionario(int iD, Niveis? id_Nivel, string? nome, string? cpf, DateTime? data_Nascimento, DateTime? data_Cadastro, bool? ativo)
        {
            ID = iD;
            Id_Nivel = id_Nivel;
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_Nascimento;
            Data_Cadastro = data_Cadastro;
            Ativo = ativo;
        }

        public Funcionario(Niveis? id_Nivel, string? nome, string? cpf, DateTime? data_Nascimento, DateTime? data_Cadastro, bool? ativo)
        {
            Id_Nivel = id_Nivel;
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_Nascimento;
            Data_Cadastro = data_Cadastro;
            Ativo = ativo;
        }

        public Funcionario(string? nome, string? cpf, DateTime? data_Nascimento, DateTime? data_Cadastro, bool? ativo)
        {
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_Nascimento;
            Data_Cadastro = data_Cadastro;
            Ativo = ativo;
        }



        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_funcionarios";
            cmd.Parameters.AddWithValue("spid_nivel", Id_Nivel);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_Nascimento);
            cmd.Parameters.AddWithValue("spdata_cad", Data_Cadastro);
            cmd.Parameters.AddWithValue("ativo", Ativo);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dr.GetInt32(0);
            }

            cmd.Connection.Close();
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_funcionarios";
            cmd.Parameters.AddWithValue("spid_nivel", Id_Nivel);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_Nascimento);
            cmd.Parameters.AddWithValue("spdata_cad", Data_Cadastro);
            cmd.Parameters.AddWithValue("ativo", Ativo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
