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
    public partial class frmAutores : Form
    {
        CAutores miObjeto = CAutores.ultimo();
        bool nuevo = false;
        public frmAutores()
        {
            InitializeComponent();
        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            EstiloFormulario.Aplicar(this, toolStrip1, pEncabezado, bCancelar, "✎  Autores");
            Configuracion();
            Mostrar(miObjeto);
            ActivarHerramientas();
        }

        #region Metodos de formulario
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
        }
        void cargarObjetos(CAutores obj)
        {
            obj.Id = int.Parse(tbId.Text);
            obj.Nombre = tbNombre.Text;
        }
        void Mostrar(CAutores obj)
        {
            if (obj == null)
                return;
            tbId.Text = obj.Id.ToString();
            tbNombre.Text = obj.Nombre;
        }

        #endregion

        #region toolsbar
        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            miObjeto = CAutores.primero();
            Mostrar(miObjeto);
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            CAutores obj = CAutores.anterior(miObjeto);
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
            CAutores obj = CAutores.siguiente(miObjeto);
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
            miObjeto = CAutores.ultimo();
            Mostrar(miObjeto);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show("Campos Incompletos");
                return;
            }
            CAutores obj = new CAutores();
            cargarObjetos(obj);
            ActivarHerramientas();
            if (nuevo == true)
            {
                if (!CAutores.guardar(obj))
                {
                    MessageBox.Show("No se puede agregar el rol: Informe a sistemas");
                }
                else
                {
                    miObjeto = obj;
                }
                Mostrar(miObjeto);
            }
            else
            {
                if (CAutores.Modificar(obj))
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
            CAutores obj = CAutores.ultimo();
            tbId.Text = obj == null ? "1" : Convert.ToString(obj.Id + 1);
            tbNombre.Focus();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de eliminar este registro......?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                if (!CAutores.eliminar(miObjeto))
                {
                    MessageBox.Show("Nose pudo eliminar el registro: Reporte a sistemas");
                }
                else
                {
                    miObjeto = CAutores.siguiente(miObjeto);
                    if (miObjeto == null)
                        miObjeto = CAutores.ultimo();
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
            frmBuscador ayuda = new frmBuscador("Buscador de Autores", "", " * ", "Autores", " ");
            ayuda.ShowDialog();
            if (ayuda.clave != "")
            {
                miObjeto = CAutores.buscar(ayuda.clave);
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
        public void Configuracion()
        {
            tbNombre.MaxLength = 100;
        }
       
        #endregion
    }
   
}
