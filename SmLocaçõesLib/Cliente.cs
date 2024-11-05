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


    }
}
