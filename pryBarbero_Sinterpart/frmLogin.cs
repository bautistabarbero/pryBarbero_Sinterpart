namespace pryBarbero_Sinterpart
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            //Borra los elementos de la lista 
            //cmbModulo.Items.Clear();

            cmbModulo.SelectedIndex = -1;
        }

        private void lblSinterpart_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Modal significa que si no se cierra la otra ventana no se puede continuar
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
