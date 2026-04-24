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
    public partial class frmPrestamos : Form
    {
        CPrestamos miObjeto = CPrestamos.ultimo();
        bool nuevo = false;
       

        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
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
            tbPrestador.Text = "";
            tbSolicitador.Text = "";
            tbLibro.Text = "";

        }
        void cargarObjetos(CPrestamos obj)
        {
            obj.Id = int.Parse(tbId.Text);
            obj.Usuario = CUsuarios.buscarNombre(tbPrestador.Text);
            obj.Cliente = CUsuarios.buscarNombre(tbSolicitador.Text);
            obj.Libro = CLibros.buscarNombre(tbLibro.Text);
            if (chbDevuelto.Checked == true)
                obj.Devuelto = "si";
            else
                obj.Devuelto = "no";
            obj.FechaInicio = DateTime.Now;
            obj.FechaTermino = dtpTermino.Value;
        }
        void Mostrar(CPrestamos obj)
        {
            if (obj == null)
                return;
            tbId.Text = obj.Id.ToString();
            tbSolicitador.Text = obj.Cliente.Nombre;
           
            tbPrestador.Text = obj.Usuario.Nombre;
            
            tbLibro.Text = obj.Libro.Nombre;
            
            dtpTermino.Value = obj.FechaTermino;
        }
        private void bPrestador_Click(object sender, EventArgs e)
        {
            if (miObjeto == null) return;
            frmBuscador ayuda = new frmBuscador("Buscador de Usuario", "id_Usuario", "Nombre", "Usuarios", " ");
            ayuda.ShowDialog();
            if (ayuda.clave != "")
            {
                miObjeto.Usuario = CUsuarios.buscar(ayuda.clave);
                tbPrestador.Text = miObjeto.Usuario.Nombre;
            }
        }
        private void bSolicitador_Click(object sender, EventArgs e)
        {
            if (miObjeto == null) return;
            frmBuscador ayuda = new frmBuscador("Buscador de Cliente", "id_Usuario", "Nombre", "Usuarios", " ");
            ayuda.ShowDialog();
            if (ayuda.clave != "")
            {
                miObjeto.Cliente = CUsuarios.buscar(ayuda.clave);
                tbSolicitador.Text = miObjeto.Cliente.Nombre;
            }
        }
        private void bLibro_Click(object sender, EventArgs e)
        {
            if (miObjeto == null) return;
            frmBuscador ayuda = new frmBuscador("Buscador de Libro", "id_libro", "Nombre", "Libros", " ");
            ayuda.ShowDialog();
            if (ayuda.clave != "")
            {
                miObjeto.Libro = CLibros.buscar(ayuda.clave);
                tbLibro.Text = miObjeto.Libro.Nombre;
            }
        }
        #endregion

        #region toolsbar
        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            miObjeto = CPrestamos.primero();
            Mostrar(miObjeto);
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            CPrestamos obj = CPrestamos.anterior(miObjeto);
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
            CPrestamos obj = CPrestamos.siguiente(miObjeto);
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
            miObjeto = CPrestamos.ultimo();
            Mostrar(miObjeto);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbSolicitador.Text == "" || tbPrestador.Text == "" || tbLibro.Text == "")
            {
                MessageBox.Show("Campos Incompletos");
                return;
            }
            CPrestamos obj = new CPrestamos();
            cargarObjetos(obj);
            ActivarHerramientas();
            if (nuevo == true)
            {
                if (!CPrestamos.guardar(obj))
                {
                    MessageBox.Show("No se puede agregar el prestamo: Informe a sistemas");
                }
                else
                {
                    miObjeto = obj;
                }
                Mostrar(miObjeto);
            }
            else
            {
                if (CPrestamos.Modificar(obj))
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
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            desActivarHerramientas();
            limpiarCT();
            CPrestamos obj = CPrestamos.ultimo();
            tbId.Text = obj == null ? "1" : Convert.ToString(obj.Id + 1);

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de eliminar este registro......?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                if (!CPrestamos.eliminar(miObjeto))
                {
                    MessageBox.Show("Nose pudo eliminar el registro: Reporte a sistemas");
                }
                else
                {
                    miObjeto = CPrestamos.siguiente(miObjeto);
                    if (miObjeto == null)
                        miObjeto = CPrestamos.ultimo();
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
            frmBuscador ayuda = new frmBuscador("Buscador de Prestamos", "id_prestamo", "id_usuario", "Prestamos", " ");
            ayuda.ShowDialog();
            if (ayuda.clave != "")
            {
                miObjeto = CPrestamos.buscar(ayuda.clave);
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
        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void Configuracion()
        {

        }
        #endregion



       
    }
}
