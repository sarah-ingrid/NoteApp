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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
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
            back_login = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            passwordEye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)back_login).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordEye).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(95, 70);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(95, 140);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(95, 210);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(95, 318);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(95, 410);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Gênero:";
            // 
            // user_name
            // 
            user_name.Location = new Point(95, 93);
            user_name.Name = "user_name";
            user_name.Size = new Size(284, 27);
            user_name.TabIndex = 5;
            // 
            // user_login
            // 
            user_login.ForeColor = Color.Black;
            user_login.Location = new Point(95, 163);
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
            user_senha.Location = new Point(95, 233);
            user_senha.Name = "user_senha";
            user_senha.PlaceholderText = "crie sua senha de acesso";
            user_senha.Size = new Size(251, 27);
            user_senha.TabIndex = 7;
            user_senha.UseSystemPasswordChar = true;
            // 
            // user_email
            // 
            user_email.Location = new Point(95, 341);
            user_email.Name = "user_email";
            user_email.Size = new Size(284, 27);
            user_email.TabIndex = 8;
            // 
            // box_gender
            // 
            box_gender.FormattingEnabled = true;
            box_gender.Items.AddRange(new object[] { "Feminino", "Masculino", "Outros" });
            box_gender.Location = new Point(161, 407);
            box_gender.Name = "box_gender";
            box_gender.Size = new Size(179, 28);
            box_gender.TabIndex = 9;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(396, 449);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(121, 51);
            registerButton.TabIndex = 10;
            registerButton.Text = "CADASTRAR";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // back_login
            // 
            back_login.BackColor = Color.Transparent;
            back_login.Cursor = Cursors.Hand;
            back_login.Image = Properties.Resources.backarrow_80933;
            back_login.Location = new Point(12, 12);
            back_login.Name = "back_login";
            back_login.Size = new Size(48, 47);
            back_login.SizeMode = PictureBoxSizeMode.StretchImage;
            back_login.TabIndex = 11;
            back_login.TabStop = false;
            back_login.Click += back_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(passwordEye);
            panel1.Controls.Add(user_name);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(box_gender);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(user_email);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(user_senha);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(user_login);
            panel1.Location = new Point(327, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 542);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(93, 260);
            label6.Name = "label6";
            label6.Size = new Size(447, 43);
            label6.TabIndex = 13;
            label6.Text = "Use no mínimo 6 caracteres (com distinção entre maiúsculas e minúsculas) com pelo menos um número ou caractere especial.";
            // 
            // passwordEye
            // 
            passwordEye.BackColor = SystemColors.Window;
            passwordEye.Image = Properties.Resources.eye_closed;
            passwordEye.Location = new Point(344, 233);
            passwordEye.Name = "passwordEye";
            passwordEye.Size = new Size(35, 26);
            passwordEye.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordEye.TabIndex = 12;
            passwordEye.TabStop = false;
            passwordEye.Click += passwordEye_Click;
            // 
            // NewAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.blue_gradient_background_07xqmk2r9n9vmxli;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1219, 831);
            Controls.Add(panel1);
            Controls.Add(back_login);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewAccount";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRIAR CADASTRO";
            Load += NewAccount_Load;
            ((System.ComponentModel.ISupportInitialize)back_login).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordEye).EndInit();
            ResumeLayout(false);
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
        private PictureBox back_login;
        private Panel panel1;
        private PictureBox passwordEye;
        private Label label6;
    }
}