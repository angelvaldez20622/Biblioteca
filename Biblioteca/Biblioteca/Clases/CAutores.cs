using Biblioteca.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Biblioteca.Clases
{
    public class CAutores
    {
        #region Atributos y Propiedaes
        public int Id { get; set; }
        public string Nombre { get; set; }

        #endregion

        #region Constructores
        public CAutores() { }
        public CAutores(int Id, string Nom)
        {
            this.Id = Id;
            Nombre = Nom;

        }
        #endregion

        #region Metodos de clase
        internal static CAutores anterior(CAutores miObjeto)
        {
            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CAutores obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Autores where id_autor<" + miObjeto.Id + " order by id desc";
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

        internal static CAutores buscar(string id)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CAutores obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from Autores where id_autor=" + id;
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

        internal static bool eliminar(CAutores miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;

            cxn = CConexion_BD.getcxn();
            string consulta = "delete Autores where id_autor=" + miObjeto.Id;
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

        internal static bool guardar(CAutores miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "insert into Autores " +
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

        internal static CAutores primero()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CAutores obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Autores ";
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

        internal static CAutores siguiente(CAutores miObjeto)
        {

            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CAutores obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Autores where id_autor>" + miObjeto.Id;
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

        internal static CAutores ultimo()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CAutores obj = null;

            cxn = CConexion_BD.getcxn();
            string Consulta = "select top 1 * from Autores order by id desc";
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
        internal static bool Modificar(CAutores miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "update Autores set " +
                              "nombre = '" + miObjeto.Nombre + "'" +
                              " where id_autor =" + miObjeto.Id;
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
        private static CAutores crearObjeto(SqlDataReader dr)
        {
            return new CAutores(Convert.ToInt32(dr["id_autor"]),
                                  Convert.ToString(dr["nombre"]));
        }
        #endregion
    }
}
