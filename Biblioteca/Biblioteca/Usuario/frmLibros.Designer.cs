namespace Biblioteca.Usuario
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            bCancelar = new Button();
            pEncabezado = new Panel();
            cbAutor = new ComboBox();
            cbCategoria = new ComboBox();
            tbExistencias = new TextBox();
            label4 = new Label();
            tbAño = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbNombre = new TextBox();
            lNombre = new Label();
            tbId = new TextBox();
            lId = new Label();
            toolStrip1 = new ToolStrip();
            tsbPrimero = new ToolStripButton();
            tsbAnterior = new ToolStripButton();
            tsbSiguiente = new ToolStripButton();
            tsbUltimo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbGuardar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbNuevo = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbEliminar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbBuscar = new ToolStripButton();
            pEncabezado.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bCancelar
            // 
            bCancelar.Image = (Image)resources.GetObject("bCancelar.Image");
            bCancelar.Location = new Point(656, 367);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(76, 69);
            bCancelar.TabIndex = 11;
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click_1;
            // 
            // pEncabezado
            // 
            pEncabezado.Controls.Add(cbAutor);
            pEncabezado.Controls.Add(cbCategoria);
            pEncabezado.Controls.Add(tbExistencias);
            pEncabezado.Controls.Add(label4);
            pEncabezado.Controls.Add(tbAño);
            pEncabezado.Controls.Add(label3);
            pEncabezado.Controls.Add(label2);
            pEncabezado.Controls.Add(label1);
            pEncabezado.Controls.Add(tbNombre);
            pEncabezado.Controls.Add(lNombre);
            pEncabezado.Controls.Add(tbId);
            pEncabezado.Controls.Add(lId);
            pEncabezado.Location = new Point(1, 92);
            pEncabezado.Name = "pEncabezado";
            pEncabezado.Size = new Size(731, 256);
            pEncabezado.TabIndex = 10;
            // 
            // cbAutor
            // 
            cbAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAutor.Font = new Font("Segoe UI", 12F);
            cbAutor.FormattingEnabled = true;
            cbAutor.Location = new Point(160, 82);
            cbAutor.Name = "cbAutor";
            cbAutor.Size = new Size(244, 36);
            cbAutor.TabIndex = 13;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Font = new Font("Segoe UI", 12F);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(160, 120);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(244, 36);
            cbCategoria.TabIndex = 12;
            // 
            // tbExistencias
            // 
            tbExistencias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbExistencias.Location = new Point(160, 202);
            tbExistencias.Name = "tbExistencias";
            tbExistencias.Size = new Size(102, 34);
            tbExistencias.TabIndex = 11;
            tbExistencias.KeyPress += tbExistencias_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 202);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 10;
            label4.Text = "Existencias:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbAño
            // 
            tbAño.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAño.Location = new Point(160, 162);
            tbAño.Name = "tbAño";
            tbAño.Size = new Size(189, 34);
            tbAño.TabIndex = 9;
            tbAño.KeyPress += tbAño_KeyPress;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 162);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 8;
            label3.Text = "Año:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 122);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 6;
            label2.Text = "Categoria:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 82);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 4;
            label1.Text = "Autor:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(160, 42);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(488, 34);
            tbNombre.TabIndex = 3;
            // 
            // lNombre
            // 
            lNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombre.Location = new Point(53, 42);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(101, 28);
            lNombre.TabIndex = 2;
            lNombre.Text = "Nombre:";
            lNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(160, 2);
            tbId.Name = "tbId";
            tbId.Size = new Size(142, 34);
            tbId.TabIndex = 1;
            // 
            // lId
            // 
            lId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lId.Location = new Point(69, 2);
            lId.Name = "lId";
            lId.Size = new Size(85, 28);
            lId.TabIndex = 0;
            lId.Text = "Id:";
            lId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbPrimero, tsbAnterior, tsbSiguiente, tsbUltimo, toolStripSeparator1, tsbGuardar, tsbEditar, tsbNuevo, toolStripSeparator2, tsbEliminar, toolStripSeparator3, tsbBuscar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(817, 71);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrimero
            // 
            tsbPrimero.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPrimero.Image = (Image)resources.GetObject("tsbPrimero.Image");
            tsbPrimero.ImageScaling = ToolStripItemImageScaling.None;
            tsbPrimero.ImageTransparentColor = Color.Magenta;
            tsbPrimero.Name = "tsbPrimero";
            tsbPrimero.Size = new Size(68, 68);
            tsbPrimero.Text = "toolStripButton2";
            tsbPrimero.ToolTipText = "Primero";
            tsbPrimero.Click += tsbPrimero_Click;
            // 
            // tsbAnterior
            // 
            tsbAnterior.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAnterior.Image = (Image)resources.GetObject("tsbAnterior.Image");
            tsbAnterior.ImageScaling = ToolStripItemImageScaling.None;
            tsbAnterior.ImageTransparentColor = Color.Magenta;
            tsbAnterior.Name = "tsbAnterior";
            tsbAnterior.Size = new Size(68, 68);
            tsbAnterior.Text = "toolStripButton2";
            tsbAnterior.ToolTipText = "Anterior";
            tsbAnterior.Click += tsbAnterior_Click;
            // 
            // tsbSiguiente
            // 
            tsbSiguiente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSiguiente.Image = (Image)resources.GetObject("tsbSiguiente.Image");
            tsbSiguiente.ImageScaling = ToolStripItemImageScaling.None;
            tsbSiguiente.ImageTransparentColor = Color.Magenta;
            tsbSiguiente.Name = "tsbSiguiente";
            tsbSiguiente.Size = new Size(68, 68);
            tsbSiguiente.Text = "toolStripButton2";
            tsbSiguiente.ToolTipText = "Siguiente";
            tsbSiguiente.Click += tsbSiguiente_Click;
            // 
            // tsbUltimo
            // 
            tsbUltimo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbUltimo.Image = Properties.Resources.Siguiente_21;
            tsbUltimo.ImageScaling = ToolStripItemImageScaling.None;
            tsbUltimo.ImageTransparentColor = Color.Magenta;
            tsbUltimo.Name = "tsbUltimo";
            tsbUltimo.Size = new Size(68, 68);
            tsbUltimo.Text = "toolStripButton2";
            tsbUltimo.ToolTipText = "Ultimo";
            tsbUltimo.Click += tsbUltimo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 71);
            // 
            // tsbGuardar
            // 
            tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.ImageScaling = ToolStripItemImageScaling.None;
            tsbGuardar.ImageTransparentColor = Color.Magenta;
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(68, 68);
            tsbGuardar.Text = "toolStripButton2";
            tsbGuardar.ToolTipText = "Guardar";
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(68, 68);
            tsbEditar.Text = "toolStripButton2";
            tsbEditar.ToolTipText = "Editar";
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(68, 68);
            tsbNuevo.Text = "toolStripButton2";
            tsbNuevo.ToolTipText = "Nuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 71);
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(68, 68);
            tsbEliminar.Text = "toolStripButton2";
            tsbEliminar.ToolTipText = "Eliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 71);
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(68, 68);
            tsbBuscar.Text = "toolStripButton2";
            tsbBuscar.ToolTipText = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 463);
            Controls.Add(bCancelar);
            Controls.Add(pEncabezado);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLibros";
            Text = "ABC Libros";
            Load += frmLibros_Load;
            pEncabezado.ResumeLayout(false);
            pEncabezado.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bCancelar;
        private Panel pEncabezado;
        private ComboBox cbCategoria;
        private TextBox tbExistencias;
        private Label label4;
        private TextBox tbAño;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbNombre;
        private Label lNombre;
        private TextBox tbId;
        private Label lId;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbPrimero;
        private ToolStripButton tsbAnterior;
        private ToolStripButton tsbSiguiente;
        private ToolStripButton tsbUltimo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbNuevo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbEliminar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbBuscar;
        private ComboBox cbAutor;
    }
}