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
            frmAyuda ayuda = new frmAyuda("Ayuda de Roles", "id_rol", "Nombre", "Roles", "WHERE id_rol IN ( SELECT TOP 3 id_rol FROM Roles ORDER BY id_rol DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmRoles f = new frmRoles();
                f.ShowDialog();
            }
        }
    }
}
