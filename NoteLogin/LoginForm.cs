namespace NoteLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int IDusuario_logado = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            // int loginValido = UserRepository.VerificarLogin(login_box.Text, password_box.Text);
            int userID = UserRepository.VerificarLogin(login_box.Text, password_box.Text);

            try
            {
                if (userID != 0)
                {
                    var noteApp = new NoteApp(userID);
                    this.Hide();
                    noteApp.ShowDialog();
                    this.Show();

                    password_box.Text = "";
                    login_box.Text = "";
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
