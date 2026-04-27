namespace Biblioteca.Usuario
{
    partial class frmAyudaPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPrestamos = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            cbFiltro = new ComboBox();
            bSalir = new Button();
            bAmpliar = new Button();
            dgvAyuda = new DataGridView();
            tbBusca = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label3 = new Label();
            cbFiltro2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dgvAyudaDevolver = new DataGridView();
            tbBusca2 = new TextBox();
            label4 = new Label();
            tabPrestamos.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAyuda).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAyudaDevolver).BeginInit();
            SuspendLayout();
            // 
            // tabPrestamos
            // 
            tabPrestamos.Controls.Add(tabPage1);
            tabPrestamos.Controls.Add(tabPage2);
            tabPrestamos.Dock = DockStyle.Fill;
            tabPrestamos.Location = new Point(0, 0);
            tabPrestamos.Name = "tabPrestamos";
            tabPrestamos.SelectedIndex = 0;
            tabPrestamos.Size = new Size(1070, 612);
            tabPrestamos.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cbFiltro);
            tabPage1.Controls.Add(bSalir);
            tabPage1.Controls.Add(bAmpliar);
            tabPage1.Controls.Add(dgvAyuda);
            tabPage1.Controls.Add(tbBusca);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1062, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Prestamos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(834, 22);
            label2.Name = "label2";
            label2.Size = new Size(47, 36);
            label2.TabIndex = 13;
            label2.Text = "Por:";
            // 
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(887, 22);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(151, 36);
            cbFiltro.TabIndex = 12;
            // 
            // bSalir
            // 
            bSalir.Image = Properties.Resources.Cancelar;
            bSalir.Location = new Point(858, 491);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(112, 85);
            bSalir.TabIndex = 9;
            bSalir.UseVisualStyleBackColor = true;
            bSalir.Click += bSalir_Click;
            // 
            // bAmpliar
            // 
            bAmpliar.Image = Properties.Resources.Ampliar;
            bAmpliar.Location = new Point(740, 491);
            bAmpliar.Name = "bAmpliar";
            bAmpliar.Size = new Size(112, 85);
            bAmpliar.TabIndex = 8;
            bAmpliar.UseVisualStyleBackColor = true;
            bAmpliar.Click += bAmpliar_Click;
            // 
            // dgvAyuda
            // 
            dgvAyuda.AllowUserToAddRows = false;
            dgvAyuda.AllowUserToDeleteRows = false;
            dgvAyuda.AllowUserToResizeColumns = false;
            dgvAyuda.AllowUserToResizeRows = false;
            dgvAyuda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAyuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAyuda.Location = new Point(8, 64);
            dgvAyuda.Name = "dgvAyuda";
            dgvAyuda.ReadOnly = true;
            dgvAyuda.RowHeadersWidth = 51;
            dgvAyuda.Size = new Size(962, 402);
            dgvAyuda.TabIndex = 7;
            // 
            // tbBusca
            // 
            tbBusca.Font = new Font("Segoe UI", 12F);
            tbBusca.Location = new Point(67, 19);
            tbBusca.Name = "tbBusca";
            tbBusca.Size = new Size(761, 34);
            tbBusca.TabIndex = 6;
            tbBusca.TextChanged += tbBusca_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 36);
            label1.TabIndex = 5;
            label1.Text = "Filtro:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cbFiltro2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dgvAyudaDevolver);
            tabPage2.Controls.Add(tbBusca2);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1062, 579);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Por Devolver";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(843, 14);
            label3.Name = "label3";
            label3.Size = new Size(47, 36);
            label3.TabIndex = 20;
            label3.Text = "Por:";
            // 
            // cbFiltro2
            // 
            cbFiltro2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFiltro2.FormattingEnabled = true;
            cbFiltro2.Location = new Point(896, 14);
            cbFiltro2.Name = "cbFiltro2";
            cbFiltro2.Size = new Size(151, 36);
            cbFiltro2.TabIndex = 19;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Cancelar;
            button1.Location = new Point(867, 483);
            button1.Name = "button1";
            button1.Size = new Size(112, 85);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Ampliar;
            button2.Location = new Point(749, 483);
            button2.Name = "button2";
            button2.Size = new Size(112, 85);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvAyudaDevolver
            // 
            dgvAyudaDevolver.AllowUserToAddRows = false;
            dgvAyudaDevolver.AllowUserToDeleteRows = false;
            dgvAyudaDevolver.AllowUserToResizeColumns = false;
            dgvAyudaDevolver.AllowUserToResizeRows = false;
            dgvAyudaDevolver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAyudaDevolver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAyudaDevolver.Location = new Point(17, 56);
            dgvAyudaDevolver.Name = "dgvAyudaDevolver";
            dgvAyudaDevolver.ReadOnly = true;
            dgvAyudaDevolver.RowHeadersWidth = 51;
            dgvAyudaDevolver.Size = new Size(962, 402);
            dgvAyudaDevolver.TabIndex = 16;
            // 
            // tbBusca2
            // 
            tbBusca2.Font = new Font("Segoe UI", 12F);
            tbBusca2.Location = new Point(76, 11);
            tbBusca2.Name = "tbBusca2";
            tbBusca2.Size = new Size(761, 34);
            tbBusca2.TabIndex = 15;
            tbBusca2.TextChanged += tbBusca1_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(77, 36);
            label4.TabIndex = 14;
            label4.Text = "Filtro:";
            // 
            // frmAyudaPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 612);
            ControlBox = false;
            Controls.Add(tabPrestamos);
            Name = "frmAyudaPrestamos";
            Text = "ABC Vista de Prestamos";
            Load += frmAyudaPrestamos_Load;
            tabPrestamos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAyuda).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAyudaDevolver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPrestamos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button bSalir;
        private Button bAmpliar;
        private DataGridView dgvAyuda;
        private TextBox tbBusca;
        private Label label1;
        private Label label2;
        private ComboBox cbFiltro;
        private Label label3;
        private ComboBox cbFiltro2;
        private Button button1;
        private Button button2;
        private DataGridView dgvAyudaDevolver;
        private TextBox tbBusca2;
        private Label label4;
    }
}