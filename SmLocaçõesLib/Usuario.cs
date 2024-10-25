﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace SmLocaçõesLib
{
    public class Usuario
    {

        public int Id { get; set; }
        public Funcionario? Id_funcionario { get; set; }
         public string? Login { get; set; }

        public string? Senha { get; set; }
        public bool Ativo { get; set; }

 

        public Usuario() {
            Id_funcionario = new();
        }
        public Usuario(Funcionario id_funcionario, string? login, string? senha, bool ativo)
        {
            Id_funcionario = id_funcionario;
            Login = login;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, Funcionario id_funcionario, string? login, string? senha, bool ativo)
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

        public void InserirUsuario()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_usuarios_descktop";
            cmd.Parameters.AddWithValue("spid_funcionario",Id_funcionario.ID);
            cmd.Parameters.AddWithValue("spusuario", Login);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            var dr = cmd.ExecuteReader();
            if (dr.Read()) Id = dr.GetInt32(0);
        }

        public static Usuario ObterIdFuncionario(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from usuarios_descktop where id_funcionario = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    Funcionario.ObterporId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetBoolean(4)
                    );
            }
            return usuario;
        }

    }
}
