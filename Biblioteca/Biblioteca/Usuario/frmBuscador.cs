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
            AplicarEstilo();
            clave = descripcion = "";
            this.Text = nombreFormulario;
            ds.Clear();
            string consulta;
            DataTable dt = new DataTable();

            consulta = "select " + campotabla1 + " Clave ," +
                       campotabla2 + " busqueda, * from " + tabla + " " + Condicion;

            dt = CConexion_BD.Consulta(consulta);
            dv = new DataView(dt);

            dgvAyuda.DataSource = dv;
            cbFiltro.Items.Clear();

            foreach (DataGridViewColumn columna in dgvAyuda.Columns)
            {
               
                cbFiltro.Items.Add(columna.HeaderText);
            }

            if (cbFiltro.Items.Count > 0)
            {
                cbFiltro.SelectedIndex = 0;
            }
        }

        #region metodos de formulario

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
        #endregion

        #region configuracion
        private void AplicarEstilo()
        {
            Color verdeOscuro = ColorTranslator.FromHtml("#0F7A52");
            Color verdeMedio = ColorTranslator.FromHtml("#158F61");
            Color verdeClaro = ColorTranslator.FromHtml("#EAF9F2");
            Color verdeTexto = ColorTranslator.FromHtml("#1A5C3A");
            Color verdeAlterna = ColorTranslator.FromHtml("#F0FBF6");
            Color verdeSelect = ColorTranslator.FromHtml("#B2F0DC");
            Color bordeColor = ColorTranslator.FromHtml("#A8E8CC");

            // === FORMULARIO ===
            this.BackColor = verdeClaro;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // === PANEL TÍTULO ===
            Panel panelTitulo = new Panel();
            panelTitulo.BackColor = verdeOscuro;
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Height = 50;
            this.Controls.Add(panelTitulo);
            panelTitulo.BringToFront();

            Label lblTitulo = new Label();
            lblTitulo.Text = "🔍  " + nombreFormulario;
            lblTitulo.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(16, 12);
            panelTitulo.Controls.Add(lblTitulo);

            // === REPOSICIONAR CONTROLES DEBAJO DEL TÍTULO ===
            int offsetY = panelTitulo.Height + 12;

            label1.ForeColor = verdeTexto;
            label1.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label1.Location = new Point(label1.Location.X, offsetY);

            tbBusca.Font = new Font("Segoe UI", 11f);
            tbBusca.BackColor = Color.White;
            tbBusca.ForeColor = verdeTexto;
            tbBusca.BorderStyle = BorderStyle.FixedSingle;
            tbBusca.Location = new Point(tbBusca.Location.X, offsetY - 2);

            label2.ForeColor = verdeTexto;
            label2.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label2.Location = new Point(label2.Location.X, offsetY);

            cbFiltro.Font = new Font("Segoe UI", 11f);
            cbFiltro.BackColor = Color.White;
            cbFiltro.ForeColor = verdeTexto;
            cbFiltro.FlatStyle = FlatStyle.Flat;
            cbFiltro.Location = new Point(cbFiltro.Location.X, offsetY - 2);

            dgvAyuda.Location = new Point(dgvAyuda.Location.X, offsetY + 46);
            dgvAyuda.Height = this.ClientSize.Height - offsetY - 46 - 100;
            dgvAyuda.BackgroundColor = Color.White;
            dgvAyuda.BorderStyle = BorderStyle.None;
            dgvAyuda.GridColor = ColorTranslator.FromHtml("#C8EEE0");
            dgvAyuda.RowHeadersVisible = false;
            dgvAyuda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAyuda.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAyuda.EnableHeadersVisualStyles = false;

            dgvAyuda.ColumnHeadersDefaultCellStyle.BackColor = verdeOscuro;
            dgvAyuda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAyuda.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvAyuda.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvAyuda.ColumnHeadersHeight = 40;

            dgvAyuda.DefaultCellStyle.BackColor = Color.White;
            dgvAyuda.DefaultCellStyle.ForeColor = verdeTexto;
            dgvAyuda.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgvAyuda.DefaultCellStyle.SelectionBackColor = verdeSelect;
            dgvAyuda.DefaultCellStyle.SelectionForeColor = verdeTexto;
            dgvAyuda.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dgvAyuda.RowTemplate.Height = 36;
            dgvAyuda.AlternatingRowsDefaultCellStyle.BackColor = verdeAlterna;

            // === PANEL INFERIOR ===
            Panel panelBot = new Panel();
            panelBot.BackColor = ColorTranslator.FromHtml("#D4F5E8");
            panelBot.Dock = DockStyle.Bottom;
            panelBot.Height = 90;
            this.Controls.Add(panelBot);
            panelBot.BringToFront();

            bAceptar.Parent = panelBot;
            bAceptar.FlatStyle = FlatStyle.Flat;
            bAceptar.FlatAppearance.BorderColor = verdeOscuro;
            bAceptar.FlatAppearance.BorderSize = 2;
            bAceptar.BackColor = Color.White;
            bAceptar.Size = new Size(100, 65);
            bAceptar.Location = new Point(panelBot.Width - 220, 12);
            bAceptar.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            bAceptar.Cursor = Cursors.Hand;

            bSalir.Parent = panelBot;
            bSalir.FlatStyle = FlatStyle.Flat;
            bSalir.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C0392B");
            bSalir.FlatAppearance.BorderSize = 2;
            bSalir.BackColor = Color.White;
            bSalir.Size = new Size(100, 65);
            bSalir.Location = new Point(panelBot.Width - 112, 12);
            bSalir.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            bSalir.Cursor = Cursors.Hand;
        }
        #endregion
    }
}
