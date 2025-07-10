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
        private int borderRadius = 15;
        private int borderSize = 1;

        public int IDNote { get; set; }
        public bool Important { get; set; }
        private bool IsInImportantSession { get; set; }
        public NoteApp noteApp { get; set; }

        public void UpdateStarImage()
        {
            IsImportant.Image = Important
                ? Properties.Resources.star_full
                : Properties.Resources.star_empty;
        }

        public NoteView()
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize);

        }

        #region Properties
        private String _title;
        private String _message;

        [Category("Custom Props for NoteView")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbltitle.Text = value; }
        }

        [Category("Custom Props for NoteView")]
        public string Message
        {
            get { return _message; }
            // set { _message = value; lblmessage.Rtf = value; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.TrimStart().StartsWith("{\\rtf"))
                    {
                        rtbmessage.Rtf = value;
                    }
                    else
                    {
                        rtbmessage.Text = value;
                    }
                }
                else
                {
                    rtbmessage.Clear();
                }
            }
        }

        #endregion


        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void NoteView_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void IsImportant_Click(object sender, EventArgs e)
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


        private void NoteView_Load(object sender, EventArgs e)
        {
            FormsBorder.SetRegion(this, borderRadius);
        }

        private void NoteView_Click(object sender, EventArgs e)
        {

        }

        private void CarregarItemNoEditor(object sender, EventArgs e)
        {

         //   NoteApp.CarregarItemNoEditor(IDNote, "tb_note");
        }
    }
}
