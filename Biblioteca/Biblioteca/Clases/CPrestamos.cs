using Biblioteca.Base_de_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Biblioteca.Clases
{
    public class CPrestamos
    {
        #region Atributos y Propiedaes
        public int Id { get; set; }
        public CUsuarios Usuario { get; set; }
        public CUsuarios Cliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public CLibros Libro { get; set; }
        public string Devuelto { get; set; }
        #endregion

        #region Constructores
        public CPrestamos() { }
        public CPrestamos(int Id, CUsuarios Usu, CUsuarios Cli, DateTime FI, DateTime FT, CLibros Lib, string dev)
        {
            this.Id = Id;
            Usuario = Usu;
            Cliente = Cli;
            FechaInicio = FI;
            FechaTermino = FT;
            Libro = Lib;
            Devuelto = dev;
        }
        #endregion

        #region Metodos de clase
        internal static CPrestamos anterior(CPrestamos miObjeto)
        {
            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CPrestamos obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Prestamos where id_prestamo<" + miObjeto.Id + " order by id_prestamo desc";
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

        internal static CPrestamos buscar(string id)
        {

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CPrestamos obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select * from Prestamos where id_prestamo=" + id;
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
        
        internal static bool eliminar(CPrestamos miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;

            cxn = CConexion_BD.getcxn();
            string consulta = "delete Prestamos where id_prestamo=" + miObjeto.Id;
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

        internal static bool guardar(CPrestamos miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;


            cxn = CConexion_BD.getcxn();
            string consulta = "INSERT INTO Prestamos (id_prestamo, id_usuario, id_cliente, fecha_inicio, fecha_termino, id_libro, devuelto) " +
                   "VALUES (@id, @usuario, @cliente, @inicio, @termino, @libro, @devuelto)";

            cmd = new SqlCommand(consulta, cxn);
            
            cmd.Parameters.AddWithValue("@id", miObjeto.Id);
            cmd.Parameters.AddWithValue("@usuario", miObjeto.Usuario.Id);
            cmd.Parameters.AddWithValue("@cliente", miObjeto.Cliente.Id);
            cmd.Parameters.AddWithValue("@inicio", miObjeto.FechaInicio); 
            cmd.Parameters.AddWithValue("@termino", miObjeto.FechaTermino);
            cmd.Parameters.AddWithValue("@libro", miObjeto.Libro.Id);
            cmd.Parameters.AddWithValue("@devuelto", miObjeto.Devuelto);
           
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

        internal static CPrestamos primero()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CPrestamos obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Prestamos ";
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

        internal static CPrestamos siguiente(CPrestamos miObjeto)
        {

            if (miObjeto == null) return null;

            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CPrestamos obj = null;
            cxn = CConexion_BD.getcxn();
            string consulta = "select top 1 * from Prestamos where id_prestamo >" + miObjeto.Id;
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

        internal static CPrestamos ultimo()
        {
            SqlConnection cxn;
            SqlCommand cmd;
            SqlDataReader dr;
            CPrestamos obj = null;

            cxn = CConexion_BD.getcxn();
            string Consulta = "select top 1 * from Prestamos order by id_prestamo desc";
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
        internal static bool Modificar(CPrestamos miObjeto)
        {
            if (miObjeto == null) return false;

            SqlConnection cxn;
            SqlCommand cmd;

            cxn = CConexion_BD.getcxn();
            string consulta = "update Prestamos set id_usuario = @usuario, id_cliente = @cliente, " +
                "fecha_inicio = @inicio, fecha_termino = @termino, id_libro = @libro, devuelto = @devuelto where id_prestamo = @id";


            cmd = new SqlCommand(consulta, cxn);
            cmd.Parameters.AddWithValue("@id", miObjeto.Id);
            cmd.Parameters.AddWithValue("@usuario", miObjeto.Usuario.Id);
            cmd.Parameters.AddWithValue("@cliente", miObjeto.Cliente.Id);
            cmd.Parameters.AddWithValue("@inicio", miObjeto.FechaInicio);
            cmd.Parameters.AddWithValue("@termino", miObjeto.FechaTermino);
            cmd.Parameters.AddWithValue("@libro", miObjeto.Libro.Id);
            cmd.Parameters.AddWithValue("@devuelto", miObjeto.Devuelto);
            
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
        private static CPrestamos crearObjeto(SqlDataReader dr)
        {
            return new CPrestamos(Convert.ToInt32(dr["id_prestamo"]),
                                  CUsuarios.buscar(Convert.ToString(dr["id_usuario"])),
                                  CUsuarios.buscar(Convert.ToString(dr["id_cliente"])),
                                  Convert.ToDateTime(dr["fecha_inicio"]),
                                  Convert.ToDateTime(dr["fecha_termino"]),
                                  CLibros.buscar(Convert.ToString(dr["id_libro"])),
                                  Convert.ToString(dr["devuelto"]));
        }
        #endregion
    }
}
