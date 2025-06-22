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
            ((System.ComponentModel.ISupportInitialize)closeX).BeginInit();
            SuspendLayout();
            // 
            // saveNote_button
            // 
            saveNote_button.Location = new Point(489, 375);
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
            NoteText_richTbox.Location = new Point(26, 59);
            NoteText_richTbox.Name = "NoteText_richTbox";
            NoteText_richTbox.Size = new Size(517, 277);
            NoteText_richTbox.TabIndex = 1;
            NoteText_richTbox.Text = "";
            // 
            // noteTitleText
            // 
            noteTitleText.Location = new Point(26, 26);
            noteTitleText.Name = "noteTitleText";
            noteTitleText.Size = new Size(217, 27);
            noteTitleText.TabIndex = 2;
            // 
            // closeX
            // 
            closeX.Image = (Image)resources.GetObject("closeX.Image");
            closeX.Location = new Point(636, 3);
            closeX.Name = "closeX";
            closeX.Size = new Size(38, 35);
            closeX.SizeMode = PictureBoxSizeMode.StretchImage;
            closeX.TabIndex = 3;
            closeX.TabStop = false;
            closeX.Click += closeX_Click;
            // 
            // CreateNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources._4fb735450ccd37f844681e08fbaca7f8;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(closeX);
            Controls.Add(noteTitleText);
            Controls.Add(NoteText_richTbox);
            Controls.Add(saveNote_button);
            DoubleBuffered = true;
            Name = "CreateNote";
            Size = new Size(685, 490);
            ((System.ComponentModel.ISupportInitialize)closeX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveNote_button;
        private RichTextBox NoteText_richTbox;
        private TextBox noteTitleText;
        private PictureBox closeX;
    }
}
