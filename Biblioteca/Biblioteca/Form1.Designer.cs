namespace Biblioteca
{
    partial class IniciarSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            tbUsuario = new TextBox();
            tbContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(60, 269);
            button1.Name = "button1";
            button1.Size = new Size(87, 64);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(60, 52);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(60, 154);
            label2.Name = "label2";
            label2.Size = new Size(119, 41);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            tbUsuario.BorderStyle = BorderStyle.FixedSingle;
            tbUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsuario.Location = new Point(60, 86);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(300, 30);
            tbUsuario.TabIndex = 3;
            // 
            // tbContraseña
            // 
            tbContraseña.BorderStyle = BorderStyle.FixedSingle;
            tbContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContraseña.Location = new Point(60, 188);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(300, 30);
            tbContraseña.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 606);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 364);
            Controls.Add(tbContraseña);
            Controls.Add(tbUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IniciarSesion";
            Text = "Iniciar Sesion";
            Load += IniciarSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox tbUsuario;
        private TextBox tbContraseña;
        private PictureBox pictureBox1;
    }
}
