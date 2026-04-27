using Biblioteca.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ConfigurarMenuEstilizado();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        #region metodos de formulario
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Roles", "id_rol", "Nombre", "Roles", "WHERE id_rol IN ( SELECT TOP 10 id_rol FROM Roles ORDER BY id_rol DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmRoles f = new frmRoles();
                f.ShowDialog();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Usuarios", "id_usuario", "nombre", "Usuarios", "WHERE id_usuario IN ( SELECT TOP 10 id_usuario FROM Usuarios ORDER BY id_usuario DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmUsuarios f = new frmUsuarios();
                f.ShowDialog();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Categoria de libros", "id_categoria", "nombre", "CategoriaLibros", "WHERE id_categoria IN ( SELECT TOP 10 id_categoria FROM CategoriaLibros ORDER BY id_categoria DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmCategoriaLibros f = new frmCategoriaLibros();
                f.ShowDialog();
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Autores", "id_autor", "nombre", "Autores", "WHERE id_autor IN ( SELECT TOP 10 id_autor FROM Autores ORDER BY id_autor DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmAutores f = new frmAutores();
                f.ShowDialog();
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda("Vista de Libros", "id_libro", "nombre", "Libros", "WHERE id_libro IN ( SELECT TOP 10 id_libro FROM Libros ORDER BY id_libro DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmLibros f = new frmLibros();
                f.ShowDialog();
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyudaPrestamos ayuda = new frmAyudaPrestamos("Vista de¨Prestamos", "id_Prestamo", "id_libro", "Prestamos", "WHERE id_prestamo IN ( SELECT TOP 10 id_prestamo FROM Libros ORDER BY id_prestamo DESC)");
            ayuda.ShowDialog();
            if (ayuda.seleccion == "si")
            {
                frmPrestamos f = new frmPrestamos();
                f.ShowDialog();
            }
        }
        #endregion

        #region configuracion
        private void ConfigurarMenuEstilizado()
        {
            // === ESTILO DEL MENUSTRIP ===
            menuStrip1.BackColor = ColorTranslator.FromHtml("#0F7A52");
            menuStrip1.ForeColor = ColorTranslator.FromHtml("#D4F5E8");
            menuStrip1.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Renderer = new MenuVerdeRenderer();

            // === INVENTARIO ===
            ToolStripMenuItem menuInventario = new ToolStripMenuItem("📦  Inventario");

            ToolStripMenuItem subLibros = new ToolStripMenuItem("📚  Libros");
            ToolStripMenuItem subAutores = new ToolStripMenuItem("✍   Autores");
            ToolStripMenuItem subCategoria = new ToolStripMenuItem("🏷   Categoría de libros");

            // Conectar TUS eventos existentes
            subLibros.Click += librosToolStripMenuItem_Click;
            subAutores.Click += autoresToolStripMenuItem_Click;
            subCategoria.Click += categoriasToolStripMenuItem_Click;

            menuInventario.DropDownItems.AddRange(new ToolStripItem[]
                { subLibros, subAutores, subCategoria });

            // === USUARIOS ===
            ToolStripMenuItem menuUsuarios = new ToolStripMenuItem("👥  Usuarios");

            ToolStripMenuItem subUsuarios = new ToolStripMenuItem("👤  Usuarios");
            ToolStripMenuItem subRoles = new ToolStripMenuItem("🔑  Roles");

            subUsuarios.Click += usuariosToolStripMenuItem_Click;
            subRoles.Click += rolesToolStripMenuItem_Click;

            menuUsuarios.DropDownItems.AddRange(new ToolStripItem[]
                { subUsuarios, subRoles });

            // === PRÉSTAMOS (botón directo) ===
            ToolStripMenuItem menuPrestamos = new ToolStripMenuItem("▶  Préstamos");
            menuPrestamos.Click += prestamosToolStripMenuItem_Click;

            // === LIMPIAR Y RECONSTRUIR EL MENUSTRIP ===
            menuStrip1.Items.Clear();
            menuStrip1.Items.Add(menuInventario);
            menuStrip1.Items.Add(new ToolStripSeparator());
            menuStrip1.Items.Add(menuUsuarios);
            menuStrip1.Items.Add(new ToolStripSeparator());
            menuStrip1.Items.Add(menuPrestamos);
        }

        #endregion
    }
    #region Metodos extras
    public class MenuVerdeRenderer : ToolStripProfessionalRenderer
    {
        Color bgMenu = ColorTranslator.FromHtml("#0F7A52");
        Color bgHover = ColorTranslator.FromHtml("#1DAA70");
        Color bgDropdown = Color.White;
        Color bgDropHover = ColorTranslator.FromHtml("#E8F8F2");
        Color bordeColor = ColorTranslator.FromHtml("#A8E8CC");
        Color textoMenu = ColorTranslator.FromHtml("#D4F5E8");
        Color textoSub = ColorTranslator.FromHtml("#1A5C3A");

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var item = e.Item;
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (item.IsOnDropDown)
            {
                Color bg = item.Selected ? bgDropHover : bgDropdown;
                g.FillRectangle(new SolidBrush(bg), e.Item.ContentRectangle);
            }
            else
            {
                if (item.Selected || item.Pressed)
                {
                    using var path = RoundedRect(e.Item.ContentRectangle, 5);
                    g.FillPath(new SolidBrush(bgHover), path);
                }
            }
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(bgMenu), e.AffectedBounds);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDown)
            {
                using var pen = new Pen(bordeColor, 1f);
                var r = e.AffectedBounds;
                r.Width--; r.Height--;
                e.Graphics.DrawRectangle(pen, r);
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            if (!e.Item.IsOnDropDown)
            {
                int x = e.Item.Width / 2;
                using var pen = new Pen(Color.FromArgb(60, 255, 255, 255), 1);
                e.Graphics.DrawLine(pen, x, 4, x, e.Item.Height - 4);
            }
            else base.OnRenderSeparator(e);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = e.Item.IsOnDropDown ? textoSub : textoMenu;
            base.OnRenderItemText(e);
        }

        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(r.X, r.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(r.Right - radius * 2, r.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(r.Right - radius * 2, r.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(r.X, r.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
    #endregion
}

