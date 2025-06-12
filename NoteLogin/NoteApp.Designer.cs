namespace NoteLogin
{
    partial class NoteApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteApp));
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            menu_box = new PictureBox();
            panel6 = new Panel();
            opcaoSair = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            notes_button = new Button();
            panel3 = new Panel();
            tasks_button = new Button();
            panel4 = new Panel();
            importants_button = new Button();
            panel5 = new Panel();
            settings_button = new Button();
            timerSidebar = new System.Windows.Forms.Timer(components);
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_box).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.SteelBlue;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel6);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel5);
            Sidebar.Location = new Point(-10, -10);
            Sidebar.MaximumSize = new Size(278, 873);
            Sidebar.MinimumSize = new Size(93, 873);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(278, 873);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(menu_box);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 65);
            panel1.TabIndex = 0;
            // 
            // menu_box
            // 
            menu_box.Cursor = Cursors.Hand;
            menu_box.Image = (Image)resources.GetObject("menu_box.Image");
            menu_box.InitialImage = (Image)resources.GetObject("menu_box.InitialImage");
            menu_box.Location = new Point(14, 18);
            menu_box.Name = "menu_box";
            menu_box.Size = new Size(44, 38);
            menu_box.SizeMode = PictureBoxSizeMode.StretchImage;
            menu_box.TabIndex = 0;
            menu_box.TabStop = false;
            menu_box.Click += menu_box_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(opcaoSair);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(3, 74);
            panel6.Name = "panel6";
            panel6.Size = new Size(275, 95);
            panel6.TabIndex = 1;
            // 
            // opcaoSair
            // 
            opcaoSair.AutoSize = true;
            opcaoSair.Cursor = Cursors.Hand;
            opcaoSair.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opcaoSair.ForeColor = Color.FromArgb(192, 0, 0);
            opcaoSair.Location = new Point(102, 65);
            opcaoSair.Name = "opcaoSair";
            opcaoSair.Size = new Size(38, 23);
            opcaoSair.TabIndex = 4;
            opcaoSair.Text = "Sair";
            opcaoSair.Click += opcaoSair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(103, 47);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 1;
            label2.Text = "login do usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(100, 12);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 1;
            label1.Text = "Welcome, user!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.round_account_button_with_user_inside_icon_icons_com_72596;
            pictureBox2.Location = new Point(19, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(notes_button);
            panel2.Location = new Point(3, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 58);
            panel2.TabIndex = 1;
            // 
            // notes_button
            // 
            notes_button.BackColor = Color.LightSteelBlue;
            notes_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notes_button.Image = Properties.Resources.note_1200602;
            notes_button.ImageAlign = ContentAlignment.MiddleLeft;
            notes_button.Location = new Point(0, -28);
            notes_button.Name = "notes_button";
            notes_button.Padding = new Padding(30, 0, 0, 0);
            notes_button.Size = new Size(278, 112);
            notes_button.TabIndex = 2;
            notes_button.Text = "          Notas";
            notes_button.TextAlign = ContentAlignment.MiddleLeft;
            notes_button.UseVisualStyleBackColor = false;
            notes_button.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tasks_button);
            panel3.Location = new Point(3, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 58);
            panel3.TabIndex = 2;
            // 
            // tasks_button
            // 
            tasks_button.BackColor = Color.LightSteelBlue;
            tasks_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasks_button.Image = (Image)resources.GetObject("tasks_button.Image");
            tasks_button.ImageAlign = ContentAlignment.MiddleLeft;
            tasks_button.Location = new Point(0, -28);
            tasks_button.Name = "tasks_button";
            tasks_button.Padding = new Padding(30, 0, 0, 0);
            tasks_button.Size = new Size(278, 112);
            tasks_button.TabIndex = 2;
            tasks_button.Text = "          Tarefas";
            tasks_button.TextAlign = ContentAlignment.MiddleLeft;
            tasks_button.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(importants_button);
            panel4.Location = new Point(3, 303);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 58);
            panel4.TabIndex = 3;
            // 
            // importants_button
            // 
            importants_button.BackColor = Color.LightSteelBlue;
            importants_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importants_button.Image = (Image)resources.GetObject("importants_button.Image");
            importants_button.ImageAlign = ContentAlignment.MiddleLeft;
            importants_button.Location = new Point(0, -28);
            importants_button.Name = "importants_button";
            importants_button.Padding = new Padding(30, 0, 0, 0);
            importants_button.Size = new Size(278, 112);
            importants_button.TabIndex = 2;
            importants_button.Text = "          Importantes";
            importants_button.TextAlign = ContentAlignment.MiddleLeft;
            importants_button.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(settings_button);
            panel5.Location = new Point(3, 367);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 58);
            panel5.TabIndex = 2;
            // 
            // settings_button
            // 
            settings_button.BackColor = Color.LightSteelBlue;
            settings_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settings_button.Image = (Image)resources.GetObject("settings_button.Image");
            settings_button.ImageAlign = ContentAlignment.MiddleLeft;
            settings_button.Location = new Point(0, -28);
            settings_button.Name = "settings_button";
            settings_button.Padding = new Padding(30, 0, 0, 0);
            settings_button.Size = new Size(278, 112);
            settings_button.TabIndex = 2;
            settings_button.Text = "          Configuração";
            settings_button.TextAlign = ContentAlignment.MiddleLeft;
            settings_button.UseVisualStyleBackColor = false;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // NoteApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1219, 855);
            ControlBox = false;
            Controls.Add(Sidebar);
            Cursor = Cursors.Arrow;
            Name = "NoteApp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += NoteApp_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_box).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button notes_button;
        private Panel panel3;
        private Button tasks_button;
        private Panel panel4;
        private Button importants_button;
        private Panel panel5;
        private Button settings_button;
        private PictureBox menu_box;
        private System.Windows.Forms.Timer timerSidebar;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label opcaoSair;
    }
}