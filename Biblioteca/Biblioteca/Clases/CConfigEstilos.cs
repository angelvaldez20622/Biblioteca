using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Clases
{
    public class CConfigEstilos
    {
    }
    public class ToolStripVerdeRenderer : ToolStripProfessionalRenderer
    {
        Color bgHover = ColorTranslator.FromHtml("#1DAA70");
        Color bgPress = ColorTranslator.FromHtml("#0A5C3C");

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(
                new SolidBrush(ColorTranslator.FromHtml("#0F7A52")),
                e.AffectedBounds);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var btn = e.Item as ToolStripButton;
            if (btn == null) { base.OnRenderButtonBackground(e); return; }

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var r = new Rectangle(2, 2, btn.Width - 4, btn.Height - 4);

            if (!btn.Enabled)
                g.FillRectangle(new SolidBrush(Color.FromArgb(40, 0, 0, 0)), r);
            else if (btn.Pressed)
                g.FillRectangle(new SolidBrush(bgPress), r);
            else if (btn.Selected)
            {
                g.FillRectangle(new SolidBrush(bgHover), r);
                using var pen = new Pen(Color.FromArgb(80, 255, 255, 255), 1);
                g.DrawRectangle(pen, r);
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            int x = e.Item.Width / 2;
            using var pen = new Pen(Color.FromArgb(60, 255, 255, 255), 1);
            e.Graphics.DrawLine(pen, x, 6, x, e.Item.Height - 6);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
    }
    
    public static class EstiloFormulario
        {
            public static void Aplicar(Form form, ToolStrip toolStrip,
                Panel pEncabezado, Button bCancelar, string titulo)
            {
                Color verdeOscuro = ColorTranslator.FromHtml("#0F7A52");
                Color verdeMedio = ColorTranslator.FromHtml("#158F61");
                Color verdeClaro = ColorTranslator.FromHtml("#EAF9F2");
                Color verdeTexto = ColorTranslator.FromHtml("#1A5C3A");
                Color verdeLabel = ColorTranslator.FromHtml("#B2F0DC");
                Color bordeColor = ColorTranslator.FromHtml("#A8E8CC");

                // Formulario
                form.BackColor = verdeClaro;
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.MaximizeBox = false;

                // ToolStrip
                toolStrip.BackColor = verdeOscuro;
                toolStrip.GripStyle = ToolStripGripStyle.Hidden;
                toolStrip.Padding = new Padding(8, 4, 8, 4);
                toolStrip.RenderMode = ToolStripRenderMode.Professional;
                toolStrip.Renderer = new ToolStripVerdeRenderer();

                // Panel título
                Panel panelTitulo = new Panel();
                panelTitulo.BackColor = verdeMedio;
                panelTitulo.Size = new Size(form.ClientSize.Width, 42);
                panelTitulo.Location = new Point(0, toolStrip.Height);
                form.Controls.Add(panelTitulo);
                panelTitulo.BringToFront();

                Label lblTitulo = new Label();
                lblTitulo.Text = titulo;
                lblTitulo.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                lblTitulo.ForeColor = Color.White;
                lblTitulo.AutoSize = true;
                lblTitulo.Location = new Point(16, 8);
                panelTitulo.Controls.Add(lblTitulo);

                // Panel encabezado
                pEncabezado.Location = new Point(12, toolStrip.Height + panelTitulo.Height + 16);
                pEncabezado.BackColor = Color.White;
                pEncabezado.Width = form.ClientSize.Width - 24;
                pEncabezado.Paint += (s, e) =>
                {
                    using var pen = new Pen(bordeColor, 1.5f);
                    e.Graphics.DrawRectangle(pen, 0, 0,
                        pEncabezado.Width - 1, pEncabezado.Height - 1);
                };

                // Labels y TextBoxes dentro del panel
                foreach (Control c in pEncabezado.Controls)
                {
                    if (c is Label lbl)
                    {
                        lbl.BackColor = verdeLabel;
                        lbl.ForeColor = verdeTexto;
                        lbl.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
                    }
                    if (c is TextBox tb)
                    {
                        tb.BackColor = Color.White;
                        tb.ForeColor = verdeTexto;
                        tb.Font = new Font("Segoe UI", 11f);
                        tb.BorderStyle = BorderStyle.FixedSingle;
                    }
                }

                // Panel inferior con botón cancelar
                Panel panelBot = new Panel();
                panelBot.BackColor = ColorTranslator.FromHtml("#D4F5E8");
                panelBot.Dock = DockStyle.Bottom;
                panelBot.Height = 90;
                form.Controls.Add(panelBot);
                panelBot.BringToFront();

                bCancelar.Parent = panelBot;
                bCancelar.FlatStyle = FlatStyle.Flat;
                bCancelar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C0392B");
                bCancelar.FlatAppearance.BorderSize = 2;
                bCancelar.BackColor = Color.White;
                bCancelar.Cursor = Cursors.Hand;
                bCancelar.Size = new Size(76, 69);
                bCancelar.Location = new Point(panelBot.Width - 92, 10);
                bCancelar.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            }
        public static void AplicarComboBoxes(params ComboBox[] combos)
        {
            Color verdeTexto = ColorTranslator.FromHtml("#1A5C3A");
            Color verdeLabel = ColorTranslator.FromHtml("#B2F0DC");

            foreach (var cb in combos)
            {
                cb.Font = new Font("Segoe UI", 11f);
                cb.BackColor = Color.White;
                cb.ForeColor = verdeTexto;
                cb.FlatStyle = FlatStyle.Flat;
            }
        }
        public static void AplicarBotonesBusqueda(params Button[] botones)
        {
            Color verdeOscuro = ColorTranslator.FromHtml("#0F7A52");

            foreach (var b in botones)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = verdeOscuro;
                b.FlatAppearance.BorderSize = 1;
                b.BackColor = ColorTranslator.FromHtml("#D4F5E8");
                b.Cursor = Cursors.Hand;
            }
        }

        public static void AplicarCheckBox(CheckBox chk)
        {
            Color verdeTexto = ColorTranslator.FromHtml("#1A5C3A");
            chk.ForeColor = verdeTexto;
            chk.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            chk.BackColor = Color.Transparent;
        }
    }
}
    
