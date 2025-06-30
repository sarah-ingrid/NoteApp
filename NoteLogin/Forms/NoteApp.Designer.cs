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
            NewNote = new PictureBox();
            panel_inicio = new Panel();
            opcaoSair = new Label();
            profilepicture = new CircularPictureBox();
            welcomeUser_label = new Label();
            loginUser_label = new Label();
            panel2 = new Panel();
            notes_button = new Button();
            panel3 = new Panel();
            tasks_button = new Button();
            panel4 = new Panel();
            importants_button = new Button();
            settingsContainer = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            config_button = new Button();
            panel10 = new Panel();
            settings_exit = new Button();
            panel7 = new Panel();
            button_profile = new Button();
            panel9 = new Panel();
            theme_button = new Button();
            timerSidebar = new System.Windows.Forms.Timer(components);
            Panel_Principal = new FlowLayoutPanel();
            theme_panel = new Panel();
            purple_theme = new PictureBox();
            yellow_theme = new PictureBox();
            orange_theme = new PictureBox();
            green_theme = new PictureBox();
            pink_theme = new PictureBox();
            blue_theme = new PictureBox();
            borderStylePanel = new Panel();
            bttnMinimize_borderstyle = new Button();
            bttnX_borderStyle = new Button();
            settings_timer = new System.Windows.Forms.Timer(components);
            new_menu = new ContextMenuStrip(components);
            novaNotaToolStripMenuItem = new ToolStripMenuItem();
            notaTarefaToolStripMenuItem = new ToolStripMenuItem();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_box).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NewNote).BeginInit();
            panel_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilepicture).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            settingsContainer.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            Panel_Principal.SuspendLayout();
            theme_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purple_theme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellow_theme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orange_theme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)green_theme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pink_theme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blue_theme).BeginInit();
            borderStylePanel.SuspendLayout();
            new_menu.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.DarkMagenta;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel6);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(settingsContainer);
            Sidebar.Location = new Point(-8, 23);
            Sidebar.MaximumSize = new Size(278, 873);
            Sidebar.MinimumSize = new Size(107, 873);
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
            panel6.Controls.Add(NewNote);
            panel6.Controls.Add(panel_inicio);
            panel6.Location = new Point(3, 74);
            panel6.Name = "panel6";
            panel6.Size = new Size(275, 170);
            panel6.TabIndex = 1;
            // 
            // NewNote
            // 
            NewNote.Cursor = Cursors.Hand;
            NewNote.Image = (Image)resources.GetObject("NewNote.Image");
            NewNote.Location = new Point(9, 130);
            NewNote.Name = "NewNote";
            NewNote.Size = new Size(42, 40);
            NewNote.SizeMode = PictureBoxSizeMode.StretchImage;
            NewNote.TabIndex = 1;
            NewNote.TabStop = false;
            NewNote.Click += NewNote_Click;
            // 
            // panel_inicio
            // 
            panel_inicio.BackColor = Color.Plum;
            panel_inicio.Controls.Add(opcaoSair);
            panel_inicio.Controls.Add(profilepicture);
            panel_inicio.Controls.Add(welcomeUser_label);
            panel_inicio.Controls.Add(loginUser_label);
            panel_inicio.Location = new Point(9, 3);
            panel_inicio.Name = "panel_inicio";
            panel_inicio.Size = new Size(266, 110);
            panel_inicio.TabIndex = 1;
            // 
            // opcaoSair
            // 
            opcaoSair.AutoSize = true;
            opcaoSair.Cursor = Cursors.Hand;
            opcaoSair.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opcaoSair.ForeColor = Color.FromArgb(192, 0, 0);
            opcaoSair.Location = new Point(107, 77);
            opcaoSair.Name = "opcaoSair";
            opcaoSair.Size = new Size(34, 20);
            opcaoSair.TabIndex = 4;
            opcaoSair.Text = "Sair";
            opcaoSair.Click += opcaoSair_Click;
            // 
            // profilepicture
            // 
            profilepicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            profilepicture.BorderColor = Color.RoyalBlue;
            profilepicture.BorderColor2 = Color.HotPink;
            profilepicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            profilepicture.BorderSize = 2;
            profilepicture.GradientAngle = 50F;
            profilepicture.Image = Properties.Resources.default_picture_profile;
            profilepicture.Location = new Point(0, 9);
            profilepicture.Name = "profilepicture";
            profilepicture.Size = new Size(96, 88);
            profilepicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilepicture.TabIndex = 1;
            profilepicture.TabStop = false;
            // 
            // welcomeUser_label
            // 
            welcomeUser_label.AutoSize = true;
            welcomeUser_label.Font = new Font("Segoe UI", 10.8F);
            welcomeUser_label.ForeColor = SystemColors.ActiveCaptionText;
            welcomeUser_label.Location = new Point(102, 24);
            welcomeUser_label.Name = "welcomeUser_label";
            welcomeUser_label.Size = new Size(86, 25);
            welcomeUser_label.TabIndex = 1;
            welcomeUser_label.Text = "Olá, user!";
            // 
            // loginUser_label
            // 
            loginUser_label.AutoSize = true;
            loginUser_label.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginUser_label.ForeColor = SystemColors.ActiveCaptionText;
            loginUser_label.Location = new Point(107, 49);
            loginUser_label.Name = "loginUser_label";
            loginUser_label.Size = new Size(104, 17);
            loginUser_label.TabIndex = 1;
            loginUser_label.Text = "login do usuario";
            // 
            // panel2
            // 
            panel2.Controls.Add(notes_button);
            panel2.Location = new Point(3, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 58);
            panel2.TabIndex = 1;
            // 
            // notes_button
            // 
            notes_button.BackColor = Color.Plum;
            notes_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notes_button.Image = Properties.Resources.note_1200602;
            notes_button.ImageAlign = ContentAlignment.MiddleLeft;
            notes_button.Location = new Point(0, -28);
            notes_button.Name = "notes_button";
            notes_button.Padding = new Padding(30, 0, 0, 0);
            notes_button.Size = new Size(278, 112);
            notes_button.TabIndex = 2;
            notes_button.Text = "             Notas";
            notes_button.TextAlign = ContentAlignment.MiddleLeft;
            notes_button.UseVisualStyleBackColor = false;
            notes_button.Click += notes_button_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tasks_button);
            panel3.Location = new Point(3, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 58);
            panel3.TabIndex = 2;
            // 
            // tasks_button
            // 
            tasks_button.BackColor = Color.Plum;
            tasks_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasks_button.Image = (Image)resources.GetObject("tasks_button.Image");
            tasks_button.ImageAlign = ContentAlignment.MiddleLeft;
            tasks_button.Location = new Point(0, -28);
            tasks_button.Name = "tasks_button";
            tasks_button.Padding = new Padding(30, 0, 0, 0);
            tasks_button.Size = new Size(278, 112);
            tasks_button.TabIndex = 2;
            tasks_button.Text = "             Tarefas";
            tasks_button.TextAlign = ContentAlignment.MiddleLeft;
            tasks_button.UseVisualStyleBackColor = false;
            tasks_button.Click += tasks_button_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(importants_button);
            panel4.Location = new Point(3, 378);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 58);
            panel4.TabIndex = 3;
            // 
            // importants_button
            // 
            importants_button.BackColor = Color.Plum;
            importants_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importants_button.Image = (Image)resources.GetObject("importants_button.Image");
            importants_button.ImageAlign = ContentAlignment.MiddleLeft;
            importants_button.Location = new Point(0, -28);
            importants_button.Name = "importants_button";
            importants_button.Padding = new Padding(30, 0, 0, 0);
            importants_button.Size = new Size(278, 112);
            importants_button.TabIndex = 2;
            importants_button.Text = "             Importantes";
            importants_button.TextAlign = ContentAlignment.MiddleLeft;
            importants_button.UseVisualStyleBackColor = false;
            importants_button.Click += importants_button_Click;
            // 
            // settingsContainer
            // 
            settingsContainer.BackColor = Color.SteelBlue;
            settingsContainer.Controls.Add(panel5);
            settingsContainer.Controls.Add(panel10);
            settingsContainer.Controls.Add(panel7);
            settingsContainer.Controls.Add(panel9);
            settingsContainer.Location = new Point(3, 442);
            settingsContainer.MaximumSize = new Size(275, 229);
            settingsContainer.MinimumSize = new Size(275, 60);
            settingsContainer.Name = "settingsContainer";
            settingsContainer.Size = new Size(275, 60);
            settingsContainer.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel8);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 58);
            panel5.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(config_button);
            panel8.Location = new Point(-6, -4);
            panel8.Name = "panel8";
            panel8.Size = new Size(289, 73);
            panel8.TabIndex = 3;
            // 
            // config_button
            // 
            config_button.BackColor = Color.Plum;
            config_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            config_button.Image = (Image)resources.GetObject("config_button.Image");
            config_button.ImageAlign = ContentAlignment.MiddleLeft;
            config_button.Location = new Point(6, -28);
            config_button.Name = "config_button";
            config_button.Padding = new Padding(30, 0, 0, 0);
            config_button.Size = new Size(287, 129);
            config_button.TabIndex = 2;
            config_button.Text = "             Configuração";
            config_button.TextAlign = ContentAlignment.MiddleLeft;
            config_button.UseVisualStyleBackColor = false;
            config_button.Click += config_button_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(settings_exit);
            panel10.Location = new Point(-6, 171);
            panel10.Name = "panel10";
            panel10.Size = new Size(284, 58);
            panel10.TabIndex = 4;
            // 
            // settings_exit
            // 
            settings_exit.BackColor = Color.Plum;
            settings_exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settings_exit.Image = (Image)resources.GetObject("settings_exit.Image");
            settings_exit.ImageAlign = ContentAlignment.MiddleLeft;
            settings_exit.Location = new Point(1, -28);
            settings_exit.Name = "settings_exit";
            settings_exit.Padding = new Padding(30, 0, 0, 0);
            settings_exit.Size = new Size(286, 110);
            settings_exit.TabIndex = 2;
            settings_exit.Text = "              Sair";
            settings_exit.TextAlign = ContentAlignment.MiddleLeft;
            settings_exit.UseVisualStyleBackColor = false;
            settings_exit.Click += settings_exit_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_profile);
            panel7.Location = new Point(0, 58);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 58);
            panel7.TabIndex = 5;
            // 
            // button_profile
            // 
            button_profile.BackColor = Color.Plum;
            button_profile.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_profile.Image = (Image)resources.GetObject("button_profile.Image");
            button_profile.ImageAlign = ContentAlignment.MiddleLeft;
            button_profile.Location = new Point(-6, -28);
            button_profile.Name = "button_profile";
            button_profile.Padding = new Padding(30, 0, 0, 0);
            button_profile.Size = new Size(284, 112);
            button_profile.TabIndex = 2;
            button_profile.Text = "              Perfil";
            button_profile.TextAlign = ContentAlignment.MiddleLeft;
            button_profile.UseVisualStyleBackColor = false;
            button_profile.Click += button_profile_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(theme_button);
            panel9.Location = new Point(0, 116);
            panel9.Name = "panel9";
            panel9.Size = new Size(275, 58);
            panel9.TabIndex = 3;
            // 
            // theme_button
            // 
            theme_button.BackColor = Color.Plum;
            theme_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            theme_button.Image = (Image)resources.GetObject("theme_button.Image");
            theme_button.ImageAlign = ContentAlignment.MiddleLeft;
            theme_button.Location = new Point(-3, -22);
            theme_button.Name = "theme_button";
            theme_button.Padding = new Padding(30, 0, 0, 0);
            theme_button.Size = new Size(281, 95);
            theme_button.TabIndex = 2;
            theme_button.Text = "             Tema";
            theme_button.TextAlign = ContentAlignment.MiddleLeft;
            theme_button.UseVisualStyleBackColor = false;
            theme_button.Click += theme_button_Click;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 9;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // Panel_Principal
            // 
            Panel_Principal.AutoScroll = true;
            Panel_Principal.BackColor = SystemColors.ControlLightLight;
            Panel_Principal.Controls.Add(theme_panel);
            Panel_Principal.Location = new Point(273, 34);
            Panel_Principal.MaximumSize = new Size(1127, 793);
            Panel_Principal.MinimumSize = new Size(941, 793);
            Panel_Principal.Name = "Panel_Principal";
            Panel_Principal.Size = new Size(946, 793);
            Panel_Principal.TabIndex = 1;
            Panel_Principal.Paint += Panel_Principal_Paint;
            // 
            // theme_panel
            // 
            theme_panel.BackColor = Color.WhiteSmoke;
            theme_panel.Controls.Add(purple_theme);
            theme_panel.Controls.Add(yellow_theme);
            theme_panel.Controls.Add(orange_theme);
            theme_panel.Controls.Add(green_theme);
            theme_panel.Controls.Add(pink_theme);
            theme_panel.Controls.Add(blue_theme);
            theme_panel.Location = new Point(3, 3);
            theme_panel.Name = "theme_panel";
            theme_panel.Size = new Size(216, 527);
            theme_panel.TabIndex = 0;
            theme_panel.Visible = false;
            // 
            // purple_theme
            // 
            purple_theme.BackColor = Color.Purple;
            purple_theme.Location = new Point(124, 261);
            purple_theme.Name = "purple_theme";
            purple_theme.Size = new Size(66, 62);
            purple_theme.TabIndex = 5;
            purple_theme.TabStop = false;
            purple_theme.Click += purple_theme_Click;
            // 
            // yellow_theme
            // 
            yellow_theme.BackColor = Color.Gold;
            yellow_theme.Location = new Point(16, 261);
            yellow_theme.Name = "yellow_theme";
            yellow_theme.Size = new Size(66, 62);
            yellow_theme.TabIndex = 4;
            yellow_theme.TabStop = false;
            yellow_theme.Click += yellow_theme_Click;
            // 
            // orange_theme
            // 
            orange_theme.BackColor = Color.DarkOrange;
            orange_theme.Location = new Point(124, 147);
            orange_theme.Name = "orange_theme";
            orange_theme.Size = new Size(66, 62);
            orange_theme.TabIndex = 3;
            orange_theme.TabStop = false;
            orange_theme.Click += orange_theme_Click;
            // 
            // green_theme
            // 
            green_theme.BackColor = Color.LimeGreen;
            green_theme.Location = new Point(16, 147);
            green_theme.Name = "green_theme";
            green_theme.Size = new Size(66, 62);
            green_theme.TabIndex = 2;
            green_theme.TabStop = false;
            green_theme.Click += green_theme_Click;
            // 
            // pink_theme
            // 
            pink_theme.BackColor = Color.HotPink;
            pink_theme.Location = new Point(124, 35);
            pink_theme.Name = "pink_theme";
            pink_theme.Size = new Size(66, 62);
            pink_theme.TabIndex = 1;
            pink_theme.TabStop = false;
            pink_theme.Click += pink_theme_Click;
            // 
            // blue_theme
            // 
            blue_theme.BackColor = Color.SteelBlue;
            blue_theme.Location = new Point(16, 35);
            blue_theme.Name = "blue_theme";
            blue_theme.Size = new Size(66, 62);
            blue_theme.TabIndex = 0;
            blue_theme.TabStop = false;
            blue_theme.Click += blue_theme_Click;
            // 
            // borderStylePanel
            // 
            borderStylePanel.BackColor = Color.DarkMagenta;
            borderStylePanel.Controls.Add(bttnMinimize_borderstyle);
            borderStylePanel.Controls.Add(bttnX_borderStyle);
            borderStylePanel.Location = new Point(0, -1);
            borderStylePanel.Name = "borderStylePanel";
            borderStylePanel.Size = new Size(1219, 28);
            borderStylePanel.TabIndex = 2;
            borderStylePanel.Paint += borderStylePanel_Paint;
            // 
            // bttnMinimize_borderstyle
            // 
            bttnMinimize_borderstyle.BackColor = Color.WhiteSmoke;
            bttnMinimize_borderstyle.FlatStyle = FlatStyle.Popup;
            bttnMinimize_borderstyle.Location = new Point(1112, 0);
            bttnMinimize_borderstyle.Name = "bttnMinimize_borderstyle";
            bttnMinimize_borderstyle.Size = new Size(41, 29);
            bttnMinimize_borderstyle.TabIndex = 3;
            bttnMinimize_borderstyle.Text = "—";
            bttnMinimize_borderstyle.UseVisualStyleBackColor = false;
            bttnMinimize_borderstyle.Click += bttnMinimize_borderstyle_Click;
            // 
            // bttnX_borderStyle
            // 
            bttnX_borderStyle.BackColor = Color.Red;
            bttnX_borderStyle.FlatStyle = FlatStyle.Popup;
            bttnX_borderStyle.Location = new Point(1159, 0);
            bttnX_borderStyle.Name = "bttnX_borderStyle";
            bttnX_borderStyle.Size = new Size(37, 29);
            bttnX_borderStyle.TabIndex = 0;
            bttnX_borderStyle.Text = "X";
            bttnX_borderStyle.UseVisualStyleBackColor = false;
            bttnX_borderStyle.Click += bttnX_borderStyle_Click;
            // 
            // settings_timer
            // 
            settings_timer.Interval = 9;
            settings_timer.Tick += settings_timer_Tick;
            // 
            // new_menu
            // 
            new_menu.ImageScalingSize = new Size(20, 20);
            new_menu.Items.AddRange(new ToolStripItem[] { novaNotaToolStripMenuItem, notaTarefaToolStripMenuItem });
            new_menu.Name = "contextMenuStrip1";
            new_menu.Size = new Size(156, 52);
            // 
            // novaNotaToolStripMenuItem
            // 
            novaNotaToolStripMenuItem.Name = "novaNotaToolStripMenuItem";
            novaNotaToolStripMenuItem.Size = new Size(155, 24);
            novaNotaToolStripMenuItem.Text = "Nova Nota";
            novaNotaToolStripMenuItem.Click += novaNotaToolStripMenuItem_Click;
            // 
            // notaTarefaToolStripMenuItem
            // 
            notaTarefaToolStripMenuItem.Name = "notaTarefaToolStripMenuItem";
            notaTarefaToolStripMenuItem.Size = new Size(155, 24);
            notaTarefaToolStripMenuItem.Text = "Nota Tarefa";
            notaTarefaToolStripMenuItem.Click += notaTarefaToolStripMenuItem_Click;
            // 
            // NoteApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1219, 831);
            ControlBox = false;
            Controls.Add(borderStylePanel);
            Controls.Add(Panel_Principal);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NoteApp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += NoteApp_Load;
            Paint += NoteApp_Paint;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_box).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NewNote).EndInit();
            panel_inicio.ResumeLayout(false);
            panel_inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilepicture).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            settingsContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            Panel_Principal.ResumeLayout(false);
            theme_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)purple_theme).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellow_theme).EndInit();
            ((System.ComponentModel.ISupportInitialize)orange_theme).EndInit();
            ((System.ComponentModel.ISupportInitialize)green_theme).EndInit();
            ((System.ComponentModel.ISupportInitialize)pink_theme).EndInit();
            ((System.ComponentModel.ISupportInitialize)blue_theme).EndInit();
            borderStylePanel.ResumeLayout(false);
            new_menu.ResumeLayout(false);
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
        private PictureBox menu_box;
        private System.Windows.Forms.Timer timerSidebar;
        private Panel panel6;
        private Label welcomeUser_label;
        private Label loginUser_label;
        private Label opcaoSair;
        private PictureBox NewNote;
        private FlowLayoutPanel Panel_Principal;
        private Panel borderStylePanel;
        private Button bttnX_borderStyle;
        private Panel settingsContainer;
        private Panel panel8;
        private Panel panel10;
        private Button settings_exit;
        private Panel panel9;
        private Button config_button;
        private Button theme_button;
        private Panel panel7;
        private Button button1;
        private System.Windows.Forms.Timer settings_timer;
        private ContextMenuStrip new_menu;
        private ToolStripMenuItem novaNotaToolStripMenuItem;
        private ToolStripMenuItem notaTarefaToolStripMenuItem;
        private Button bttnMinimize_borderstyle;
        private Panel theme_panel;
        private PictureBox blue_theme;
        private PictureBox green_theme;
        private PictureBox pink_theme;
        private Button button_profile;
        private PictureBox orange_theme;
        private PictureBox yellow_theme;
        private PictureBox purple_theme;
        internal CircularPictureBox profilepicture;
        private Panel panel_inicio;
    }
}