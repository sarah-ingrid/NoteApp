namespace NoteLogin
{
    partial class CreateNote
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNote));
            saveNote_button = new Button();
            NoteText_richTbox = new RichTextBox();
            noteTitleText = new TextBox();
            closeX = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)closeX).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // saveNote_button
            // 
            saveNote_button.Location = new Point(335, 460);
            saveNote_button.Name = "saveNote_button";
            saveNote_button.Size = new Size(94, 29);
            saveNote_button.TabIndex = 0;
            saveNote_button.Text = "Salvar";
            saveNote_button.UseVisualStyleBackColor = true;
            saveNote_button.Click += saveNote_button_Click;
            // 
            // NoteText_richTbox
            // 
            NoteText_richTbox.Cursor = Cursors.IBeam;
            NoteText_richTbox.Location = new Point(17, 74);
            NoteText_richTbox.Name = "NoteText_richTbox";
            NoteText_richTbox.Size = new Size(366, 354);
            NoteText_richTbox.TabIndex = 1;
            NoteText_richTbox.Text = "";
            // 
            // noteTitleText
            // 
            noteTitleText.Location = new Point(17, 26);
            noteTitleText.Name = "noteTitleText";
            noteTitleText.Size = new Size(294, 27);
            noteTitleText.TabIndex = 2;
            // 
            // closeX
            // 
            closeX.Image = (Image)resources.GetObject("closeX.Image");
            closeX.Location = new Point(518, 3);
            closeX.Name = "closeX";
            closeX.Size = new Size(38, 35);
            closeX.SizeMode = PictureBoxSizeMode.StretchImage;
            closeX.TabIndex = 3;
            closeX.TabStop = false;
            closeX.Click += closeX_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(NoteText_richTbox);
            panel1.Controls.Add(noteTitleText);
            panel1.Controls.Add(closeX);
            panel1.Controls.Add(saveNote_button);
            panel1.Location = new Point(250, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 518);
            panel1.TabIndex = 4;
            // 
            // CreateNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "CreateNote";
            Size = new Size(721, 603);
            ((System.ComponentModel.ISupportInitialize)closeX).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button saveNote_button;
        private RichTextBox NoteText_richTbox;
        private TextBox noteTitleText;
        private PictureBox closeX;
        private Panel panel1;
    }
}
