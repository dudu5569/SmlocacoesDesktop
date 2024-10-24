using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Telefones
    {

        public int Id { get; set; }
        public string? Numero { get; set; }
        public string? Tipo_Telefone { get; set; }

        public string[] TipodeTelefone {get; set;}

        public Telefones()
        {
            TipodeTelefone = new string[] {"Fixo","Pessoal", "Corporativo", "Residencial" };
        }

        public Telefones(string? numero, string? tipo_Telefone)
        {
            Numero = numero;
            Tipo_Telefone = tipo_Telefone;
        }

        public void Inserir_Telefone(string telefone, string tipo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"Insert into telefones (telefone, tipo) values ('{telefone}','{tipo}'); select last_insert_id();";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) Id = dr.GetInt32(0);
        }

        public void Telefone_Associado_Funcionario(int idfuncionario, int idtelefone)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into funcionarios_telefones (id_funcionario, id_telefone) values" +
                $"('{idfuncionario}','{idtelefone}')";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) Id = dr.GetInt32(0);
        }
    }
}
