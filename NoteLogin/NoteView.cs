using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteLogin
{
    public partial class NoteView : UserControl
    {
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(127, 255, 212);

        public NoteView()
        {
            InitializeComponent();

          //  this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
           //    this.panelTitleBar.BackColor = borderColor;
          //  this.BackColor = borderColor;
        }

        #region Properties
        private String _title;
        private String _message;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbltitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblmessage.Text = value; }
        }

        #endregion


        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            FormsBorder.ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        // invalida a area do formulario que esta agora para que eu possa fazer as mudanças

        
        private void NoteView_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }



    }
}
