using Biblioteca.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Clases
{
    public class CCategoriaLibros
    {
        #region Atributos y Propiedaes
        public int Id { get; set; }
        public string Nombre { get; set; }

        #endregion

        #region Constructores
        public CCategoriaLibros() { }
        public CCategoriaLibros(int Id, string Nom)
        {
            this.Id = Id;
            Nombre = Nom;

        }
        #endregion

        #region Metodos de clase
        internal static CCategoriaLibros anterior(CCategoriaLibros miObjeto)
        {
            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CCategoriaLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from CategoriaLibros where id_categoria<" + miObjeto.Id + " order by id desc";
            cmd = new SqlCommand(consulta, cxn);

            cxn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    obj = crearObjeto(dr);

            }
            catch (SqlException e)
            {
                System.Console.Error.Write(e.Message);
            }
            cxn.Close();
            return obj;
        }

        internal static CCategoriaLibros buscar(string id)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CCategoriaLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from CategoriaLibros where id_categoria=" + id;
            cmd = new SqlCommand(consulta, cxn);
            cxn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    obj = crearObjeto(dr);

            }
            catch (SqlException e)
            {
                System.Console.Error.Write(e.Message);
            }
            cxn.Close();
            return obj;
        }

        internal static bool eliminar(CCategoriaLibros miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;

            cxn = CConexion_BD.getcxn();
            string consulta = "delete CategoriaLibros where id_categoria=" + miObjeto.Id;
            cmd = new SqlCommand(consulta, cxn);

            cxn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                cxn.Close();
                return true;
            }
            catch (SqlException e)
            {
                System.Console.Error.Write(e.Message);
                cxn.Close();
                return false;
            }
        }

        internal static bool guardar(CCategoriaLibros miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "insert into CategoriaLibros " +
                              "(id, nombre) " +
                              "values (" + miObjeto.Id + ", '"
                                        + miObjeto.Nombre +
                                         "' )";
            cmd = new SqlCommand(consulta, cxn);
            cxn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cxn.Close();
                return true;
            }
            catch (SqlException e)
            {
                System.Console.Error.Write(e.Message);
                cxn.Close();
                return false;
            }
        }

        internal static CCategoriaLibros primero()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CCategoriaLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from CategoriaLibros ";
            cmd = new SqlCommand(consulta, cxn);

            cxn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    obj = crearObjeto(dr);

            }
            catch (SqlException e)
            {
                System.Console.Error.Write(e.Message);
            }
            cxn.Close();
            return obj;
        }

        internal static CCategoriaLibros siguiente(CCategoriaLibros miObjeto)
        {

            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CCategoriaLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from CategoriaLibros where id_categoria>" + miObjeto.Id;
            cmd = new SqlCommand(consulta, cxn);

            cxn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    obj = crearObjeto(dr);

            }
            catch (SqlException e)
            {
                System.Console.Error.Write(e.Message);
            }
            cxn.Close();
            return obj;
        }

        internal static CCategoriaLibros ultimo()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CCategoriaLibros obj = null;

            cxn = CConexion_BD.getcxn();
            string Consulta = "select top 1 * from CategoriaLibros order by id desc";
            cmd = new SqlCommand(Consulta, cxn);
            cxn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    obj = crearObjeto(dr);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            cxn.Close();
            return obj;
        }
        internal static bool Modificar(CCategoriaLibros miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "update CategoriaLibros set " +
                              "nombre = '" + miObjeto.Nombre + "'" +
                              " where id_categoria =" + miObjeto.Id;
            cmd = new SqlCommand(consulta, cxn);
            cxn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cxn.Close();
                return true;
            }
            catch (SqlException e)
            {
                System.Console.Error.Write(e.Message);
                cxn.Close();
                return false;
            }
        }
        private static CCategoriaLibros crearObjeto(SqlDataReader dr)
        {
            return new CCategoriaLibros(Convert.ToInt32(dr["id_categoria"]),
                                  Convert.ToString(dr["nombre"]));
        }
        #endregion
    }
}
