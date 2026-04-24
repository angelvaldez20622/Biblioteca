using Biblioteca.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Roles", "id_rol", "Nombre", "Roles", "WHERE id_rol IN ( SELECT TOP 10 id_rol FROM Roles ORDER BY id_rol DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmRoles f = new frmRoles();
                f.ShowDialog();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Usuarios", "id_usuario", "nombre", "Usuarios", "WHERE id_usuario IN ( SELECT TOP 10 id_usuario FROM Usuarios ORDER BY id_usuario DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmUsuarios f = new frmUsuarios();
                f.ShowDialog();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Categoria de libros", "id_categoria", "nombre", "CategoriaLibros", "WHERE id_categoria IN ( SELECT TOP 10 id_categoria FROM CategoriaLibros ORDER BY id_categoria DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmCategoriaLibros f = new frmCategoriaLibros();
                f.ShowDialog();
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Autores", "id_autor", "nombre", "Autores", "WHERE id_autor IN ( SELECT TOP 10 id_autor FROM Autores ORDER BY id_autor DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmAutores f = new frmAutores();
                f.ShowDialog();
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Libros", "id_libro", "nombre", "Libros", "WHERE id_libro IN ( SELECT TOP 10 id_libro FROM Libros ORDER BY id_libro DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmLibros f = new frmLibros();
                f.ShowDialog();
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyudaPrestamos ayuda = new frmAyudaPrestamos("Vista de¨Prestamos", "id_Prestamo", "id_libro", "Prestamos", "WHERE id_prestamo IN ( SELECT TOP 10 id_prestamo FROM Libros ORDER BY id_prestamo DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmPrestamos f = new frmPrestamos();
                f.ShowDialog();
            }
        }
    }
}
