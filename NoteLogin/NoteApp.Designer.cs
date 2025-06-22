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
            NewNote = new PictureBox();
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            green_theme = new PictureBox();
            red_theme = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)NewNote).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)green_theme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)red_theme).BeginInit();
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
            Sidebar.MinimumSize = new Size(93, 873);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(278, 873);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(menu_box);
            panel1.Controls.Add(NewNote);
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
            // NewNote
            // 
            NewNote.Cursor = Cursors.Hand;
            NewNote.Image = (Image)resources.GetObject("NewNote.Image");
            NewNote.Location = new Point(230, 3);
            NewNote.Name = "NewNote";
            NewNote.Size = new Size(42, 40);
            NewNote.SizeMode = PictureBoxSizeMode.StretchImage;
            NewNote.TabIndex = 1;
            NewNote.TabStop = false;
            NewNote.Click += NewNote_Click;
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
            opcaoSair.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opcaoSair.ForeColor = Color.FromArgb(192, 0, 0);
            opcaoSair.Location = new Point(102, 65);
            opcaoSair.Name = "opcaoSair";
            opcaoSair.Size = new Size(34, 20);
            opcaoSair.TabIndex = 4;
            opcaoSair.Text = "Sair";
            opcaoSair.Click += opcaoSair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(102, 37);
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
            label1.Location = new Point(102, 12);
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
            notes_button.BackColor = Color.Plum;
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
            notes_button.Click += notes_button_Click;
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
            tasks_button.BackColor = Color.Plum;
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
            tasks_button.Click += tasks_button_Click;
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
            importants_button.BackColor = Color.Plum;
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
            // settingsContainer
            // 
            settingsContainer.BackColor = Color.SteelBlue;
            settingsContainer.Controls.Add(panel5);
            settingsContainer.Controls.Add(panel10);
            settingsContainer.Controls.Add(panel7);
            settingsContainer.Controls.Add(panel9);
            settingsContainer.Location = new Point(3, 367);
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
            config_button.Text = "          Configuração";
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
            settings_exit.Text = "          Sair";
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
            button_profile.Text = "          Perfil";
            button_profile.TextAlign = ContentAlignment.MiddleLeft;
            button_profile.UseVisualStyleBackColor = false;
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
            theme_button.Text = "          Tema";
            theme_button.TextAlign = ContentAlignment.MiddleLeft;
            theme_button.UseVisualStyleBackColor = false;
            theme_button.Click += theme_button_Click;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // Panel_Principal
            // 
            Panel_Principal.AutoScroll = true;
            Panel_Principal.BackColor = SystemColors.ControlLightLight;
            Panel_Principal.Controls.Add(theme_panel);
            Panel_Principal.Location = new Point(272, 34);
            Panel_Principal.Name = "Panel_Principal";
            Panel_Principal.Size = new Size(946, 793);
            Panel_Principal.TabIndex = 1;
            Panel_Principal.Paint += Panel_Principal_Paint;
            // 
            // theme_panel
            // 
            theme_panel.BackColor = Color.WhiteSmoke;
            theme_panel.Controls.Add(pictureBox4);
            theme_panel.Controls.Add(pictureBox3);
            theme_panel.Controls.Add(pictureBox1);
            theme_panel.Controls.Add(green_theme);
            theme_panel.Controls.Add(red_theme);
            theme_panel.Controls.Add(blue_theme);
            theme_panel.Location = new Point(3, 3);
            theme_panel.Name = "theme_panel";
            theme_panel.Size = new Size(216, 527);
            theme_panel.TabIndex = 0;
            theme_panel.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Purple;
            pictureBox4.Location = new Point(124, 261);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 62);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gold;
            pictureBox3.Location = new Point(16, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 62);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOrange;
            pictureBox1.Location = new Point(124, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            // red_theme
            // 
            red_theme.BackColor = Color.HotPink;
            red_theme.Location = new Point(124, 35);
            red_theme.Name = "red_theme";
            red_theme.Size = new Size(66, 62);
            red_theme.TabIndex = 1;
            red_theme.TabStop = false;
            red_theme.Click += red_theme_Click;
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
            ((System.ComponentModel.ISupportInitialize)NewNote).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)green_theme).EndInit();
            ((System.ComponentModel.ISupportInitialize)red_theme).EndInit();
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
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
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
        private PictureBox red_theme;
        private Button button_profile;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}