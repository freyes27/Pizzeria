using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Libreria

{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-4I9QV6S4\\SQLEXPRESS;Initial Catalog=BasePizza;Integrated Security=true");
            conexion.Open();
            DataSet Ds = new DataSet();
            SqlDataAdapter Dp = new SqlDataAdapter(cmd, conexion);
            Dp.Fill(Ds);
            conexion.Close();

            return Ds;


        }
    }
}

    

