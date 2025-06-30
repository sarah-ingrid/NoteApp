namespace NoteLogin
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            profilePicture = new PictureBox();
            panel1 = new Panel();
            textBox_email = new Label();
            textBox_name = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            change_photo = new Label();
            change_passwrd = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label_login = new Label();
            panel_newPasswrd = new Panel();
            backButton = new PictureBox();
            save_button = new Button();
            novaSenha = new TextBox();
            senhaAtual = new TextBox();
            label_novasenha = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_newPasswrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // profilePicture
            // 
            profilePicture.BorderStyle = BorderStyle.FixedSingle;
            profilePicture.Image = Properties.Resources.default_picture_profile;
            profilePicture.Location = new Point(12, 26);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(149, 140);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox_email);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(change_photo);
            panel1.Controls.Add(change_passwrd);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(179, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 396);
            panel1.TabIndex = 3;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = SystemColors.Control;
            textBox_email.BorderStyle = BorderStyle.FixedSingle;
            textBox_email.Location = new Point(24, 204);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(266, 31);
            textBox_email.TabIndex = 18;
            // 
            // textBox_name
            // 
            textBox_name.BackColor = SystemColors.Control;
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Location = new Point(24, 97);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(266, 31);
            textBox_name.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.key_password;
            pictureBox1.Location = new Point(12, 352);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.picture;
            pictureBox2.Location = new Point(175, 353);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // change_photo
            // 
            change_photo.AutoSize = true;
            change_photo.Cursor = Cursors.Hand;
            change_photo.Location = new Point(203, 354);
            change_photo.Name = "change_photo";
            change_photo.Size = new Size(146, 20);
            change_photo.TabIndex = 10;
            change_photo.Text = "Alterar foto de perfil";
            change_photo.Click += change_photo_Click;
            // 
            // change_passwrd
            // 
            change_passwrd.AutoSize = true;
            change_passwrd.Cursor = Cursors.Hand;
            change_passwrd.Location = new Point(40, 354);
            change_passwrd.Name = "change_passwrd";
            change_passwrd.Size = new Size(96, 20);
            change_passwrd.TabIndex = 8;
            change_passwrd.Text = "Alterar senha";
            change_passwrd.Click += change_passwrd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 163);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 60);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Nome";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.2F, FontStyle.Bold);
            label3.Location = new Point(124, 14);
            label3.Name = "label3";
            label3.Size = new Size(114, 38);
            label3.TabIndex = 2;
            label3.Text = "Dados Gerais";
            // 
            // label_login
            // 
            label_login.Font = new Font("Segoe UI", 9.2F, FontStyle.Bold);
            label_login.Location = new Point(38, 178);
            label_login.Name = "label_login";
            label_login.Size = new Size(97, 38);
            label_login.TabIndex = 1;
            label_login.Text = "name user";
            // 
            // panel_newPasswrd
            // 
            panel_newPasswrd.Controls.Add(backButton);
            panel_newPasswrd.Controls.Add(save_button);
            panel_newPasswrd.Controls.Add(novaSenha);
            panel_newPasswrd.Controls.Add(senhaAtual);
            panel_newPasswrd.Controls.Add(label_novasenha);
            panel_newPasswrd.Controls.Add(label2);
            panel_newPasswrd.Location = new Point(179, 16);
            panel_newPasswrd.Name = "panel_newPasswrd";
            panel_newPasswrd.Size = new Size(361, 392);
            panel_newPasswrd.TabIndex = 4;
            // 
            // backButton
            // 
            backButton.Cursor = Cursors.Hand;
            backButton.Image = Properties.Resources.backarrow_80933;
            backButton.Location = new Point(8, 352);
            backButton.Name = "backButton";
            backButton.Size = new Size(34, 32);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 16;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // save_button
            // 
            save_button.Location = new Point(231, 321);
            save_button.Name = "save_button";
            save_button.Size = new Size(95, 38);
            save_button.TabIndex = 15;
            save_button.Text = "Salvar";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // novaSenha
            // 
            novaSenha.Location = new Point(52, 221);
            novaSenha.Name = "novaSenha";
            novaSenha.Size = new Size(186, 27);
            novaSenha.TabIndex = 14;
            // 
            // senhaAtual
            // 
            senhaAtual.Location = new Point(52, 89);
            senhaAtual.Name = "senhaAtual";
            senhaAtual.Size = new Size(186, 27);
            senhaAtual.TabIndex = 13;
            // 
            // label_novasenha
            // 
            label_novasenha.AutoSize = true;
            label_novasenha.Location = new Point(52, 180);
            label_novasenha.Name = "label_novasenha";
            label_novasenha.Size = new Size(89, 20);
            label_novasenha.TabIndex = 11;
            label_novasenha.Text = "Nova senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 49);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 12;
            label2.Text = "Senha atual";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(552, 416);
            Controls.Add(panel1);
            Controls.Add(label_login);
            Controls.Add(profilePicture);
            Controls.Add(panel_newPasswrd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_newPasswrd.ResumeLayout(false);
            panel_newPasswrd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox profilePicture;
        private Panel panel1;
        private Label label3;
        private Label change_photo;
        private Label change_passwrd;
        private Label label5;
        private Label label4;
        private Label label_login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel_newPasswrd;
        private Button save_button;
        private TextBox novaSenha;
        private TextBox senhaAtual;
        private Label label_novasenha;
        private Label label2;
        private PictureBox backButton;
        private Label textBox_email;
        private Label textBox_name;
    }
}