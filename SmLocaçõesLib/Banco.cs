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
            string strconn = @"server=10.91.45.30;database=smlocacoesdb;user=root;password=;";
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
