using Biblioteca.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Biblioteca.Clases
{
    public class CLibros
    {
        #region Atributos y Propiedaes
        public int Id { get; set; }
        public string Nombre { get; set; }
        public CAutores Autor { get; set; }
        public int Año { get; set; }
        public CCategoriaLibros CategoriaLibros { get; set; }
        public int Existencias { get; set; }
        #endregion

        #region Constructores
        public CLibros() { }
        public CLibros(int Id, string Nom, CAutores AU, int Añ, CCategoriaLibros CLib, int exi)
        {
            this.Id = Id;
            Nombre = Nom;
            Autor = AU;
            Año = Añ;
            CategoriaLibros = CLib;
            Existencias = exi;
        }
        #endregion

        #region Metodos de clase
        internal static CLibros anterior(CLibros miObjeto)
        {
            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Libros where id_libro<" + miObjeto.Id + " order by id_libro desc";
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

        internal static CLibros buscar(string id)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from Libros where id_libro=" + id;
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
        internal static CLibros buscarNombre(string nombre)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from Libros where nombre='" + nombre + "'";
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

        internal static bool eliminar(CLibros miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;

            cxn = CConexion_BD.getcxn();
            string consulta = "delete Libros where id_libro=" + miObjeto.Id;
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

        internal static bool guardar(CLibros miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "insert into Libros " +
                              "(id_libro, nombre, id_autor, año, id_categoria, existencias) " +
                              "values (" + miObjeto.Id + ", "
                                       + "'" + miObjeto.Nombre + "', "
                                        + miObjeto.Autor.Id + ", "
                                       + "'" + miObjeto.Año + "', "
                                       + "'" + miObjeto.CategoriaLibros.Id + "', "
                                       + "'" + miObjeto.Existencias +
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

        internal static CLibros primero()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Libros ";
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

        internal static CLibros siguiente(CLibros miObjeto)
        {

            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CLibros obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Libros where id_libro>" + miObjeto.Id;
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

        internal static CLibros ultimo()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CLibros obj = null;

            cxn = CConexion_BD.getcxn();
            string Consulta = "select top 1 * from Libros order by id_libro desc";
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
        internal static bool Modificar(CLibros miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "update Libros set " +
                              "nombre ='" + miObjeto.Nombre + "'" +
                              ", id_autor =" + miObjeto.Autor.Id +
                              ", año =" + miObjeto.Año +
                              ", id_categoria ='" + miObjeto.CategoriaLibros.Id + "'" +
                              ", existencias ='" + miObjeto.Existencias + "'" +
                              " where id_libro =" + miObjeto.Id;
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
        private static CLibros crearObjeto(SqlDataReader dr)
        {
            return new CLibros(Convert.ToInt32(dr["id_libro"]),
                                  Convert.ToString(dr["nombre"]),
                                  CAutores.buscar(Convert.ToString(dr["id_autor"])),
                                  Convert.ToInt32(dr["año"]),
                                  CCategoriaLibros.buscar(Convert.ToString(dr["id_categoria"])),
                                  Convert.ToInt32(dr["existencias"]));
        }
        #endregion
    }
}
