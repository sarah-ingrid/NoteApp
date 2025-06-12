namespace NoteLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            bool loginValido = UserRepository.VerificarLogin(login_box.Text, password_box.Text);
            try
            {
                if (loginValido)
                {
                    var noteApp = new NoteApp();
                    noteApp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou Senha Incorretos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // adicionar: se der erro, os campos escritos serão apagados

                    login_box.Focus();         
                    password_box.Text = "";
                    login_box.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: algo de errado aconteceu" + ex.Message, "ERRO", MessageBoxButtons.OK);
            }
        }

        private void newAccount_button_Click(object sender, EventArgs e)
        {
            var createAccount = new NewAccount();
            createAccount.Show();
            this.Hide();
        }
    }
}
