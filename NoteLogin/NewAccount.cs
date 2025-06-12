using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

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
                        loginForm.Show();
                        this.Hide();
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
            telaLogin.Show();
            this.Close();
        }
    }
}
