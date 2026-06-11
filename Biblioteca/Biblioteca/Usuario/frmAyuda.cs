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

        public string seleccion;
        public string clave;
        public string descripcion;
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
            AplicarEstilo();
            llenarGrid();



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
        private void llenarGrid()
        {
            clave = descripcion = "";
            this.Text = nombreFormulario;
            ds.Clear();
            string consulta;
            DataTable dt = new DataTable();

            consulta = "select " + campotabla1 + " " +
                      campotabla2 + " from " + tabla + " " + Condicion;

            dt = CConexion_BD.Consulta(consulta);
            dv = new DataView(dt);

            dgvAyuda.DataSource = dv;
            seleccion = "no";
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = $"Convert([{cbFiltro.Text}], 'System.String') LIKE '%{tbBusca.Text}%'";
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

        private void dgvAyuda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Configuracion
        private void AplicarEstilo()
        {
            // === FORMULARIO ===
            this.BackColor = ColorTranslator.FromHtml("#EAF9F2");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // === COLORES ===
            Color verdeOscuro = ColorTranslator.FromHtml("#0F7A52");
            Color verdeMedio = ColorTranslator.FromHtml("#D4F5E8");
            Color verdeClaro = ColorTranslator.FromHtml("#EAF9F2");
            Color verdeTexto = ColorTranslator.FromHtml("#1A5C3A");
            Color bordeColor = ColorTranslator.FromHtml("#A8E8CC");

            // === PANEL SUPERIOR (barra de título interna) ===
            Panel panelTop = new Panel();
            panelTop.BackColor = verdeOscuro;
            panelTop.Size = new Size(this.ClientSize.Width, 70);
            panelTop.Location = new Point(0, 0);
            panelTop.Dock = DockStyle.Top;

            Label lblTitulo = new Label();
            lblTitulo.Text = nombreFormulario;
            lblTitulo.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 18);
            panelTop.Controls.Add(lblTitulo);
            this.Controls.Add(panelTop);
            panelTop.BringToFront();

            // === LABEL FILTRO ===
            label1.ForeColor = verdeTexto;
            label1.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label1.Location = new Point(23, 85);

            // === TEXTBOX BUSCA ===
            tbBusca.Font = new Font("Segoe UI", 11f);
            tbBusca.BackColor = Color.White;
            tbBusca.ForeColor = verdeTexto;
            tbBusca.BorderStyle = BorderStyle.FixedSingle;
            tbBusca.Location = new Point(84, 83);

            // === LABEL "Por:" ===
            label2.ForeColor = verdeTexto;
            label2.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label2.Location = new Point(795, 85);

            // === COMBOBOX FILTRO ===
            cbFiltro.Font = new Font("Segoe UI", 11f);
            cbFiltro.BackColor = Color.White;
            cbFiltro.ForeColor = verdeTexto;
            cbFiltro.FlatStyle = FlatStyle.Flat;
            cbFiltro.Location = new Point(834, 83);

            // === DATAGRIDVIEW ===
            dgvAyuda.Location = new Point(23, 135);
            dgvAyuda.BackgroundColor = Color.White;
            dgvAyuda.BorderStyle = BorderStyle.None;
            dgvAyuda.GridColor = ColorTranslator.FromHtml("#C8EEE0");
            dgvAyuda.RowHeadersVisible = false;
            dgvAyuda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAyuda.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAyuda.EnableHeadersVisualStyles = false;

            // Cabeceras
            dgvAyuda.ColumnHeadersDefaultCellStyle.BackColor = verdeOscuro;
            dgvAyuda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAyuda.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvAyuda.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvAyuda.ColumnHeadersHeight = 40;

            // Filas
            dgvAyuda.DefaultCellStyle.BackColor = Color.White;
            dgvAyuda.DefaultCellStyle.ForeColor = verdeTexto;
            dgvAyuda.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgvAyuda.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#B2F0DC");
            dgvAyuda.DefaultCellStyle.SelectionForeColor = verdeTexto;
            dgvAyuda.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dgvAyuda.RowTemplate.Height = 36;

            // Filas alternas
            dgvAyuda.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F0FBF6");

            // === PANEL INFERIOR (botones) ===
            Panel panelBot = new Panel();
            panelBot.BackColor = ColorTranslator.FromHtml("#D4F5E8");
            panelBot.Size = new Size(this.ClientSize.Width, 90);
            panelBot.Dock = DockStyle.Bottom;
            this.Controls.Add(panelBot);
            panelBot.BringToFront();

            // Mover botones al panel inferior
            bAmpliar.Parent = panelBot;
            bSalir.Parent = panelBot;

            // Estilo botón Ampliar
            bAmpliar.FlatStyle = FlatStyle.Flat;
            bAmpliar.FlatAppearance.BorderColor = verdeOscuro;
            bAmpliar.FlatAppearance.BorderSize = 2;
            bAmpliar.BackColor = Color.White;
            bAmpliar.Size = new Size(100, 65);
            bAmpliar.Location = new Point(panelBot.Width - 230, 12);
            bAmpliar.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            bAmpliar.Cursor = Cursors.Hand;

            // Estilo botón Salir
            bSalir.FlatStyle = FlatStyle.Flat;
            bSalir.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C0392B");
            bSalir.FlatAppearance.BorderSize = 2;
            bSalir.BackColor = Color.White;
            bSalir.Size = new Size(100, 65);
            bSalir.Location = new Point(panelBot.Width - 120, 12);
            bSalir.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            bSalir.Cursor = Cursors.Hand;
        }
        #endregion

    }
}
