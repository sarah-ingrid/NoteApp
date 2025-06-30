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

        private int borderRadius = 20;
        private int borderSize = 0;
        private Color borderColor = Color.FromArgb(255, 255, 255);

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
                cp.Style |= 0x20000;
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

             using (Graphics g = this.CreateGraphics())
             {                                                      // Region true = define a região arredondada, não desenha borda 
                 FormsBorder.FormRegionAndBorder(this, borderRadius, g, borderColor, borderSize, setRegionOnly: true);
             }

            center_panel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            // o tamanho mudou, o formato arredondado precisa ser recalculado
            using (Graphics g = this.CreateGraphics())
            {
                FormsBorder.FormRegionAndBorder(this, borderRadius, g, borderColor, borderSize, setRegionOnly: true);
            }
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {                                                              // Region false = desenha a borda arredondada no form
           // FormsBorder.FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize, setRegionOnly: false);
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
           // center_panel.Visible = true;
        }
    }
}
