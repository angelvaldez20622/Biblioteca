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
    }
}
