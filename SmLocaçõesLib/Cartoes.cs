using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Cartoes
    {

        public int ID { get; set; }
        Cliente Id_cliente { get; set; }
        public string? Nome_Cartao { get; set; }
        public string? Bandeira { get; set; }
        public string? Numero_Cartao { get; set; }
        public string? Validade { get; set; }
        public int? CVV {  get; set; }
        public string? Tipo { get; set; }

        public Cartoes () { }

        public Cartoes(string? numero_Cartao)
        {
            Numero_Cartao = numero_Cartao;
        }

        public Cartoes(int iD, Cliente id_cliente, string? nome_Cartao, string? bandeira, string? numero_Cartao, string? validade, int? cVV, string? tipo)
        {
            ID = iD;
            Id_cliente = id_cliente;
            Nome_Cartao = nome_Cartao;
            Bandeira = bandeira;
            Numero_Cartao = numero_Cartao;
            Validade = validade;
            CVV = cVV;
            Tipo = tipo;
        }

        public Cartoes(Cliente id_cliente, string? nome_Cartao, string? bandeira, string? numero_Cartao, string? validade, int? cVV, string? tipo)
        {
            Id_cliente = id_cliente;
            Nome_Cartao = nome_Cartao;
            Bandeira = bandeira;
            Numero_Cartao = numero_Cartao;
            Validade = validade;
            CVV = cVV;
            Tipo = tipo;
        }

        public void InserirCartao()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_cartoes";
            cmd.Parameters.AddWithValue("spid_cliente", Id_cliente.Id);
            cmd.Parameters.AddWithValue("spnome_cartao", Nome_Cartao);
            cmd.Parameters.AddWithValue("spbandeira", Bandeira);
            cmd.Parameters.AddWithValue("spnumero_cartao", Numero_Cartao);
            cmd.Parameters.AddWithValue("spvalidade", Validade);
            cmd.Parameters.AddWithValue("spcvv", CVV);
            cmd.Parameters.AddWithValue("tipo", Tipo);
            var dr = cmd.ExecuteReader();
            if (dr.Read()) ID = dr.GetInt32(0);
        }

        public static bool ValidarNumeroCartao(string numeroCartao)
        {
            // Regex para permitir 16 dígitos ou 13-19 caracteres com números, espaços ou hífens
            string padrao = @"^[\d\s\-]{13,19}$";
            return Regex.IsMatch(numeroCartao, padrao);
        }
    }
}
