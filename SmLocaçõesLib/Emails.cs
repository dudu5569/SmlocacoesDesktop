using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Emails
    {

        public int Id {  get; set; }
        public string? Email { get; set; }

        public Emails () { }
        public Emails(string? email)
        {
            Email = email;
        }

        public void InserirEmail(string email)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"Insert into emails (email) values ('{email}'); select last_insert_id()";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) Id = dr.GetInt32(0);
        }

        public void Email_Associado_Funcionario(int idfuncionario, int idemail)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"Insert into funcionarios_emails (id_funcionario, id_email) values" +
                $" ('{idfuncionario}','{idemail}')";
            var dr = cmd.ExecuteReader();
            if (dr.Read() ) Id = dr.GetInt32(0);
        }


    }
}
