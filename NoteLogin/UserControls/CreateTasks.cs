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
    public partial class CreateTasks : UserControl
    {
        public event Action TarefaSalva;
        private int UserID;

        public CreateTasks(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void tbox_tasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Tasks novaTarefa = new Tasks()
                {
                    ID_user = UserID,
                    description = tbox_tasks.Text.Trim(),
                    //    IsCompleted = false,
                    //    IsImportant = false,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                };

                TasksRepository.CriarTarefa(novaTarefa);

                MessageBox.Show("Nota salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbox_tasks.Clear();

                e.SuppressKeyPress = true;
            }

        }
    }
}
