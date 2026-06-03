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
        DataView dv2;
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
            AplicarEstilo();
            llenarGrid1();
            llenarGrid2();
            llenarComboBoxs();
        }

        #region metodos de formulario
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

            consulta = "select " + campotabla1 + " " +
                        campotabla2 + " from " + tabla + " " + Condicion;
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

            consulta = "select " + campotabla1 + " " +
                        campotabla2 + " from " + tabla + " " + Condicion + " where devuelto = 'no'";
            
            dt = CConexion_BD.Consulta(consulta);
            dv2 = new DataView(dt);
           

            dgvAyudaDevolver.DataSource = dv2;
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

        private void tbBusca1_TextChanged(object sender, EventArgs e)
        {
            dv2.RowFilter = $"Convert([{cbFiltro2.Text}], 'System.String') LIKE '%{tbBusca2.Text}%'";
        }
        #endregion

        #region Configuracion
        private void AplicarEstilo()
        {
            // === COLORES ===
            Color verdeOscuro = ColorTranslator.FromHtml("#0F7A52");
            Color verdeTexto = ColorTranslator.FromHtml("#1A5C3A");
            Color verdeClaro = ColorTranslator.FromHtml("#EAF9F2");
            Color verdeAlterna = ColorTranslator.FromHtml("#F0FBF6");
            Color verdeSelect = ColorTranslator.FromHtml("#B2F0DC");
            Color bordeColor = ColorTranslator.FromHtml("#A8E8CC");

            // === FORMULARIO ===
            this.BackColor = verdeClaro;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // === TAB CONTROL ===
            tabPrestamos.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabPrestamos.ItemSize = new Size(160, 36);
            tabPrestamos.SizeMode = TabSizeMode.Fixed;
            tabPrestamos.DrawItem += (s, e) =>
            {
                TabPage tp = tabPrestamos.TabPages[e.Index];
                bool seleccionada = (e.Index == tabPrestamos.SelectedIndex);

                Color bgTab = seleccionada ? verdeOscuro : ColorTranslator.FromHtml("#C8EEE0");
                Color txtTab = seleccionada ? Color.White : verdeTexto;

                e.Graphics.FillRectangle(new SolidBrush(bgTab), e.Bounds);

                string icono = e.Index == 0 ? "▶  " : "↩  ";
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(icono + tp.Text,
                    new Font("Segoe UI", 10f, seleccionada ? FontStyle.Bold : FontStyle.Regular),
                    new SolidBrush(txtTab), e.Bounds, sf);
            };

            // === ESTILO COMPARTIDO PARA AMBAS TABPAGES ===
            foreach (TabPage tab in tabPrestamos.TabPages)
            {
                tab.BackColor = verdeClaro;
                tab.Padding = new Padding(8);
            }

            // === PANEL SUPERIOR TAB 1 ===
            Panel panelTop1 = new Panel();
            panelTop1.BackColor = verdeOscuro;
            panelTop1.Size = new Size(tabPage1.Width, 58);
            panelTop1.Location = new Point(0, 0);
            tabPage1.Controls.Add(panelTop1);
            panelTop1.BringToFront();

            Label lblTitulo1 = new Label();
            lblTitulo1.Text = "📋  Préstamos";
            lblTitulo1.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            lblTitulo1.ForeColor = Color.White;
            lblTitulo1.AutoSize = true;
            lblTitulo1.Location = new Point(16, 14);
            panelTop1.Controls.Add(lblTitulo1);

            // === PANEL SUPERIOR TAB 2 ===
            Panel panelTop2 = new Panel();
            panelTop2.BackColor = verdeOscuro;
            panelTop2.Size = new Size(tabPage2.Width, 58);
            panelTop2.Location = new Point(0, 0);
            tabPage2.Controls.Add(panelTop2);
            panelTop2.BringToFront();

            Label lblTitulo2 = new Label();
            lblTitulo2.Text = "↩  Por Devolver";
            lblTitulo2.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            lblTitulo2.ForeColor = Color.White;
            lblTitulo2.AutoSize = true;
            lblTitulo2.Location = new Point(16, 14);
            panelTop2.Controls.Add(lblTitulo2);

            // === CONTROLES TAB 1 ===
            label1.ForeColor = verdeTexto;
            label1.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label1.Location = new Point(8, 72);

            tbBusca.Font = new Font("Segoe UI", 11f);
            tbBusca.BackColor = Color.White;
            tbBusca.ForeColor = verdeTexto;
            tbBusca.BorderStyle = BorderStyle.FixedSingle;
            tbBusca.Location = new Point(70, 70);

            label2.ForeColor = verdeTexto;
            label2.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label2.Location = new Point(834, 72);

            cbFiltro.Font = new Font("Segoe UI", 11f);
            cbFiltro.BackColor = Color.White;
            cbFiltro.ForeColor = verdeTexto;
            cbFiltro.FlatStyle = FlatStyle.Flat;
            cbFiltro.Location = new Point(887, 70);

            dgvAyuda.Location = new Point(8, 115);
            dgvAyuda.Size = new Size(dgvAyuda.Width, tabPage1.Height - 115 - 90); // 90 = altura panel inferior
            EstilarGrid(dgvAyuda, verdeOscuro, verdeTexto, verdeSelect, verdeAlterna);

            // === CONTROLES TAB 2 ===
            label4.ForeColor = verdeTexto;
            label4.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label4.Location = new Point(15, 72);

            tbBusca2.Font = new Font("Segoe UI", 11f);
            tbBusca2.BackColor = Color.White;
            tbBusca2.ForeColor = verdeTexto;
            tbBusca2.BorderStyle = BorderStyle.FixedSingle;
            tbBusca2.Location = new Point(78, 70);

            label3.ForeColor = verdeTexto;
            label3.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            label3.Location = new Point(843, 72);

            cbFiltro2.Font = new Font("Segoe UI", 11f);
            cbFiltro2.BackColor = Color.White;
            cbFiltro2.ForeColor = verdeTexto;
            cbFiltro2.FlatStyle = FlatStyle.Flat;
            cbFiltro2.Location = new Point(896, 70);

            dgvAyudaDevolver.Location = new Point(17, 115);
            dgvAyudaDevolver.Size = new Size(dgvAyudaDevolver.Width, tabPage2.Height - 115 - 90);
            EstilarGrid(dgvAyudaDevolver, verdeOscuro, verdeTexto, verdeSelect, verdeAlterna);

            // === PANEL INFERIOR TAB 1 ===
            Panel panelBot1 = new Panel();
            panelBot1.BackColor = ColorTranslator.FromHtml("#D4F5E8");
            panelBot1.Size = new Size(tabPage1.Width, 80);
            panelBot1.Dock = DockStyle.Bottom;
            tabPage1.Controls.Add(panelBot1);

            bAmpliar.Parent = panelBot1;
            bAmpliar.FlatStyle = FlatStyle.Flat;
            bAmpliar.FlatAppearance.BorderColor = verdeOscuro;
            bAmpliar.FlatAppearance.BorderSize = 2;
            bAmpliar.BackColor = Color.White;
            bAmpliar.Size = new Size(100, 60);
            bAmpliar.Location = new Point(panelBot1.Width - 220, 10);
            bAmpliar.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            bAmpliar.Cursor = Cursors.Hand;

            bSalir.Parent = panelBot1;
            bSalir.FlatStyle = FlatStyle.Flat;
            bSalir.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C0392B");
            bSalir.FlatAppearance.BorderSize = 2;
            bSalir.BackColor = Color.White;
            bSalir.Size = new Size(100, 60);
            bSalir.Location = new Point(panelBot1.Width - 112, 10);
            bSalir.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            bSalir.Cursor = Cursors.Hand;

            // === PANEL INFERIOR TAB 2 ===
            Panel panelBot2 = new Panel();
            panelBot2.BackColor = ColorTranslator.FromHtml("#D4F5E8");
            panelBot2.Size = new Size(tabPage2.Width, 80);
            panelBot2.Dock = DockStyle.Bottom;
            tabPage2.Controls.Add(panelBot2);

            button2.Parent = panelBot2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = verdeOscuro;
            button2.FlatAppearance.BorderSize = 2;
            button2.BackColor = Color.White;
            button2.Size = new Size(100, 60);
            button2.Location = new Point(panelBot2.Width - 220, 10);
            button2.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            button2.Cursor = Cursors.Hand;

            button1.Parent = panelBot2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C0392B");
            button1.FlatAppearance.BorderSize = 2;
            button1.BackColor = Color.White;
            button1.Size = new Size(100, 60);
            button1.Location = new Point(panelBot2.Width - 112, 10);
            button1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            button1.Cursor = Cursors.Hand;
        }

        // Método reutilizable para estilizar cualquier DataGridView
        private void EstilarGrid(DataGridView dgv, Color cabecera, Color texto, Color seleccion, Color alterna)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = ColorTranslator.FromHtml("#C8EEE0");
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = cabecera;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgv.ColumnHeadersHeight = 40;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = texto;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.DefaultCellStyle.SelectionBackColor = seleccion;
            dgv.DefaultCellStyle.SelectionForeColor = texto;
            dgv.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dgv.RowTemplate.Height = 36;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = alterna;
        }
        #endregion
    }
}
