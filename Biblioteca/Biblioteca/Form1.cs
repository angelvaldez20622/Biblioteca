using Biblioteca.Clases;

namespace Biblioteca
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUsuarios U = CUsuarios.buscarNombre(tbUsuario.Text);
            if (U == null)
            {
                MessageBox.Show("usuario inexistente");
                tbUsuario.Clear();
                tbUsuario.Focus();
                return;
            }
            if (tbContraseña.Text == "")
            {
                MessageBox.Show("inserte contraseña");
                tbContraseña.Focus();
                return;
            }
            if (U.Clave == tbContraseña.Text)
            {
                Menu f = new Menu();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                tbContraseña.Clear();
                tbContraseña.Focus();
                return;
            }
        }

        private void IniciarSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button1_Click(sender, e);
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbContraseña.Focus();
        }

        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
