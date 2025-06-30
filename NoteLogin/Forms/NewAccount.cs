using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteLogin
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {

            InitializeComponent();

            DoubleBuffered = true;

            FormsBorder.EnabbleDrag(this, this);
        }

        private int borderRadius = 20;
        private int borderSize = 0;
        private Color borderColor = Color.FromArgb(255, 255, 255);


        private string ObterGeneroSelecionado()
        {
            string genero = "";

            if (box_gender.SelectedItem != null)
            {
                switch (box_gender.SelectedItem.ToString())
                {
                    case "Feminino":
                        genero = "F";
                        break;
                    case "Masculino":
                        genero = "M";
                        break;
                    default:
                        genero = "O";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selecione um gênero", "", MessageBoxButtons.OK);
                return "";
            }
            return genero;
        }
        ////////////////////////////

        private void registerButton_Click(object sender, EventArgs e)
        {
            string C_name = user_name.Text;
            string C_login = user_login.Text;
            string C_senha = user_senha.Text;
            string C_email = user_email.Text;
            string C_genero = ObterGeneroSelecionado();

            try
            {
                bool sucesso = UserRepository.CadastrarUsuario(C_name, C_login, C_email, C_senha, C_genero);

                if (sucesso)
                {
                    DialogResult opcao = MessageBox.Show("USUÁRIO CADASTRADO COM SUCESSO!\n\tDeseja fazer login?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (opcao == DialogResult.Yes)
                    {
                        var loginForm = new LoginForm();
                        this.Hide();
                        loginForm.ShowDialog();
                        loginForm.Show();

                    }
                    else
                    {
                        this.Close();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário\nVerifique se está tudo preenchido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void user_login_Enter(object sender, EventArgs e)
        {
            //user_login.Text = "";
            user_login.BackColor = Color.LightGray;
        }

        private void user_login_Leave(object sender, EventArgs e)
        {
            user_login.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e) // voltar para tela de login
        {
            LoginForm telaLogin = new();

            this.Hide();
            telaLogin.ShowDialog();
            telaLogin.Show();
            this.Close();
        }

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



        private void NewAccount_Load(object sender, EventArgs e)
        {

             using (Graphics g = this.CreateGraphics())
             {
                 FormsBorder.FormRegionAndBorder(this, borderRadius, g, borderColor, borderSize, setRegionOnly: true);
             }
             panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void NewAccount_Resize(object sender, EventArgs e)
        {

          /*  using (Graphics g = this.CreateGraphics())
            {
                FormsBorder.FormRegionAndBorder(this, borderRadius, g, borderColor, borderSize, setRegionOnly: true);
            }*/
        }

        private void NewAccount_Paint(object sender, PaintEventArgs e)
        {
           // FormsBorder.FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize, setRegionOnly: false);
        }

        private void NewAccount_Shown(object sender, EventArgs e)
        {
           // panel1.Visible = true;
        }
    }
}
