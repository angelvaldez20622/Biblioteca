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
    public partial class frmBuscador : Form
    {

        private string nombreFormulario;
        private string campotabla1;
        private string campotabla2;
        private string tabla;
        private string Condicion;
        public string clave;
        public string descripcion;
        DataView dv;

        DataSet ds = new DataSet();

        public frmBuscador(string nom, string cam1, string cam2, string tab, string Con)
        {
            nombreFormulario = nom;
            campotabla1 = cam1;
            campotabla2 = cam2;
            tabla = tab;
            Condicion = Con;
            InitializeComponent();
        }
        public frmBuscador() { }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            clave = descripcion = "";
            this.Text = nombreFormulario;
            ds.Clear();
            string consulta;
            DataTable dt = new DataTable();

            consulta = "select " + campotabla1 + " Clave ," +
                       campotabla2 + " busqueda, * from " + tabla + " " + Condicion ;

            dt = CConexion_BD.Consulta(consulta);
            dv = new DataView(dt);

            dgvAyuda.DataSource = dv;
            // Limpiar el ComboBox para evitar duplicados
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
        }
        
        private void btAceptar_Click(object sender, EventArgs e)
        {
            clave = dgvAyuda.CurrentRow.Cells[0].Value.ToString();
            descripcion = dgvAyuda.CurrentRow.Cells[1].Value.ToString();
            Close();
        }

        private void dgAyuda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btAceptar_Click(sender, e);
            //clave = dgAyuda.CurrentRow.Cells[0].Value.ToString();
            //descripcion = dgAyuda.CurrentRow.Cells[1].Value.ToString();
            //Close();
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = $"Convert({ cbFiltro.Text}, 'System.String') LIKE '%" + tbBusca.Text+ "%'";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgAyuda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAceptar_Click(sender, e);
            }
        }
    }
}
