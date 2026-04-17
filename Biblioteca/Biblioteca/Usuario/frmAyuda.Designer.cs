namespace Biblioteca.Usuario
{
    partial class frmAyuda
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
            label1 = new Label();
            tbBusca = new TextBox();
            dgvAyuda = new DataGridView();
            bAmpliar = new Button();
            bSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAyuda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(77, 36);
            label1.TabIndex = 0;
            label1.Text = "Filtro:";
            // 
            // tbBusca
            // 
            tbBusca.Font = new Font("Segoe UI", 12F);
            tbBusca.Location = new Point(84, 39);
            tbBusca.Name = "tbBusca";
            tbBusca.Size = new Size(872, 34);
            tbBusca.TabIndex = 1;
            tbBusca.TextChanged += tbBusca_TextChanged;
            // 
            // dgvAyuda
            // 
            dgvAyuda.AllowUserToAddRows = false;
            dgvAyuda.AllowUserToDeleteRows = false;
            dgvAyuda.AllowUserToResizeColumns = false;
            dgvAyuda.AllowUserToResizeRows = false;
            dgvAyuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAyuda.Location = new Point(23, 95);
            dgvAyuda.Name = "dgvAyuda";
            dgvAyuda.RowHeadersWidth = 51;
            dgvAyuda.Size = new Size(962, 402);
            dgvAyuda.TabIndex = 2;
            // 
            // bAmpliar
            // 
            bAmpliar.Location = new Point(755, 546);
            bAmpliar.Name = "bAmpliar";
            bAmpliar.Size = new Size(112, 61);
            bAmpliar.TabIndex = 3;
            bAmpliar.Text = "ampliar";
            bAmpliar.UseVisualStyleBackColor = true;
            // 
            // bSalir
            // 
            bSalir.Location = new Point(873, 546);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(112, 61);
            bSalir.TabIndex = 4;
            bSalir.Text = "salir";
            bSalir.UseVisualStyleBackColor = true;
            bSalir.Click += bSalir_Click;
            // 
            // frmAyuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 638);
            Controls.Add(bSalir);
            Controls.Add(bAmpliar);
            Controls.Add(dgvAyuda);
            Controls.Add(tbBusca);
            Controls.Add(label1);
            Name = "frmAyuda";
            Text = "frmAyuda";
            Load += frmAyuda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAyuda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbBusca;
        private DataGridView dgvAyuda;
        private Button bAmpliar;
        private Button bSalir;
    }
}