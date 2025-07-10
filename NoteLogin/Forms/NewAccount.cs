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

        private int borderRadiusForm = 20;
        private int borderRadiusControl = 15;
        private float borderSizeForm = 0;
        private Color borderColorForm = Color.FromArgb(255, 255, 255);


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
                        foreach (Control c in panel1.Controls)
                        {
                            if (c is TextBox)
                                ((TextBox)c).Clear();
                        }

                        box_gender.SelectedIndex = -1;
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
            user_login.BackColor = Color.LightGray;
        }

        private void user_login_Leave(object sender, EventArgs e)
        {
            user_login.BackColor = Color.White;
        }

        private void back_login_Click(object sender, EventArgs e)
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



        private void NewAccount_Load(object sender, EventArgs e)
        {

            FormsBorder.SetRegion(this, borderRadiusForm);
            FormsBorder.SetRegion(registerButton, borderRadiusControl);

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            panel1.Invalidate();
        }

        private void NewAccount_Resize(object sender, EventArgs e)
        {

            FormsBorder.SetRegion(this, borderRadiusForm);
            this.Invalidate();
        }

        private void NewAccount_Paint(object sender, PaintEventArgs e)
        {
            FormsBorder.DrawBorder(this, borderRadiusForm, e.Graphics, borderColorForm, borderSizeForm);
        }

        bool eyePasswordChar = false;
        private void passwordEye_Click(object sender, EventArgs e)
        {
            eyePasswordChar = !eyePasswordChar;

            if (eyePasswordChar)
            {
                passwordEye.Image = Properties.Resources.eye_open;
                user_senha.UseSystemPasswordChar = false;
            }
            else
            {
                passwordEye.Image = Properties.Resources.eye_closed;
                user_senha.UseSystemPasswordChar = true;
            }

        }
    }
}
