namespace NoteLogin
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_box = new TextBox();
            password_box = new TextBox();
            enter_button = new Button();
            label3 = new Label();
            newAccount_button = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login_box
            // 
            login_box.Cursor = Cursors.Hand;
            login_box.Location = new Point(40, 3);
            login_box.Name = "login_box";
            login_box.Size = new Size(341, 27);
            login_box.TabIndex = 1;
            login_box.TextChanged += textBox1_TextChanged;
            // 
            // password_box
            // 
            password_box.Location = new Point(40, 83);
            password_box.MaxLength = 16;
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.Size = new Size(333, 27);
            password_box.TabIndex = 3;
            password_box.UseSystemPasswordChar = true;
            // 
            // enter_button
            // 
            enter_button.BackgroundImageLayout = ImageLayout.Stretch;
            enter_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            enter_button.ForeColor = SystemColors.ActiveCaptionText;
            enter_button.Location = new Point(172, 266);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(132, 41);
            enter_button.TabIndex = 4;
            enter_button.Text = "ENTRAR";
            enter_button.UseVisualStyleBackColor = true;
            enter_button.Click += enter_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Text", 20F);
            label3.Location = new Point(141, 9);
            label3.Name = "label3";
            label3.Size = new Size(226, 49);
            label3.TabIndex = 5;
            label3.Text = "BEM VINDO!";
            // 
            // newAccount_button
            // 
            newAccount_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            newAccount_button.ForeColor = SystemColors.ActiveCaptionText;
            newAccount_button.Location = new Point(172, 376);
            newAccount_button.Name = "newAccount_button";
            newAccount_button.Size = new Size(132, 48);
            newAccount_button.TabIndex = 6;
            newAccount_button.Text = "CRIAR CONTA";
            newAccount_button.UseVisualStyleBackColor = true;
            newAccount_button.Click += newAccount_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(215, 329);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 7;
            label4.Text = "OU";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_84308;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.password_3715;
            pictureBox2.Location = new Point(1, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(login_box);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(password_box);
            panel1.Location = new Point(94, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 135);
            panel1.TabIndex = 10;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources._4fb735450ccd37f844681e08fbaca7f8;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 507);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(newAccount_button);
            Controls.Add(label3);
            Controls.Add(enter_button);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox login_box;
        private TextBox password_box;
        private Button enter_button;
        private Label label3;
        private Button newAccount_button;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}
