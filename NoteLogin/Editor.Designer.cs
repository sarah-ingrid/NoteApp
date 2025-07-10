namespace NoteLogin
{
    partial class Editor
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
            title_box = new TextBox();
            panel1 = new Panel();
            underline_option = new PictureBox();
            italic_option = new PictureBox();
            bold_option = new PictureBox();
            richTextBox = new RichTextBox();
            pictureBox_trash = new PictureBox();
            pictureBox_star = new PictureBox();
            saveButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)underline_option).BeginInit();
            ((System.ComponentModel.ISupportInitialize)italic_option).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bold_option).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_trash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).BeginInit();
            SuspendLayout();
            // 
            // title_box
            // 
            title_box.BorderStyle = BorderStyle.None;
            title_box.Location = new Point(13, 14);
            title_box.Name = "title_box";
            title_box.PlaceholderText = "DIGITE SEU TITULO";
            title_box.Size = new Size(173, 20);
            title_box.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(underline_option);
            panel1.Controls.Add(italic_option);
            panel1.Controls.Add(bold_option);
            panel1.Location = new Point(-4, 412);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 35);
            panel1.TabIndex = 1;
            // 
            // underline_option
            // 
            underline_option.Image = Properties.Resources.underline_text;
            underline_option.Location = new Point(99, 13);
            underline_option.Name = "underline_option";
            underline_option.Size = new Size(19, 17);
            underline_option.SizeMode = PictureBoxSizeMode.StretchImage;
            underline_option.TabIndex = 2;
            underline_option.TabStop = false;
            underline_option.Click += underline_option_Click;
            // 
            // italic_option
            // 
            italic_option.Image = Properties.Resources.italic_text;
            italic_option.Location = new Point(58, 13);
            italic_option.Name = "italic_option";
            italic_option.Size = new Size(19, 17);
            italic_option.SizeMode = PictureBoxSizeMode.StretchImage;
            italic_option.TabIndex = 1;
            italic_option.TabStop = false;
            italic_option.Click += italic_option_Click;
            // 
            // bold_option
            // 
            bold_option.Image = Properties.Resources.bold_text;
            bold_option.Location = new Point(17, 13);
            bold_option.Name = "bold_option";
            bold_option.Size = new Size(19, 17);
            bold_option.SizeMode = PictureBoxSizeMode.StretchImage;
            bold_option.TabIndex = 0;
            bold_option.TabStop = false;
            bold_option.Click += bold_option_Click;
            // 
            // richTextBox
            // 
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Cursor = Cursors.IBeam;
            richTextBox.Location = new Point(13, 51);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(267, 336);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            // 
            // pictureBox_trash
            // 
            pictureBox_trash.Cursor = Cursors.Hand;
            pictureBox_trash.Image = Properties.Resources.trash;
            pictureBox_trash.Location = new Point(283, 755);
            pictureBox_trash.Name = "pictureBox_trash";
            pictureBox_trash.Size = new Size(29, 34);
            pictureBox_trash.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_trash.TabIndex = 3;
            pictureBox_trash.TabStop = false;
            pictureBox_trash.Click += pictureBox_trash_Click;
            // 
            // pictureBox_star
            // 
            pictureBox_star.Cursor = Cursors.Hand;
            pictureBox_star.Image = Properties.Resources.star_empty;
            pictureBox_star.Location = new Point(284, 1);
            pictureBox_star.Name = "pictureBox_star";
            pictureBox_star.Size = new Size(35, 32);
            pictureBox_star.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_star.TabIndex = 4;
            pictureBox_star.TabStop = false;
            pictureBox_star.Click += pictureBox_star_Click;
            // 
            // saveButton
            // 
            saveButton.Cursor = Cursors.Hand;
            saveButton.Location = new Point(215, 473);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 5;
            saveButton.Text = "Salvar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(saveButton);
            Controls.Add(pictureBox_star);
            Controls.Add(pictureBox_trash);
            Controls.Add(richTextBox);
            Controls.Add(panel1);
            Controls.Add(title_box);
            Name = "Editor";
            Size = new Size(320, 802);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)underline_option).EndInit();
            ((System.ComponentModel.ISupportInitialize)italic_option).EndInit();
            ((System.ComponentModel.ISupportInitialize)bold_option).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_trash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox title_box;
        private Panel panel1;
        private RichTextBox richTextBox;
        private PictureBox pictureBox_trash;
        private PictureBox pictureBox_star;
        private PictureBox underline_option;
        private PictureBox italic_option;
        private PictureBox bold_option;
        private Button saveButton;
        private PictureBox pictureBox1;
    }
}
