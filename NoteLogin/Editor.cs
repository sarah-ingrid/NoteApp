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
    public partial class Editor : UserControl
    {

        public Editor()
        {
            InitializeComponent();

            this.UserID = Sessao.IDUsuarioLogado;
        }

        public int UserID;
        public int IDNote { get; set; }
        public NoteApp noteApp { get; set; }
        public event Action NotaSalva;






        private bool isTrash;
        private void pictureBox_trash_Click(object sender, EventArgs e)
        {

            try
            {
                if (!isTrash && MessageBox.Show("Deseja realmente excluir a nota?", "EXCLUIR NOTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var panel = this.Parent;
                    panel.Controls.Remove(this);
                    this.Dispose();

                    DataBase trash = new DataBase();
                    trash.TrashforDelete("tb_notes", IDNote);

                    if (panel.Controls.Count == 0)
                        panel.Visible = false;

                    MessageBox.Show("Nota deletada\nAtualize a página");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO EXCLUIR UMA NOTA" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        bool isBold;
        private void bold_option_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold);
        }

        private void italic_option_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }

        private void underline_option_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline);
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            string notaTitulo = title_box.Text;
            string nota = richTextBox.Rtf;

            try
            {
                if (string.IsNullOrWhiteSpace(notaTitulo))
                    notaTitulo = "Sem Título";


                if (string.IsNullOrEmpty(nota))
                {
                    MessageBox.Show("Nota não pode ser vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Note novaNota = new Note()
                    {
                        ID_user = UserID,
                        ID_note = noteApp.CurrentIDNote,
                        Title = notaTitulo,
                        Text = nota,
                        IsImportant = 0,
                        UpdateAt = DateTime.Now
                    };

                    if (noteApp.CurrentIDNote != -1)
                    {

                        NoteRepository.AtualizarNota(novaNota);
                        MessageBox.Show("Nota salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        novaNota.CreateAt = DateTime.Now;
                        NoteRepository.CriarNota(novaNota);
                        NotaSalva?.Invoke();

                        MessageBox.Show("Nota salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        noteApp.CurrentIDNote = novaNota.ID_note;

                        //  title_box.Clear();
                        // richTextBox.Clear();

                        closeButton_Click(sender, e);
                    }

                    if (noteApp != null)
                    {
                        // noteApp.AtualizarListaDeNotas(); // Chame seu método para recarregar os itens no Panel_Principal

                        noteApp.CurrentIDNote = -1;
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a nota" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //// ESTRELA //////////////////////////////
        public void UpdateStarImage()
        {
            pictureBox_star.Image = Important
                ? Properties.Resources.star_full
                : Properties.Resources.star_empty;
        }

        public bool Important { get; set; }
        private bool IsInImportantSession { get; set; }

        private void pictureBox_star_Click(object sender, EventArgs e)
        {
            Important = !Important;
            // trocando as imagens
            UpdateStarImage();

            using var conexao = DataBase.ConexaoBanco();
            {
                string UpdateQuery = "UPDATE tb_notes SET IsImportant = @important WHERE ID_note = @id;";

                using (var comando = new SQLiteCommand(UpdateQuery, conexao))
                {
                    comando.Parameters.AddWithValue("@id", IDNote);
                    comando.Parameters.AddWithValue("@important", Important ? 1 : 0); // sql entende que 1 é importante e 0 não é importante

                    comando.ExecuteNonQuery();
                }
            }

            if (IsInImportantSession && !Important)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            // this.Parent.Controls.Remove(this);
            // noteApp.panel_editor.Visible = false;
        }


        private void ChangeFontStyle(FontStyle styleToToggle)
        {
            var currentFont = richTextBox.SelectionFont;
            if (currentFont == null) return;

            FontStyle newStyle;

            if (currentFont.Style.HasFlag(styleToToggle))
                newStyle = currentFont.Style & ~styleToToggle;
            else
                newStyle = currentFont.Style | styleToToggle;

            richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
        }


        #region Properties
        private String _title;
        private String _message;

        private void fontStyle_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = font.Font;
            }
        }

        private void fontSizeIncrease_Click(object sender, EventArgs e)
        {
            var font = richTextBox.SelectionFont;
            if (font == null) return;

            float newSize = font.Size + 2;

            richTextBox.SelectionFont = new Font(font.FontFamily, newSize, font.Style);
        }

        private void fontSizeDecrease_Click(object sender, EventArgs e)
        {
            var font = richTextBox.SelectionFont;
            if (font == null) return;

            float newSize = font.Size - 2;

            richTextBox.SelectionFont = new Font(font.FontFamily, newSize, font.Style);
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo)
                richTextBox.Undo();
        }

        private void fontColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void fontBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionBackColor = colorDialog.Color;
                }
            }
        }



        [Category("Custom Props for Editor")]
        public string Title
        {
            get { return _title; }
            set { _title = value; title_box.Text = value; }
        }

        [Category("Custom Props for Editor")]
        public string Message
        {
            get { return _message; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.TrimStart().StartsWith("{\\rtf"))
                    {
                        richTextBox.Rtf = value;
                    }
                    else
                    {
                        richTextBox.Text = value;
                    }
                }
                else
                {
                    richTextBox.Clear();
                }
            }
        }

        #endregion

    }
}
