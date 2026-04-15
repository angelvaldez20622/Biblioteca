using Biblioteca.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Clases
{
    public class CUsuarios
    {
        #region Atributos y Propiedaes
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public CRoles Rol { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        #endregion

        #region Constructores
        public CUsuarios() { }
        public CUsuarios(int Id, string Nom, string Cla, CRoles Ro,  string Corr, string Tel)
        {
            this.Id = Id;
            Nombre = Nom;
            Clave = Cla;
            Rol = Ro;    
            Telefono = Tel;
            Correo = Corr;
        }
        #endregion

        #region Metodos de clase
        internal static CUsuarios anterior(CUsuarios miObjeto)
        {
            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CUsuarios obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Usuarios where id_usuario<" + miObjeto.Id + " order by id desc";
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

        internal static CUsuarios buscar(string id)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CUsuarios obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from Usuarios where id_usuario=" + id;
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
        internal static CUsuarios buscarNombre(string nombre)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CUsuarios obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from Usuarios where nombre='" + nombre + "'";
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

        internal static bool eliminar(CUsuarios miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;

            cxn = CConexion_BD.getcxn();
            string consulta = "delete Usuarios where id_usuario=" + miObjeto.Id;
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

        internal static bool guardar(CUsuarios miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;


            cxn = CConexion_BD.getcxn();
            string consulta = "insert into Usuarios " +
                              "(id, nombre, clave, id_rol, correo,telefono) " +
                              "values (" + miObjeto.Id + ","
                                       + "'" + miObjeto.Nombre + "',"
                                       + "'" + miObjeto.Clave + "', "
                                       + miObjeto.Rol.Id + ","
                                       + "'" + miObjeto.Correo + "', "
                                       + "'" + miObjeto.Telefono + 
                                         "')";
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

        internal static CUsuarios primero()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CUsuarios obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Usuarios ";
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

        internal static CUsuarios siguiente(CUsuarios miObjeto)
        {

            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CUsuarios obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Usuarios where id_usuario>" + miObjeto.Id;
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

        internal static CUsuarios ultimo()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CUsuarios obj = null;

            cxn = CConexion_BD.getcxn();
            string Consulta = "select top 1 * from Usuarios order by id desc";
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
        internal static bool Modificar(CUsuarios miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "update Usuarios set " +
                              "nombre ='" + miObjeto.Nombre + "'" +
                              ", clave = '" + miObjeto.Clave + "'" +
                              ", id_rol =" + miObjeto.Rol.Id +
                              ", correo ='" + miObjeto.Correo + "'" +
                              ", telefono ='" + miObjeto.Telefono + "'" +
                              " where id_usuario =" + miObjeto.Id;
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
        private static CUsuarios crearObjeto(SqlDataReader dr)
        {
            return new CUsuarios(Convert.ToInt32(dr["id_usuario"]),
                                  Convert.ToString(dr["nombre"]),
                                  Convert.ToString(dr["clave"]),
                                  CRoles.buscar(Convert.ToString(dr["id_rol"])),
                                  Convert.ToString(dr["correo"]),
                                  Convert.ToString(dr["telefono"]));
        }
        #endregion
    }
}
