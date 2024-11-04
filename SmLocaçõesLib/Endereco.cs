using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace SmLocaçõesLib
{
    public class Endereco
    {

        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public int? Cep { get; set; }
        public string? Tipo { get; set; }

        public Endereco() { }
        public Endereco(string? logradouro, int? numero, string? bairro, string? cidade, string? uf, int? cep, string? tipo)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
            Tipo = tipo;
        }
        public Endereco(int id, string? logradouro, int? numero, string? bairro, string? cidade, string? uf, int? cep, string? tipo)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
            Tipo = tipo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_enderecos";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            var dr = cmd.ExecuteReader();
            while (dr.Read()) Id = dr.GetInt32(0);
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_enderecos";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetInt32(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetInt32(6),
                    dr.GetString(7)
                    );
            }
            return endereco;
        }

        public void Endereco_Associado_Funcionario(int idfuncionario, int idendereco)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Insert into funcionarios_enderecos (id_funcionario, id_endereco) values " +
                $"('{idfuncionario}','{idendereco}')";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) Id = dr.GetInt32(0);
        }
         
    }
}
