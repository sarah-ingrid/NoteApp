using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace NoteLogin
{

    public partial class NoteApp : Form
    {
        public int UserID;

        public NoteApp(int UserID)
        {
            InitializeComponent();

            this.UserID = UserID;


            FormsBorder.EnabbleDrag(this.borderStylePanel, this);

            currentButtonColor = notes_button.BackColor;
        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            FormsBorder.SetRegion(this, borderRadius);

            string nome = "";
            string username = "";
            string picture = "";

            try
            {
                using var conexao = DataBase.ConexaoBanco();
                {
                    string query = "SELECT T_NOME, T_username, FOTO_PERFIL FROM tb_users WHERE User_ID = @UserDI";
                    using var comando = new SQLiteCommand(query, conexao);
                    {
                        comando.Parameters.AddWithValue("@UserDI", UserID);

                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nome = reader.GetString(0);
                                nome = nome.Split(' ')[0];
                                welcomeUser_label.Text = $"Olá, {nome}!";

                                username = reader.GetString(1);
                                loginUser_label.Text = username;

                                if (!reader.IsDBNull(2))
                                {
                                    picture = reader.GetString(2);
                                    if (!string.IsNullOrEmpty(picture) && File.Exists(picture))
                                        profilepicture.Image = Image.FromFile(picture);
                                    else
                                        profilepicture.Image = Properties.Resources.default_picture_profile;
                                }
                                else
                                    profilepicture.Image = Properties.Resources.default_picture_profile;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERRO AO COLOCAR O NOME DO USUÁRIO NA LABEL DE MENU", exc.Message);
            }




            int temaSalvo = new UserRepository().GetSavedTheme(UserID);
            ApplyThemeByNumber(temaSalvo, UserID);
        }



        bool sidebarOpen;
        bool settingsOpen;
        bool panelEditorOpen = false;

        bool IsImportant;

        Color currentButtonColor;
        Color clickButtonColor;
        bool clickColor = false;
        int temaSalvo = 1;

        // campos de borda
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(255, 255, 255);





        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarOpen)
            {
                Sidebar.Width -= 10;
                Panel_Principal.Width += 10;
                Panel_Principal.Location = new Point(Panel_Principal.Location.X - 10, Panel_Principal.Location.Y);
                if (Sidebar.Width <= Sidebar.MinimumSize.Width || Panel_Principal.Width >= Panel_Principal.MaximumSize.Width)
                {
                    sidebarOpen = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                Panel_Principal.Width -= 10;
                Panel_Principal.Location = new Point(Panel_Principal.Location.X + 10, Panel_Principal.Location.Y);

                if (Sidebar.Width >= Sidebar.MaximumSize.Width)
                {
                    sidebarOpen = true;
                    timerSidebar.Stop();
                }

            }
        }

        private void menu_box_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void opcaoSair_Click(object sender, EventArgs e)
        {
            LoginForm telaLogin = new LoginForm();

            if (MessageBox.Show("Deseja realmente sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                telaLogin.Show();
                this.Close();
            }




        }

        /// //////////////////////////////////////////////////////// 
        private void NewNote_Click(object sender, EventArgs e)
        {
            new_menu.Show(NewNote, 1, NewNote.Height);
        }


        private void novaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEditorOpen = !panelEditorOpen;

            if (panelEditorOpen)
            {
                panel_editor.Visible = true;
                panel_editor.BringToFront();

                panel_editor.Controls.Add(new Editor());
            }
            else
            {
                panel_editor.Visible = false;
                panel_editor.SendToBack();
            }



        }


        private void notaTarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else
            {
                CreateTasks criarNovaTarefa = new CreateTasks(UserID);
                ShowUserControl(criarNovaTarefa);
            }
        }

        private void timer_editorPanel_Tick(object sender, EventArgs e)
        {

            /*   if (isOppening)
               {

                   panel_editor.Width += 10;
                   panel_editor.Location = new Point(panel_editor.Location.X - 10, panel_editor.Location.Y);
                   panel_editor.Visible = true;
                   if (panel_editor.Width >= panel_editor.MaximumSize.Width)
                   {
                      // panel_editor.Width = panel_editor.MaximumSize.Width;
                       panelEditorOpen = true;
                       timer_editorPanel.Stop();
                   }
               }
               else
               {
                   panel_editor.Width -= 10;
                   panel_editor.Location = new Point(panel_editor.Location.X + 10, panel_editor.Location.Y);

                   if (panel_editor.Width <= panel_editor.MaximumSize.Width)
                   {
                       //  panel_editor.Width = panel_editor.MinimumSize.Width;
                       panel_editor.Visible = false;
                       panelEditorOpen = false;
                       timer_editorPanel.Stop();
                   }

               }*/

        }

        private void NoteApp_Paint(object sender, PaintEventArgs e)
        {
            /* e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
             FormsBorder.FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize, true);*/
            FormsBorder.DrawBorder(this, borderRadius, e.Graphics, borderColor, borderSize);


        }


        private void notes_button_Click(object sender, EventArgs e)
        {

            clickColor = !clickColor;
            notes_button.BackColor = clickColor ? currentButtonColor : clickButtonColor;

            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else
            {

                CarregarItensNoPainel<NoteView>(
                    UserID,
                    "tb_notes",
                    false,
                    false,
                    reader =>
                    {
                        var note = new NoteView();
                        note.IDNote = reader.GetInt32(0);
                        note.Title = reader.GetString(1);
                        note.Message = reader.GetString(2);
                        note.Important = reader.GetBoolean(3);
                        note.UpdateStarImage();

                        note.Click += (s, e) =>
                        {
                          //  panel_editor.Visible = true;
                          //  panel_editor.BringToFront();
                            CarregarItemNoEditor(note.IDNote, "tb_notes");
                        };


                        return note;
                    },
                    temImportancia: true
                );
            }

        }

        private void tasks_button_Click(object sender, EventArgs e)
        {
            clickColor = !clickColor;
            tasks_button.BackColor = clickColor ? currentButtonColor : clickButtonColor;

            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else
                CarregarItensNoPainel<TasksView>(
                    UserID,
                    "tb_tasks",
                    false,
                    true,
                    reader =>
                    {
                        var task = new TasksView();
                        task.Message = reader.GetString(0);
                        return task;
                    },
                    temImportancia: false
                );
        }

        private void importants_button_Click(object sender, EventArgs e)
        {
            clickColor = !clickColor;
            importants_button.BackColor = clickColor ? currentButtonColor : clickButtonColor;

            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else

                CarregarItensNoPainel<NoteView>(
                    UserID,
                    "tb_notes",
                    true,
                    false,
                    CreateNoteView,
                    temImportancia: true
                    );

            /*CarregarItensNoPainel<NoteView>(
                UserID,
                "tb_notes",
                true,
                false,
                reader =>
                {
                    var note = new NoteView();
                    note.IDNote = reader.GetInt32(0);
                    note.Title = reader.GetString(1);
                    note.Message = reader.GetString(2);
                    note.Important = reader.GetBoolean(3);
                    note.UpdateStarImage();
                    return note;
                },
                temImportancia: true
            );*/
        }

        private NoteView CreateNoteView(SQLiteDataReader reader)
        {
            var note = new NoteView();
            note.IDNote = reader.GetInt32(0);
            note.Title = reader.GetString(1);
            note.Message = reader.GetString(2);
            note.Important = reader.GetBoolean(3);
            note.UpdateStarImage();



            return note;
        }

        private void config_button_Click(object sender, EventArgs e)
        {
            clickColor = !clickColor;
            config_button.BackColor = clickColor ? currentButtonColor : clickButtonColor;

            settings_timer.Start();

            if (settingsOpen == true && theme_panel.Visible == true)
                theme_panel.Visible = false;
        }

        private void settings_timer_Tick(object sender, EventArgs e)
        {
            if (settingsOpen)
            {
                settingsContainer.Height -= 10;
                if (settingsContainer.Height <= settingsContainer.MinimumSize.Height)
                {
                    settingsOpen = false;
                    settings_timer.Stop();
                }
            }
            else
            {
                settingsContainer.Height += 10;
                if (settingsContainer.Height >= settingsContainer.MaximumSize.Height)
                {
                    settingsOpen = true;
                    settings_timer.Stop();
                }

            }
        }

        private void settings_exit_Click(object sender, EventArgs e)
        {

            LoginForm telaLogin = new LoginForm();

            if (MessageBox.Show("Deseja realmente sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                telaLogin.Show();
                this.Close();
            }
        }


        ///// Garantir que o arredondamento funcione corretamente em qualquer mudança de tamanho ou estado /////
        private void NoteApp_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void NoteApp_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void NoteApp_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void theme_button_Click(object sender, EventArgs e)
        {
            clickColor = !clickColor;
            theme_button.BackColor = clickColor ? currentButtonColor : clickButtonColor;

            theme_panel.Visible = !theme_panel.Visible;

            if (theme_panel.Visible)
            {
                if (!Panel_Principal.Controls.Contains(theme_panel))
                {
                    Panel_Principal.Controls.Add(theme_panel);
                }

                theme_panel.BringToFront();
                theme_panel.Invalidate();

            }

            Panel_Principal.Refresh();

        }

        private void bttnX_borderStyle_Click(object sender, EventArgs e)
        {
            /* LoginForm telaLogin = new LoginForm();
             this.Hide();
             telaLogin.Show();
             this.Close();*/
            Application.Exit();
        }

        private void blue_theme_Click(object sender, EventArgs e)
        {
            ApplyThemeByNumber(1, UserID);
            new UserRepository().SaveThemeColor(1, UserID);
        }

        private void pink_theme_Click(object sender, EventArgs e)
        {
            ApplyThemeByNumber(2, UserID);
            new UserRepository().SaveThemeColor(2, UserID);
        }

        private void green_theme_Click(object sender, EventArgs e)
        {
            ApplyThemeByNumber(3, UserID); // ou Honeydew
            new UserRepository().SaveThemeColor(3, UserID);
        }

        private void orange_theme_Click(object sender, EventArgs e)
        {
            ApplyThemeByNumber(4, UserID);
            new UserRepository().SaveThemeColor(4, UserID);
        }

        private void yellow_theme_Click(object sender, EventArgs e)
        {
            ApplyThemeByNumber(5, UserID);
            new UserRepository().SaveThemeColor(5, UserID);
        }

        private void purple_theme_Click(object sender, EventArgs e)
        {
            ApplyThemeByNumber(6, UserID);
            new UserRepository().SaveThemeColor(6, UserID);
        }

        private void bttnMinimize_borderstyle_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void borderStylePanel_Paint(object sender, PaintEventArgs e)
        {

        }




        private void ShowUserControl(UserControl uc)
        {
            uc.Width = Panel_Principal.ClientSize.Width;
            uc.Height = Panel_Principal.ClientSize.Height;
            uc.Margin = new Padding(0);

            Panel_Principal.Controls.Add(uc);
        }

        public void ChangeColorTheme(Color panelColor, Color buttonsColor, Color clickColor, int themeNumber, int UserID)
        {
            currentButtonColor = buttonsColor;
            clickButtonColor = clickColor;

            Sidebar.BackColor = panelColor;
            borderStylePanel.BackColor = panelColor;

            notes_button.BackColor = buttonsColor;
            tasks_button.BackColor = buttonsColor;
            importants_button.BackColor = buttonsColor;
            config_button.BackColor = buttonsColor;

            button_profile.BackColor = buttonsColor;
            theme_button.BackColor = buttonsColor;
            settings_exit.BackColor = buttonsColor;
            panel_inicio.BackColor = buttonsColor;

            // Salva no banco o número do tema
            var repo = new UserRepository();
            repo.SaveThemeColor(themeNumber, UserID);

        }

        private void ApplyThemeByNumber(int tema, int UserID)
        {
            switch (tema)
            {
                case 1:
                    ChangeColorTheme(Color.SteelBlue, Color.LightSteelBlue, Color.AliceBlue, tema, UserID);
                    break;
                case 2:
                    ChangeColorTheme(Color.HotPink, Color.LavenderBlush, Color.MistyRose, tema, UserID);
                    break;
                case 3:
                    ChangeColorTheme(Color.LimeGreen, Color.LightGreen, Color.PaleGreen, tema, UserID);
                    break;
                case 4:
                    ChangeColorTheme(Color.DarkOrange, Color.PeachPuff, Color.AntiqueWhite, tema, UserID);
                    break;
                case 5:
                    ChangeColorTheme(Color.Gold, Color.LightGoldenrodYellow, Color.Khaki, tema, UserID);
                    break;
                case 6:
                    ChangeColorTheme(Color.DarkMagenta, Color.Plum, Color.Thistle, tema, UserID);
                    break;
            }

        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(UserID, this);
            profile.Show();
        }

        private void NoteApp_Resize(object sender, EventArgs e)
        {
            FormsBorder.SetRegion(this, borderRadius);
            this.Invalidate();
        }

        private void new_menu_Opening(object sender, CancelEventArgs e)
        {
             FormsBorder.SetRegion(new_menu, 15);
        }





        private void CarregarItensNoPainel<T>(int UserID, string tabela, bool somenteImportantes, bool isTask,
            Func<SQLiteDataReader, T> criarControle, bool temImportancia = false) where T : UserControl
        {
            Panel_Principal.Controls.Clear();

            using (var conexao = DataBase.ConexaoBanco())
            {
                string query;

                if (isTask)
                    query = "SELECT TEXTO"; // id tasks

                else
                    query = "SELECT ID_note, TITULO, TEXTO";

                if (temImportancia)
                    query += ", IsImportant";

                query += $" FROM {tabela} WHERE ID_Users = @id";

                if (somenteImportantes)
                    query += " AND IsImportant = 1";

                using (var comando = new SQLiteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", UserID);

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = criarControle(reader);
                            Panel_Principal.Controls.Add(item);
                        }
                    }
                }
            }
        }


        int notaAbertaID = -1;
        int taskAbertaID = -1;

        public int CurrentIDNote 
        {
            get { return notaAbertaID; }
            set { notaAbertaID = value; }
        }
        public int CurrentTaskID
        {
            get { return taskAbertaID; }
            set { taskAbertaID = value; }
        }


        public void CarregarItemNoEditor(int idNota, string tabela)
        {
            if (panel_editor.Visible && notaAbertaID == idNota)
            {
                panel_editor.Controls.Clear();
                panel_editor.Visible = false;
                notaAbertaID = -1;
                return;
            }

            // Se clicar em outra nota (ou nenhuma aberta -1) abre e carrega ela
            panel_editor.Visible = true;
            panel_editor.BringToFront();
            panel_editor.Controls.Clear();

            using (var conexao = DataBase.ConexaoBanco())
                {
                    string query = $"SELECT TITULO, TEXTO FROM {tabela} WHERE ID_note = @id";

                    using (var comando = new SQLiteCommand(query, conexao))
                    {

                        comando.Parameters.AddWithValue("@id", idNota);

                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string titulo = reader.GetString(0);
                                string texto = reader.GetString(1);

                                Editor editor = new Editor();
                                editor.IDNote = idNota;
                                editor.Title = titulo;
                                editor.Message = texto;
                                editor.noteApp = this;


                            panel_editor.Controls.Clear();
                                panel_editor.Controls.Add(editor);
                                editor.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum item encontrado para carregar no editor.");
                            }
                        }
                    }
                    CurrentIDNote = idNota;
                }
            
        }


        // Serve para obrescreve parâmetros para melhorar o desempenho do desenho da interface
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }

        }


    }
}
