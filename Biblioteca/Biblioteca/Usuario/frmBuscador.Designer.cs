namespace Biblioteca.Usuario
{
    partial class frmBuscador
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
            bSalir = new Button();
            bAceptar = new Button();
            dgvAyuda = new DataGridView();
            tbBusca = new TextBox();
            label1 = new Label();
            cbFiltro = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAyuda).BeginInit();
            SuspendLayout();
            // 
            // bSalir
            // 
            bSalir.Image = Properties.Resources.Cancelar;
            bSalir.Location = new Point(851, 494);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(112, 85);
            bSalir.TabIndex = 9;
            bSalir.UseVisualStyleBackColor = true;
            bSalir.Click += btCancelar_Click;
            // 
            // bAceptar
            // 
            bAceptar.Image = Properties.Resources.Ok;
            bAceptar.Location = new Point(733, 494);
            bAceptar.Name = "bAceptar";
            bAceptar.Size = new Size(112, 85);
            bAceptar.TabIndex = 8;
            bAceptar.UseVisualStyleBackColor = true;
            bAceptar.Click += btAceptar_Click;
            // 
            // dgvAyuda
            // 
            dgvAyuda.AllowUserToAddRows = false;
            dgvAyuda.AllowUserToDeleteRows = false;
            dgvAyuda.AllowUserToResizeColumns = false;
            dgvAyuda.AllowUserToResizeRows = false;
            dgvAyuda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAyuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAyuda.Location = new Point(1, 67);
            dgvAyuda.Name = "dgvAyuda";
            dgvAyuda.RowHeadersWidth = 51;
            dgvAyuda.Size = new Size(962, 402);
            dgvAyuda.TabIndex = 7;
            dgvAyuda.CellDoubleClick += dgAyuda_CellDoubleClick;
            dgvAyuda.KeyDown += dgAyuda_KeyDown;
            // 
            // tbBusca
            // 
            tbBusca.Font = new Font("Segoe UI", 12F);
            tbBusca.Location = new Point(62, 11);
            tbBusca.Name = "tbBusca";
            tbBusca.Size = new Size(708, 34);
            tbBusca.TabIndex = 6;
            tbBusca.TextChanged += tbBusca_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 11);
            label1.Name = "label1";
            label1.Size = new Size(77, 36);
            label1.TabIndex = 5;
            label1.Text = "Filtro:";
            // 
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(851, 8);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(151, 36);
            cbFiltro.TabIndex = 10;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(798, 8);
            label2.Name = "label2";
            label2.Size = new Size(47, 36);
            label2.TabIndex = 11;
            label2.Text = "Por:";
            // 
            // frmBuscador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 600);
            Controls.Add(label2);
            Controls.Add(cbFiltro);
            Controls.Add(bSalir);
            Controls.Add(bAceptar);
            Controls.Add(dgvAyuda);
            Controls.Add(tbBusca);
            Controls.Add(label1);
            Name = "frmBuscador";
            Text = "frmBuscador";
            Load += frmBuscador_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAyuda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSalir;
        private Button bAceptar;
        private DataGridView dgvAyuda;
        private TextBox tbBusca;
        private Label label1;
        private ComboBox cbFiltro;
        private Label label2;
    }
}