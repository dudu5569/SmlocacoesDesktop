using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Categorias
    {

        public int Id { get; set; }

        public string? Categoria { get; set; }

        public string? Sigla { get; set; }

        public Categorias() { }


        public Categorias(int id, string? categoria)
        {
            Id = id;
            Categoria = categoria;
        }

        public Categorias(int id)
        {
            Id = id;
        }

        public Categorias(int id, string? categoria, string? sigla)
        {
            Id = id;
            Categoria = categoria;
            Sigla = sigla;
        }

        public static List<Categorias> ObterCategoria()
        {
            List<Categorias> lista = new List<Categorias>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2)
                    ));
            }

            cmd.Connection.Close();
            return lista;
        }


        public static List<Categorias> ObterCategoriaID(int id)
        {
            List<Categorias> lista = new List<Categorias>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from Categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                dr.GetInt32(0)
                    ));
            }

            cmd.Connection.Close();
            return lista;
        }

        public static Categorias ObterPorId(int id)
        {
            Categorias categorias = new ();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();

            int indexId = dr.GetOrdinal("id");
            int indexRotulo = dr.GetOrdinal("rotulo");
            int indexSigla = dr.GetOrdinal("sigla");


            if (dr.Read())
            {
                categorias = new Categorias(
                    dr.GetInt32(indexId),
                    dr.GetString(indexRotulo),
                    dr.GetString(indexSigla)
                    );
            }
            return categorias;

        }

    }
}
