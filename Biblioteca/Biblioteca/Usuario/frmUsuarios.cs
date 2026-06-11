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
    public partial class frmUsuarios : Form
    {
        CUsuarios miObjeto = CUsuarios.ultimo();
        bool nuevo = false;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            EstiloFormulario.Aplicar(this, toolStrip1, pEncabezado, bCancelar, "👤  Usuarios");
            EstiloFormulario.AplicarComboBoxes(cbRol);
            Configuracion();
            Mostrar(miObjeto);
            ActivarHerramientas();
            mostrarTipos();
        }

        #region Metodos de formulario
        void mostrarTipos()
        {
            cbRol.DataSource = CConexion_BD.Consulta("select id_rol,nombre from Roles");
            cbRol.DisplayMember = "nombre";
            cbRol.ValueMember = "id_rol";
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
            tbClave.Text = "";
            tbCorreo.Text = "";
            tbTelefono.Text = "";
        }
        void cargarObjetos(CUsuarios obj)
        {
            obj.Id = int.Parse(tbId.Text);
            obj.Nombre = tbNombre.Text;
            obj.Clave = tbClave.Text;
            obj.Rol = CRoles.buscar(cbRol.SelectedValue.ToString());
            obj.Correo = tbCorreo.Text;
            obj.Telefono = tbTelefono.Text;
        }
        void Mostrar(CUsuarios obj)
        {
            if (obj == null)
                return;
            tbId.Text = obj.Id.ToString();
            tbNombre.Text = obj.Nombre;
            tbClave.Text = obj.Clave;
            cbRol.SelectedValue = obj.Rol.Id;
            tbCorreo.Text = obj.Correo;
            tbTelefono.Text = obj.Telefono;
        }

        #endregion
        #region toolsbar
        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            miObjeto = CUsuarios.primero();
            Mostrar(miObjeto);
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (miObjeto == null)
                return;
            CUsuarios obj = CUsuarios.anterior(miObjeto);
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
            CUsuarios obj = CUsuarios.siguiente(miObjeto);
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
            miObjeto = CUsuarios.ultimo();
            Mostrar(miObjeto);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show("Campos Incompletos");
                return;
            }
            CUsuarios obj = new CUsuarios();
            cargarObjetos(obj);
            ActivarHerramientas();
            if (nuevo == true)
            {
                if (!CUsuarios.guardar(obj))
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
                if (CUsuarios.Modificar(obj))
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
            CUsuarios obj = CUsuarios.ultimo();
            tbId.Text = obj == null ? "1" : Convert.ToString(obj.Id + 1);
            tbNombre.Focus();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de eliminar este registro......?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                if (!CUsuarios.eliminar(miObjeto))
                {
                    MessageBox.Show("Nose pudo eliminar el registro: Reporte a sistemas");
                }
                else
                {
                    miObjeto = CUsuarios.siguiente(miObjeto);
                    if (miObjeto == null)
                        miObjeto = CUsuarios.ultimo();
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
            frmBuscador ayuda = new frmBuscador("Buscador de Usuarios", " U.id_usuario,U.nombre,U.clave,R.nombre AS [Rol],U.correo,U.telefono", " ", "Usuarios", " U JOIN Roles R ON U.id_rol = R.id_rol;");
            ayuda.ShowDialog();
            if (ayuda.clave != "")
            {
                miObjeto = CUsuarios.buscar(ayuda.clave);
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
            tbTelefono.MaxLength = 10;
            tbNombre.MaxLength = 100;
            tbClave.MaxLength = 100;
            tbCorreo.MaxLength = 100;
        }
        #endregion


    }
}
