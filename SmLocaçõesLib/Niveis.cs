using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace SmLocaçõesLib
{
    public class Niveis
    {

       public int ID { get; set; }

        public string? Nome { get; set; }

        public string? Sigla { get; set; }



        public Niveis() { }




        public Niveis(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Niveis(int id, string nome, string sigla)
        {
            ID = id;
            Nome = nome;
            Sigla = sigla;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_niveis";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID = dr.GetInt32(0);
            }
        }




        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_niveis_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }




        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Delete from niveis where id = {ID}";
            cmd.ExecuteNonQuery();
        }



        public static Niveis ObterPorId(int id)
        {
            Niveis niveis = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.ID = dr.GetInt32(0);
                niveis.Nome = dr.GetString(1);
                niveis.Sigla = dr.GetString(2);
            }

            return niveis;
        }

        public static List<Niveis> ObterLista()
        {
            List<Niveis> lista = new List<Niveis>();


            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        ) );
            }
            return lista;
        }

    }
}
