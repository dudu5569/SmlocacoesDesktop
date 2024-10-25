using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SmLocaçõesLib
{
    public class Funcionario
    {

        public int ID {  get; set; }

        public Niveis? Nivel { get; set; }

        public string? Nome {  get; set; }
        public string? CPF { get; set; }

        public DateTime? Data_Nascimento { get; set; }

        public DateTime? Data_Cadastro {  get; set; } = DateTime.Now;

        bool? Ativo {  get; set; }

        public Funcionario() {
            Nivel = new();
        }
        public Funcionario(int id, Niveis? id_Nivel, string? nome, string? cpf, DateTime? data_Nascimento, DateTime? data_Cadastro, bool? ativo)
        {
            ID = id;
            Nivel = id_Nivel;
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_Nascimento;
            Data_Cadastro = data_Cadastro;
            Ativo = ativo;
        }

        public Funcionario(Niveis? id_Nivel, string? nome, string? cpf, DateTime? data_Nascimento, DateTime? data_Cadastro, bool? ativo)
        {
            Nivel = id_Nivel;
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
            cmd.Parameters.AddWithValue("spid_nivel", Nivel.ID);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_Nascimento);
            cmd.Parameters.AddWithValue("spdata_cad", Data_Cadastro);
            cmd.Parameters.AddWithValue("ativo", Ativo);

            ID = Convert.ToInt32(cmd.ExecuteScalar());
        }



        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_funcionarios";
            cmd.Parameters.AddWithValue("spid_nivel", Nivel);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_Nascimento);
            cmd.Parameters.AddWithValue("spdata_cad", Data_Cadastro);
            cmd.Parameters.AddWithValue("ativo", Ativo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Funcionario ObterporId(int id)
        {
            Funcionario funcionario = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from funcionarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario = new(
                dr.GetInt32(0),
                Niveis.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDateTime(4),
                dr.GetDateTime(5),
                dr.GetBoolean(6)
                );
            }
            return funcionario;
        }

        public static List<Funcionario> ObterListaFuncionario()
        {
            List<Funcionario> lista = new List<Funcionario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from funcionarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                dr.GetInt32(0),
                Niveis.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDateTime(4),
                dr.GetDateTime(5),
                dr.GetBoolean(6)
                        ));
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
