using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace NoteLogin
{
    public partial class CreateNote : UserControl
    {
        public event Action NotaSalva;//
        private int UserID;
        public CreateNote(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID; 
        }



        private void saveNote_button_Click(object sender, EventArgs e)
        {
            string notaTitulo = noteTitleText.Text;
            string nota = NoteText_richTbox.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(notaTitulo))
                    notaTitulo = "Sem Título";
                

                if (string.IsNullOrEmpty(nota))
                {
                    MessageBox.Show("Nota não pode ser vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else {
                    Note novaNota = new Note()
                    {
                        ID_user = UserID,
                        Title = notaTitulo,
                        Text = nota,
                        IsImportant = 0, //
                        CreateAt = DateTime.Now,
                        UpdateAt = DateTime.Now
                    };

                    NoteRepository.CriarNota(novaNota);

                    MessageBox.Show("Nota salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    noteTitleText.Clear();
                    NoteText_richTbox.Clear();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a nota" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void closeX_Click(object sender, EventArgs e)
        {
            NotaSalva?.Invoke(); // invocando o evento
        }
    }
}
