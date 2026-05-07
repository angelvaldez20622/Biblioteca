using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Biblioteca.Base_de_datos
{
    public class CConexion_BD
    {
        
       
        static public SqlConnection getcxn()
        {
            SqlConnection cxn;
            //string cadena = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=ChachoProject;Integrated Security=yes";
            //string cadena = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Biblioteca_BD;Integrated Security=yes";
            string cadena = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca_BD;Integrated Security=True";
            cxn = new SqlConnection(cadena);
            return cxn;
        }
        internal static DataTable Consulta(string elSelect)
        {
            DataTable dt = new DataTable();
            //var conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=ChachoProject;Integrated Security=yes");
            //var conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Biblioteca_BD;Integrated Security=yes");
            var conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca_BD;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(elSelect, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
