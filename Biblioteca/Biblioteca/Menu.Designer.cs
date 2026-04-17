namespace Biblioteca
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            articulosToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            prestamosToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { articulosToolStripMenuItem, empleadosToolStripMenuItem, clientesToolStripMenuItem, prestamosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1001, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            articulosToolStripMenuItem.Size = new Size(89, 24);
            articulosToolStripMenuItem.Text = "Inventario";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(97, 24);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(91, 24);
            prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1001, 565);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 593);
            Controls.Add(pictureBox2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem articulosToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem prestamosToolStripMenuItem;
        private PictureBox pictureBox2;
    }
}