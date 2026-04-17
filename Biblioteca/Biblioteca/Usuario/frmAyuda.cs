using Biblioteca.Base_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Usuario
{
    public partial class frmAyuda : Form
    {
        private string nombreFormulario;
        private string campotabla1;
        private string campotabla2;
        private string tabla;
        private string Condicion;
        string clave { get; set; }
        string descripcion { get; set; }
        DataView dv;
        DataSet ds = new DataSet();

        public frmAyuda(string nom, string cam1, string cam2, string tab, string Con)
        {
            nombreFormulario = nom;
            campotabla1 = cam1;
            campotabla2 = cam2;
            tabla = tab;
            Condicion = Con;
            InitializeComponent();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            clave = descripcion = "";
            this.Text = nombreFormulario;
            ds.Clear();
            string consulta;
            DataTable dt = new DataTable();

            consulta = "select " + campotabla1 + " Clave," +
                       campotabla2 + " busqueda, * from " + tabla + " " + Condicion + " order by busqueda";

            dt = CConexion_BD.Consulta(consulta);
            dv = new DataView(dt);

            dgvAyuda.DataSource = dv;
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "busqueda LIKE '%" + tbBusca.Text + "%'";
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
