namespace Biblioteca.Usuario
{
    partial class frmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            bCancelar = new Button();
            pEncabezado = new Panel();
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
            bCancelar.Location = new Point(656, 268);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(76, 69);
            bCancelar.TabIndex = 5;
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click_1;
            // 
            // pEncabezado
            // 
            pEncabezado.Controls.Add(tbNombre);
            pEncabezado.Controls.Add(lNombre);
            pEncabezado.Controls.Add(tbId);
            pEncabezado.Controls.Add(lId);
            pEncabezado.Location = new Point(12, 83);
            pEncabezado.Name = "pEncabezado";
            pEncabezado.Size = new Size(720, 163);
            pEncabezado.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(173, 91);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(488, 34);
            tbNombre.TabIndex = 3;
            // 
            // lNombre
            // 
            lNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombre.Location = new Point(12, 91);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(155, 28);
            lNombre.TabIndex = 2;
            lNombre.Text = "Nombre:";
            lNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(173, 35);
            tbId.Name = "tbId";
            tbId.Size = new Size(142, 34);
            tbId.TabIndex = 1;
            // 
            // lId
            // 
            lId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lId.Location = new Point(82, 35);
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
            toolStrip1.Size = new Size(763, 71);
            toolStrip1.TabIndex = 3;
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
            // frmRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 359);
            Controls.Add(bCancelar);
            Controls.Add(pEncabezado);
            Controls.Add(toolStrip1);
            Name = "frmRoles";
            Text = "ABC Roles";
            Load += frmRoles_Load;
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
    }
}