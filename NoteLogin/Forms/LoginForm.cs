using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.ApplicationServices;

namespace NoteLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            DoubleBuffered = true;

            FormsBorder.EnabbleDrag(this, this);
        }

        private int borderRadiusForm = 20;
        private int borderRadiusControl = 15;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            int userID = UserRepository.VerificarLogin(login_box.Text, password_box.Text);

            try
            {
                if (userID != 0)
                {
                    Sessao.IDUsuarioLogado = userID;
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
            this.Hide();
            createAccount.ShowDialog();
            createAccount.Show();
        }

        // Serve para obrescreve parâmetros para melhorar o desempenho do desenho da interface
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void NoteApp_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void NoteApp_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void NoteApp_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            FormsBorder.SetRegion(enter_button, borderRadiusControl);
            FormsBorder.SetRegion(newAccount_button, borderRadiusControl);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            FormsBorder.SetRegion(this, borderRadiusForm);
            this.Invalidate();
        }


        bool eyePasswordChar = false;
        private void passwordEye_Click(object sender, EventArgs e)
        {
            eyePasswordChar = !eyePasswordChar;

            if (eyePasswordChar)
            {
                passwordEye.Image = Properties.Resources.eye_open;
                password_box.UseSystemPasswordChar = false;
            }
            else
            {
                passwordEye.Image = Properties.Resources.eye_closed;
                password_box.UseSystemPasswordChar = true;
            }

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            FormsBorder.SetRegion(this, borderRadiusForm);
            center_panel.BackColor = Color.FromArgb(100, 0, 0, 0); 

        }
    }
}
