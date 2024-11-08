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

        public Categorias() { }
        public Categorias(string? categoria)
        {
            Categoria = categoria;
        }

        public Categorias(int id, string? categoria)
        {
            Id = id;
            Categoria = categoria;
        }

        public static List<Categorias> ObterCategoria()
        {
            List<Categorias> lista = new List<Categorias>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                dr.GetInt32(0),
                dr.GetString(1)
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
            while (dr.Read())
            {
                categorias = new(
                dr.GetInt32(0),
                dr.GetString(1)
                );
            }
            return categorias;

        }
    }
}
