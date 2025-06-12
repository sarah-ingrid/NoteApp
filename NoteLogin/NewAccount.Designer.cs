namespace NoteLogin
{
    partial class NewAccount
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            user_name = new TextBox();
            user_login = new TextBox();
            user_senha = new TextBox();
            user_email = new TextBox();
            box_gender = new ComboBox();
            registerButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(26, 86);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(26, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(26, 195);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(26, 241);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(26, 303);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Gênero:";
            // 
            // user_name
            // 
            user_name.Location = new Point(115, 83);
            user_name.Name = "user_name";
            user_name.Size = new Size(284, 27);
            user_name.TabIndex = 5;
            // 
            // user_login
            // 
            user_login.ForeColor = Color.Black;
            user_login.Location = new Point(115, 142);
            user_login.MaxLength = 8;
            user_login.Name = "user_login";
            user_login.PlaceholderText = "crie seu login de acesso";
            user_login.Size = new Size(284, 27);
            user_login.TabIndex = 8;
            user_login.Enter += user_login_Enter;
            user_login.Leave += user_login_Leave;
            // 
            // user_senha
            // 
            user_senha.ForeColor = Color.Black;
            user_senha.Location = new Point(115, 195);
            user_senha.Name = "user_senha";
            user_senha.PlaceholderText = "crie sua senha de acesso";
            user_senha.Size = new Size(284, 27);
            user_senha.TabIndex = 7;
            // 
            // user_email
            // 
            user_email.Location = new Point(115, 241);
            user_email.Name = "user_email";
            user_email.Size = new Size(284, 27);
            user_email.TabIndex = 8;
            // 
            // box_gender
            // 
            box_gender.FormattingEnabled = true;
            box_gender.Items.AddRange(new object[] { "Feminino", "Masculino", "Outros" });
            box_gender.Location = new Point(115, 300);
            box_gender.Name = "box_gender";
            box_gender.Size = new Size(179, 28);
            box_gender.TabIndex = 9;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(321, 420);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(121, 51);
            registerButton.TabIndex = 10;
            registerButton.Text = "CADASTRAR";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.backarrow_80933;
            pictureBox1.Location = new Point(12, 448);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NewAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources._4fb735450ccd37f844681e08fbaca7f8;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 507);
            Controls.Add(pictureBox1);
            Controls.Add(registerButton);
            Controls.Add(box_gender);
            Controls.Add(user_email);
            Controls.Add(user_senha);
            Controls.Add(user_login);
            Controls.Add(user_name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewAccount";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRIAR CADASTRO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox user_name;
        private TextBox user_login;
        private TextBox user_senha;
        private TextBox user_email;
        private ComboBox box_gender;
        private Button registerButton;
        private PictureBox pictureBox1;
    }
}