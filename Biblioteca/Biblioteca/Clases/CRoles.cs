using Biblioteca.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Clases
{
    public class CRoles
    {
        #region Atributos y Propiedaes
        public int Id { get; set; }
        public string Nombre { get; set; }

        #endregion

        #region Constructores
        public CRoles() { }
        public CRoles(int Id, string Nom)
        {
            this.Id = Id;
            Nombre = Nom;

        }
        #endregion

        #region Metodos de clase
        internal static CRoles anterior(CRoles miObjeto)
        {
            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CRoles obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Roles where id_rol<" + miObjeto.Id + " order by id desc";
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

        internal static CRoles buscar(string id)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CRoles obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from Roles where id_rol=" + id;
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

        internal static bool eliminar(CRoles miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;

            cxn = CConexion_BD.getcxn();
            string consulta = "delete Roles where id_rol=" + miObjeto.Id;
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

        internal static bool guardar(CRoles miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "insert into Rol " +
                              "(id, descripcion) " +
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

        internal static CRoles primero()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CRoles obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Roles ";
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

        internal static CRoles siguiente(CRoles miObjeto)
        {

            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CRoles obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Roles where id_rol>" + miObjeto.Id;
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

        internal static CRoles ultimo()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CRoles obj = null;

            cxn = CConexion_BD.getcxn();
            string Consulta = "select top 1 * from Roles order by id desc";
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
        internal static bool Modificar(CRoles miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "update Rol set " +
                              "descripcion = '" + miObjeto.Nombre + "'" +
                              " where id =" + miObjeto.Id;
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
        private static CRoles crearObjeto(SqlDataReader dr)
        {
            return new CRoles(Convert.ToInt32(dr["id_rol"]),
                                  Convert.ToString(dr["nombre"]));
        }
        #endregion
    }
}
