using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace NoteLogin
{
    public partial class NoteView : UserControl
    {
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(127, 255, 212);

        public int IDNote { get; set; }
        public bool Important { get; set; }

        public void UpdateStarImage()
        {
            IsImportant.Image = Important
                ? Properties.Resources.star_full
                : Properties.Resources.star_empty;
        }

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



        private void IsImportant_Click(object sender, EventArgs e)
        {

            Important = !Important;
            // trocando as imagens
            UpdateStarImage();

            if (!Important)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }

            using var conexao = DataBase.ConexaoBanco();
            {
                string UpdateQuery = "UPDATE tb_notes SET IsImportant = @important WHERE ID_note = @id;";

                using (var comando = new SQLiteCommand(UpdateQuery, conexao)) 
                {
                    comando.Parameters.AddWithValue("@id", IDNote);
                    comando.Parameters.AddWithValue("@important", Important? 1 : 0); // sql entende que 1 é importante e 0 não é importante

                    comando.ExecuteNonQuery();
                }
            }

        }
    }
}
