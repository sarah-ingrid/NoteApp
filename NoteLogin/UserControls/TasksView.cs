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

        #region Properties
        private String _message;

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblTaskMessage.Text = value; }
        }

        #endregion
    }
}
