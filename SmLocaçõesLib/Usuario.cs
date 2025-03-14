﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using static Mysqlx.Notice.Warning.Types;

namespace SmLocaçõesLib
{
    public class Usuario
    {

        public int Id { get; set; }
        public Funcionario? Id_funcionario { get; set; }
         public string? Login { get; set; }

        public string? Senha { get; set; }
        public string? Ativo { get; set; }

        
        public Usuario() { }

        public Usuario (int id, string? login, string? senha, string ativo)
        {
            Id = id;
            Login = login;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario (string? login)
        {
            Login = login;
        }
        public Usuario(Funcionario id_funcionario, string? login, string? senha, string ativo)
        {
            Id_funcionario = id_funcionario;
            Login = login;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, Funcionario id_funcionario, string? login, string? senha, string ativo)
        {
            Id = id;
            Id_funcionario = id_funcionario;
            Login = login;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(Funcionario? id_funcionario)
        {
            Id_funcionario = id_funcionario;
        }

        public Usuario(string? login, string? senha, string ativo)
        {
            Login = login;
            Senha = senha;
            Ativo = ativo;
        }

        public void InserirUsuario()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_usuarios_desktop";
            cmd.Parameters.AddWithValue("spid_funcionario",Id_funcionario.ID);
            cmd.Parameters.AddWithValue("spusuario", Login);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            var dr = cmd.ExecuteReader();
            if (dr.Read()) Id = dr.GetInt32(0);   
        }

        public void AtualizarUsuario()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_usuarios_desktop";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spusuario", Login);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static bool ObterIdFuncionario(int id)
        {
            bool existe = false; 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from usuarios_desktop where id_funcionario = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                existe = true;
            }
            dr.Close();
            return existe;
        }

        public static List<Usuario> ObterLista(string? nome = "")
        {
            List<Usuario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where nome like '%{nome}%' order by nome";


            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lista.Add(
                    new(
                    dr.GetInt32(0),
                    Funcionario.ObterporId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4)
                        )
                    );
            }
            cmd.Connection.Close ();
            return lista;
        }

        public static List<Usuario> ObterListaUsuario(string? nome)
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType= CommandType.Text;


            if (nome == "")
            {
               cmd.CommandText = "Select * from usuarios_desktop order by usuario limit 10";
            }
            else
            {
                cmd.CommandText = $"Select * from usuarios_desktop where usuario like '%{nome}%'order by usuario";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    Funcionario.ObterporId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4)
                    ));
            }
            cmd.Connection.Close();
            return lista;
        }

        public static Usuario EfetuarLogin(string usuario, string senha)
        {
            Usuario login = new ();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios_desktop where usuario = '{usuario}' and senha = md5('{senha}')";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                   login = new(
                       dr.GetInt32(0),
                       Funcionario.ObterporId(dr.GetInt32(1)),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4)
                       );
            }
            return login;

        }
        
    }
}
