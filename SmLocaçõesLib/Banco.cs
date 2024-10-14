using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SmLocaçõesLib
{
    public class Banco
    {
        public static MySqlCommand Abrir()
        {
            string strconn = @"server=127.0.0.1;database=smlocaoesdb;user=root;password;";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlConnection cmd = new();

            try
            {
                cn.Open();
                
            }

            return cmd;
        }
    
}
