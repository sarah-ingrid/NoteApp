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

namespace NoteLogin
{
    public partial class TasksView : UserControl
    {
        public TasksView()
        {
            InitializeComponent();
        }


        private int borderRadius = 15;

        #region Properties
        private String _message;

        private void TasksView_Load(object sender, EventArgs e)
        {
            FormsBorder.SetRegion(this, borderRadius);
        }

        private void checkbox_MouseEnter(object sender, EventArgs e)
        {
            checkbox.Image = Properties.Resources.Checked;
        }

        private void checkbox_MouseLeave(object sender, EventArgs e)
        {
            checkbox.Image = Properties.Resources.Unchecked;
        }





        private void checkbox_Click(object sender, EventArgs e)
        {
          //  int newStatus;
            isChecked = !isChecked;
            checkbox.Image = isChecked ? Properties.Resources.Checked : Properties.Resources.Unchecked;


            using (var conexao = DataBase.ConexaoBanco())
            {
                string UpdateQuery = "UPDATE tb_tasks SET IsCompleted = @status WHERE ID_tasks = @id";

                using (var comando = new SQLiteCommand(UpdateQuery, conexao))
                {
                    comando.Parameters.AddWithValue("@status", isChecked ? 1 : 0);
                    comando.Parameters.AddWithValue("@id", IDTasks);

                    comando.ExecuteNonQuery();
                }
            }
        }


        private bool isChecked;
        private int IDTasks;
        public void SetTaskData(int id, string descricao, bool isCompleted)
        {
            IDTasks = id;
            lblTaskMessage.Text = descricao;
            isChecked = isCompleted;
            checkbox.Image = isCompleted ? Properties.Resources.Checked : Properties.Resources.Unchecked;
            checkbox.Image = isChecked ? Properties.Resources.Checked : Properties.Resources.Unchecked;
        }



        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblTaskMessage.Text = value; }
        }

        #endregion
    }
}
