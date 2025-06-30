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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            login_box = new TextBox();
            password_box = new TextBox();
            enter_button = new Button();
            label3 = new Label();
            newAccount_button = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            center_panel = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            center_panel.SuspendLayout();
            SuspendLayout();
            // 
            // login_box
            // 
            login_box.Cursor = Cursors.Hand;
            login_box.Location = new Point(99, 128);
            login_box.Name = "login_box";
            login_box.Size = new Size(341, 27);
            login_box.TabIndex = 1;
            login_box.TextChanged += textBox1_TextChanged;
            // 
            // password_box
            // 
            password_box.Location = new Point(99, 204);
            password_box.MaxLength = 16;
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.Size = new Size(341, 27);
            password_box.TabIndex = 3;
            password_box.UseSystemPasswordChar = true;
            // 
            // enter_button
            // 
            enter_button.BackgroundImageLayout = ImageLayout.Stretch;
            enter_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            enter_button.ForeColor = SystemColors.ActiveCaptionText;
            enter_button.Location = new Point(203, 262);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(132, 50);
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
            label3.Location = new Point(153, 29);
            label3.Name = "label3";
            label3.Size = new Size(226, 49);
            label3.TabIndex = 5;
            label3.Text = "BEM VINDO!";
            // 
            // newAccount_button
            // 
            newAccount_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            newAccount_button.ForeColor = SystemColors.ActiveCaptionText;
            newAccount_button.Location = new Point(203, 429);
            newAccount_button.Name = "newAccount_button";
            newAccount_button.Size = new Size(132, 48);
            newAccount_button.TabIndex = 6;
            newAccount_button.Text = "CRIAR CONTA";
            newAccount_button.UseVisualStyleBackColor = true;
            newAccount_button.Click += newAccount_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_84308;
            pictureBox1.Location = new Point(60, 125);
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
            pictureBox2.Location = new Point(60, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // center_panel
            // 
            center_panel.BackColor = Color.Silver;
            center_panel.Controls.Add(label1);
            center_panel.Controls.Add(label3);
            center_panel.Controls.Add(pictureBox2);
            center_panel.Controls.Add(newAccount_button);
            center_panel.Controls.Add(enter_button);
            center_panel.Controls.Add(login_box);
            center_panel.Controls.Add(password_box);
            center_panel.Controls.Add(pictureBox1);
            center_panel.Location = new Point(326, 154);
            center_panel.Name = "center_panel";
            center_panel.Size = new Size(566, 500);
            center_panel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(204, 406);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 10;
            label1.Text = "Não possui conta?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.blue_gradient_background_07xqmk2r9n9vmxli;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1219, 831);
            Controls.Add(center_panel);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            Shown += LoginForm_Shown;
            Paint += LoginForm_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            center_panel.ResumeLayout(false);
            center_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox login_box;
        private TextBox password_box;
        private Button enter_button;
        private Label label3;
        private Button newAccount_button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel center_panel;
        private Label label1;
    }
}
