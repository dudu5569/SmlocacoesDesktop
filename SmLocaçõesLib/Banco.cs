using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SmLocaçõesLib
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            string strconn = @"server=127.0.0.1;database=smlocacoesdb;user=root;password=;Max pool size =900";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new();

            try
            {
                cn.Open();
                cmd.Connection = cn;

            }
            catch (Exception)
            {
                throw;
            }

            return cmd;
        }
    }
}
