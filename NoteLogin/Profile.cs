using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace NoteLogin
{

    public partial class Profile : Form
    {
        NoteApp principal;
        private int UserID;

        public Profile(int UserID, NoteApp formPrincipal)
        {
            InitializeComponent();

            this.UserID = UserID;
            principal = formPrincipal;
        }

        string picture = "";

        private void Profile_Load(object sender, EventArgs e)
        {
            panel_newPasswrd.SendToBack();



            string nome = "";
            string username = "";
            string email = "";

            using (var conexao = DataBase.ConexaoBanco())
            {
                string query = "SELECT T_username, T_NOME, T_EMAIL, FOTO_PERFIL FROM tb_users WHERE User_ID = @UserDI";

                using var comando = new SQLiteCommand(query, conexao);
                {
                    comando.Parameters.AddWithValue("@UserDI", UserID);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = reader.GetString(0);
                            label_login.Text = username;

                            nome = reader.GetString(1);
                            textBox_name.Text = nome;

                            email = reader.GetString(2);
                            textBox_email.Text = email;

                            if (!reader.IsDBNull(3))
                            {
                                try
                                {
                                    picture = reader.GetString(3);

                                    if (!string.IsNullOrEmpty(picture) && File.Exists(picture)) 
                                    { 

                                        profilePicture.Image?.Dispose();

                                    // Cria uma cópia para não travar o arquivo original
                                    using var tempImage = Image.FromFile(picture);
                                    profilePicture.Image = new Bitmap(tempImage);
                                    }
                                    else
                                    {
                                        profilePicture.Image?.Dispose();
                                        profilePicture.Image = Properties.Resources.default_picture_profile;
                                    }

                                }
                                catch (OutOfMemoryException)
                                {
                                    MessageBox.Show("Erro: O arquivo selecionado não é uma imagem válida.");
                                    profilePicture.Image = Properties.Resources.default_picture_profile;
                                }
                            }
                            else
                                profilePicture.Image = Properties.Resources.default_picture_profile;
                            
                        }
                    }
                }
            }
        }




        private void change_passwrd_Click(object sender, EventArgs e)
        {
            panel_newPasswrd.BringToFront();
        }


        private void change_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();

            try
            {
                if (photo.ShowDialog() == DialogResult.OK)
                {
                    string caminho = photo.FileName;

                    using (var conexao = DataBase.ConexaoBanco())
                    {
                        string query = "UPDATE tb_users SET FOTO_PERFIL = @caminho WHERE User_ID = @userId";
                        using (var comando = new SQLiteCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@caminho", caminho);
                            comando.Parameters.AddWithValue("@userId", UserID);
                            comando.ExecuteNonQuery();

                            profilePicture.Image = Image.FromFile(caminho);
                            principal.profilepicture.Image = Image.FromFile(caminho);
                        }
                    }
                }
            }
            catch (Exception ex) { 
                 MessageBox.Show("Erro ao alterar foto de perfil: " + ex.Message);
            } 
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string senhaAntiga = senhaAtual.Text;
            string senhaNova = novaSenha.Text;
            string accountPassword = "";

            try
            {
                using (var conexao = DataBase.ConexaoBanco())
                {
                    // 1º
                    string readQuery = "SELECT T_SENHA FROM tb_users WHERE User_ID = @userId";
                    using (var comandoSelect = new SQLiteCommand(readQuery, conexao))
                    {
                        comandoSelect.Parameters.AddWithValue("@userId", UserID);
                        using (var reader = comandoSelect.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                accountPassword = reader.GetString(0);
                            }
                        }
                    }
                    // 2º
                    if (accountPassword == senhaAntiga)
                    {
                        string updateQuery = "UPDATE tb_users SET T_SENHA = @novaSenha WHERE User_ID = @userId";

                        using (var comandoUpdate = new SQLiteCommand(updateQuery, conexao))
                        {
                            comandoUpdate.Parameters.AddWithValue("@novaSenha", senhaNova);
                            comandoUpdate.Parameters.AddWithValue("@userId", UserID);
                            comandoUpdate.ExecuteNonQuery();
                        }

                        MessageBox.Show("SENHA NOVA SALVA COM SUCESSO", "", MessageBoxButtons.OK);
                        panel_newPasswrd.SendToBack();
                    }
                    else
                    {
                        MessageBox.Show("Digite novamente", "SENHA ATUAL INCORRETA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA PARTE DE ALTERAÇÃO DE SENHA", ex.Message);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            panel_newPasswrd.SendToBack();
        }
    }
}

