using Biblioteca.Base_de_datos;
using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Usuario
{
    public partial class frmLibros : Form
    {
        CLibros miObjeto = CLibros.ultimo();
        bool nuevo = false;
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            EstiloFormulario.Aplicar(this, toolStrip1, pEncabezado, bCancelar, "📚  Libros");
            EstiloFormulario.AplicarComboBoxes(cbAutor, cbCategoria); // ← extra para los combos
            Configuracion();
            Mostrar(miObjeto);
            ActivarHerramientas();
            mostrarTipos();
        }
        #region Metodos de formulario
        void mostrarTipos()
        {
            cbAutor.DataSource = CConexion_BD.Consulta("select id_autor,nombre from Autores");
            cbAutor.DisplayMember = "nombre";
            cbAutor.ValueMember = "id_autor";

            cbCategoria.DataSource = CConexion_BD.Consulta("select id_categoria,nombre from CategoriaLibros");
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "id_categoria";
        }
        void ActivarHerramientas()
        {
            tsbPrimero.Enabled = true;
            tsbAnterior.Enabled = true;
            tsbSiguiente.Enabled = true;
            tsbUltimo.Enabled = true;
            tsbGuardar.Enabled = false;
            if (tbId != null)
                tsbEditar.Enabled = true;
            tsbNuevo.Enabled = true;
            tsbEliminar.Enabled = false;
            tsbBuscar.Enabled = true;

            pEncabezado.Enabled = false;
            bCancelar.Enabled = false;
        }
        void desActivarHerramientas()
        {
            tsbPrimero.Enabled = false;
            tsbAnterior.Enabled = false;
            tsbSiguiente.Enabled = false;
            tsbUltimo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbEditar.Enabled = false;
            tsbNuevo.Enabled = false;
            tsbEliminar.Enabled = true;
            tsbBuscar.Enabled = false;

            pEncabezado.Enabled = true;
            bCancelar.Enabled = true;
        }
        void limpiarCT()
        {
            tbId.Text = "";
            tbNombre.Text = "";
            tbAño.Text = "";
            tbExistencias.Text = "";
        }
        void cargarObjetos(CLibros obj)
        {
            obj.Id = int.Parse(tbId.Text);
            obj.Nombre = tbNombre.Text;
            obj.Autor = CAutores.buscar(cbAutor.SelectedValue.ToString());
            obj.CategoriaLibros = CCategoriaLibros.buscar(cbCategoria.SelectedValue.ToString());
            obj.Año = int.Parse(tbAño.Text);
            obj.Existencias = int.Parse(tbExistencias.Text);
        }
        void Mostrar(CLibros obj)
        {
            if (obj == null)
                return;
            tbId.Text = obj.Id.ToString();
            tbNombre.Text = obj.Nombre;
            cbAutor.SelectedValue = obj.Autor.Id;
            cbCategoria.SelectedValue = obj.CategoriaLibros.Id;
            tbAño.Text = obj.Año.ToString();
            tbExistencias.Text = obj.Existencias.ToString();
        }

        #endregion
        #region toolsbar
        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            miObjeto = CLibros.primero();
            Mostrar(miObjeto);
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            CLibros obj = CLibros.anterior(miObjeto);
            if (obj != null)
            {
                miObjeto = obj;
                Mostrar(miObjeto);
            }
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            CLibros obj = CLibros.siguiente(miObjeto);
            if (obj != null)
            {
                miObjeto = obj;
                Mostrar(miObjeto);
            }
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            miObjeto = CLibros.ultimo();
            Mostrar(miObjeto);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show("Campos Incompletos");
                return;
            }
            CLibros obj = new CLibros();
            cargarObjetos(obj);
            ActivarHerramientas();
            if (nuevo == true)
            {
                if (!CLibros.guardar(obj))
                {
                    MessageBox.Show("No se puede agregar el Libros: Informe a sistemas");
                }
                else
                {
                    miObjeto = obj;
                }
                Mostrar(miObjeto);
            }
            else
            {
                if (CLibros.Modificar(obj))
                {
                    miObjeto = obj;
                }
                Mostrar(miObjeto);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            nuevo = false;
            desActivarHerramientas();
            tbId.Enabled = false;
            tbNombre.Focus();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            desActivarHerramientas();
            limpiarCT();
            CLibros obj = CLibros.ultimo();
            tbId.Text = obj == null ? "1" : Convert.ToString(obj.Id + 1);
            tbNombre.Focus();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de eliminar este registro......?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                if (!CLibros.eliminar(miObjeto))
                {
                    MessageBox.Show("Nose pudo eliminar el registro: Reporte a sistemas");
                }
                else
                {
                    miObjeto = CLibros.siguiente(miObjeto);
                    if (miObjeto == null)
                        miObjeto = CLibros.ultimo();
                    if (miObjeto == null)
                        limpiarCT();
                }
                Mostrar(miObjeto);
                ActivarHerramientas();
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            if (miObjeto == null) return;
            frmBuscador ayuda = new frmBuscador("Buscador de Libros", "id_libro", "nombre", "Libros", " ");
            ayuda.ShowDialog();
            if (ayuda.clave != "")
            {
                miObjeto = CLibros.buscar(ayuda.clave);
                Mostrar(miObjeto);
            }
        }
        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            ActivarHerramientas();
            limpiarCT();
        }

        #endregion
        #region Configuraciones
        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void Configuracion()
        {
            tbNombre.MaxLength = 100;
            tbAño.MaxLength = 10;
            tbExistencias.MaxLength = 10;
        }
        #endregion


       
    }
}
