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

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblTaskMessage.Text = value; }
        }

        #endregion
    }
}
