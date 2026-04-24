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
    public partial class frmAyudaPrestamos : Form
    {

        private string nombreFormulario;
        private string campotabla1;
        private string campotabla2;
        private string tabla;
        private string Condicion;

        public string seleccion;
        public string clave;
        public string descripcion;
        DataView dv;
        DataSet ds = new DataSet();
        public frmAyudaPrestamos(string nom, string cam1, string cam2, string tab, string Con)
        {
            nombreFormulario = nom;
            campotabla1 = cam1;
            campotabla2 = cam2;
            tabla = tab;
            Condicion = Con;
            InitializeComponent();
        }

        private void frmAyudaPrestamos_Load(object sender, EventArgs e)
        {
            llenarGrid1();
            llenarGrid2();
            llenarComboBoxs();
        }

        private void llenarComboBoxs()
        {
            // ---------------------------cbFiltro----------------------------------
            cbFiltro.Items.Clear();

            // Recorrer las columnas del DataGridView
            foreach (DataGridViewColumn columna in dgvAyuda.Columns)
            {
                // Agregamos el nombre (o el texto de la cabecera) al ComboBox
                cbFiltro.Items.Add(columna.HeaderText);
            }

            // Opcional: Seleccionar el primer elemento por defecto
            if (cbFiltro.Items.Count > 0)
            {
                cbFiltro.SelectedIndex = 0;
            }

            //-----------------------------cbFiltro2-------------------------------
            cbFiltro2.Items.Clear();
            foreach (DataGridViewColumn columna in dgvAyudaDevolver.Columns)
            {
                // Agregamos el nombre (o el texto de la cabecera) al ComboBox
                cbFiltro2.Items.Add(columna.HeaderText);
            }

            // Opcional: Seleccionar el primer elemento por defecto
            if (cbFiltro2.Items.Count > 0)
            {
                cbFiltro2.SelectedIndex = 0;
            }
        }
        private void llenarGrid1()
        {
            clave = descripcion = "";
            this.Text = nombreFormulario;
            ds.Clear();
            string consulta;
            DataTable dt = new DataTable();

            consulta = "select top 20 * from " + tabla + " " + Condicion;

            dt = CConexion_BD.Consulta(consulta);
            dv = new DataView(dt);

            dgvAyuda.DataSource = dv;
            seleccion = "no";

        }
        private void llenarGrid2()
        {
            clave = descripcion = "";
            this.Text = nombreFormulario;
            ds.Clear();
            string consulta;
            DataTable dt = new DataTable();

            consulta = "select top 20 * from " + tabla + " " + Condicion + " and devuelto = 'no'";

            dt = CConexion_BD.Consulta(consulta);
            dv = new DataView(dt);

            dgvAyudaDevolver.DataSource = dv;
            seleccion = "no";
        }
        private void tbBusca_TextChanged(object sender, EventArgs e)
        {
            Condicion = $"where {cbFiltro.Text} like '%{tbBusca.Text}%'";
            llenarGrid1();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAmpliar_Click(object sender, EventArgs e)
        {
            seleccion = "si";
            Close();
        }

        private void tbBusca1_TextChanged(object sender, EventArgs e)
        {
            Condicion = $"where {cbFiltro2.Text} like '%{tbBusca2.Text}%'";
            llenarGrid2();
        }
    }
}
