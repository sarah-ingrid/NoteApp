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
            fontColor = new PictureBox();
            fontSizeDecrease = new PictureBox();
            fontBackColor = new PictureBox();
            pictureBox2 = new PictureBox();
            underline_option = new PictureBox();
            italic_option = new PictureBox();
            fontStyle = new PictureBox();
            bold_option = new PictureBox();
            fontSizeIncrease = new PictureBox();
            richTextBox = new RichTextBox();
            pictureBox_trash = new PictureBox();
            pictureBox_star = new PictureBox();
            saveButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fontColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeDecrease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontBackColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)underline_option).BeginInit();
            ((System.ComponentModel.ISupportInitialize)italic_option).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bold_option).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeIncrease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_trash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).BeginInit();
            SuspendLayout();
            // 
            // title_box
            // 
            title_box.BackColor = Color.WhiteSmoke;
            title_box.BorderStyle = BorderStyle.None;
            title_box.Location = new Point(13, 14);
            title_box.Name = "title_box";
            title_box.PlaceholderText = "DIGITE SEU TITULO";
            title_box.Size = new Size(173, 20);
            title_box.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(fontColor);
            panel1.Controls.Add(fontSizeDecrease);
            panel1.Controls.Add(fontBackColor);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(underline_option);
            panel1.Controls.Add(italic_option);
            panel1.Controls.Add(fontStyle);
            panel1.Controls.Add(bold_option);
            panel1.Controls.Add(fontSizeIncrease);
            panel1.Location = new Point(-4, 412);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 35);
            panel1.TabIndex = 1;
            // 
            // fontColor
            // 
            fontColor.Image = Properties.Resources.font_color;
            fontColor.Location = new Point(233, 7);
            fontColor.Name = "fontColor";
            fontColor.Size = new Size(20, 20);
            fontColor.SizeMode = PictureBoxSizeMode.StretchImage;
            fontColor.TabIndex = 7;
            fontColor.TabStop = false;
            fontColor.Click += fontColor_Click;
            // 
            // fontSizeDecrease
            // 
            fontSizeDecrease.Image = Properties.Resources.size_decrease;
            fontSizeDecrease.Location = new Point(181, 8);
            fontSizeDecrease.Name = "fontSizeDecrease";
            fontSizeDecrease.Size = new Size(20, 20);
            fontSizeDecrease.SizeMode = PictureBoxSizeMode.StretchImage;
            fontSizeDecrease.TabIndex = 8;
            fontSizeDecrease.TabStop = false;
            fontSizeDecrease.Click += fontSizeDecrease_Click;
            // 
            // fontBackColor
            // 
            fontBackColor.Image = Properties.Resources.highlight;
            fontBackColor.Location = new Point(207, 8);
            fontBackColor.Name = "fontBackColor";
            fontBackColor.Size = new Size(20, 20);
            fontBackColor.SizeMode = PictureBoxSizeMode.StretchImage;
            fontBackColor.TabIndex = 6;
            fontBackColor.TabStop = false;
            fontBackColor.Click += fontBackColor_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.undo_arrow;
            pictureBox2.Location = new Point(288, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += UndoButton_Click;
            // 
            // underline_option
            // 
            underline_option.Image = Properties.Resources.underline_text;
            underline_option.Location = new Point(80, 11);
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
            italic_option.Location = new Point(46, 11);
            italic_option.Name = "italic_option";
            italic_option.Size = new Size(19, 17);
            italic_option.SizeMode = PictureBoxSizeMode.StretchImage;
            italic_option.TabIndex = 1;
            italic_option.TabStop = false;
            italic_option.Click += italic_option_Click;
            // 
            // fontStyle
            // 
            fontStyle.Image = Properties.Resources.font_symbol;
            fontStyle.Location = new Point(261, 6);
            fontStyle.Name = "fontStyle";
            fontStyle.Size = new Size(19, 21);
            fontStyle.SizeMode = PictureBoxSizeMode.StretchImage;
            fontStyle.TabIndex = 3;
            fontStyle.TabStop = false;
            fontStyle.Click += fontStyle_Click;
            // 
            // bold_option
            // 
            bold_option.Image = Properties.Resources.bold_text;
            bold_option.Location = new Point(17, 11);
            bold_option.Name = "bold_option";
            bold_option.Size = new Size(19, 17);
            bold_option.SizeMode = PictureBoxSizeMode.StretchImage;
            bold_option.TabIndex = 0;
            bold_option.TabStop = false;
            bold_option.Click += bold_option_Click;
            // 
            // fontSizeIncrease
            // 
            fontSizeIncrease.Image = Properties.Resources.size_increase;
            fontSizeIncrease.Location = new Point(155, 8);
            fontSizeIncrease.Name = "fontSizeIncrease";
            fontSizeIncrease.Size = new Size(20, 20);
            fontSizeIncrease.SizeMode = PictureBoxSizeMode.StretchImage;
            fontSizeIncrease.TabIndex = 6;
            fontSizeIncrease.TabStop = false;
            fontSizeIncrease.Click += fontSizeIncrease_Click;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = Color.WhiteSmoke;
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Cursor = Cursors.IBeam;
            richTextBox.Location = new Point(13, 51);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(280, 346);
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
            BackColor = Color.Lavender;
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
            ((System.ComponentModel.ISupportInitialize)fontColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeDecrease).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontBackColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)underline_option).EndInit();
            ((System.ComponentModel.ISupportInitialize)italic_option).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bold_option).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeIncrease).EndInit();
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
        private PictureBox fontSizeDecrease;
        private PictureBox fontSizeIncrease;
        private PictureBox fontStyle;
        private PictureBox pictureBox2;
        private PictureBox fontColor;
        private PictureBox fontBackColor;
    }
}
