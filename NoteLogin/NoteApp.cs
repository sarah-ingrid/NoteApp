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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace NoteLogin
{

    public partial class NoteApp : Form
    {
        bool sidebarOpen;
        bool settingsOpen;

        // campos de borda
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(255, 255, 255);


        private void ShowUserControl(UserControl uc)
        {
            uc.Width = Panel_Principal.ClientSize.Width;
            uc.Height = Panel_Principal.ClientSize.Height;

            uc.Margin = new Padding(0);

            Panel_Principal.Controls.Add(uc);
        }

        public void ChangeColorTheme(Color panelColor, Color buttonsColor)
        {
            Sidebar.BackColor = panelColor;
            borderStylePanel.BackColor = panelColor;

            notes_button.BackColor = buttonsColor;
            tasks_button.BackColor = buttonsColor;
            importants_button.BackColor = buttonsColor;
            config_button.BackColor = buttonsColor;

            button_profile.BackColor = buttonsColor;
            theme_button.BackColor = buttonsColor;
            settings_exit.BackColor = buttonsColor;

            // adicionar um novo para quando clicar nas opções

        }


  

        private int UserID;
        bool IsImportant;
        public NoteApp(int UserID)
        {
            InitializeComponent();

            this.UserID = UserID;

   
            // this.FormBorderStyle = FormBorderStyle.None;
            // this.Padding = new Padding(borderSize);
            //   this.panelTitleBar.BackColor = borderColor;
            //this.BackColor = borderColor;

            FormsBorder.EnabbleDrag(this.borderStylePanel, this);
        }

        private void CarregarItensNoPainel<T>(int UserID, string tabela, bool somenteImportantes,
            Func<SQLiteDataReader, T> criarControle, bool temImportancia = false) where T : UserControl
        {
            Panel_Principal.Controls.Clear();

            using (var conexao = DataBase.ConexaoBanco())
            {
                string query = "SELECT ID_note, TITULO, TEXTO";

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

   /*     public bool VerificarSeImportante(int IDUser)
        {
            using (var conexao = DataBase.ConexaoBanco())
            {
                string query = $"SELECT ID_note FROM tb_notes WHERE ID_Users = {IDUser} AND IsImportant = 1";

                using (var comando = new SQLiteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@ID_Users", IDUser);

                    object resposta = comando.ExecuteScalar();
                    if (resposta != null && resposta != DBNull.Value)
                    {
                        return resposta;
                    }
                    else

                        return 0;
                }
            }
        }*/

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

        private void createNote1_Load(object sender, EventArgs e)
        {

        }

        /// //////////////////////////////////////////////////////// 
        private void NewNote_Click(object sender, EventArgs e)
        {
            new_menu.Show(NewNote, 1, NewNote.Height);
        }

        private void novaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else
            {
                CreateNote criarNovaNota = new CreateNote(UserID);
                ShowUserControl(criarNovaNota);
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

        private void NoteApp_Paint(object sender, PaintEventArgs e)
        {
            // FormsBorder.DrawFormBorder(this, e.Graphics, this.borderRadius);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            FormsBorder.FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);

        }

        // ****************************************** VER AQUI DPS
        private void Panel_Principal_Paint(object sender, PaintEventArgs e)
        {
            //  FormsBorder.ControlRegionAndBorder(Panel_Principal, borderRadius, e.Graphics, Color.Transparent);
        }

        private void notes_button_Click(object sender, EventArgs e)
        {
            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else
                CarregarItensNoPainel<NoteView>(
                    UserID,
                    "tb_notes",
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
                );
        }

        private void tasks_button_Click(object sender, EventArgs e)
        {
            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else
                CarregarItensNoPainel<TasksView>(
                    UserID,
                    "tb_tasks",
                    false,
                    reader =>
                    {
                        var task = new TasksView();
                        task.Message = reader.GetString(1);
                        return task;
                    },
                    temImportancia: false
                );
        }

        private void importants_button_Click(object sender, EventArgs e)
        {
            if (Panel_Principal.Controls.Count > 0)
            {
                Panel_Principal.Controls.Clear();
            }
            else
                CarregarItensNoPainel<NoteView>(
                    UserID,
                    "tb_notes",
                    true,
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
                );
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

        private void config_button_Click(object sender, EventArgs e)
        {
            settings_timer.Start();

            if (settingsOpen == true && theme_panel.Visible == true)
                theme_panel.Visible = false;
        }


        // invalida a area do formulario que esta agora para que eu possa fazer as mudanças
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
            theme_panel.Visible = !theme_panel.Visible;

            if (theme_panel.Visible)
            {

                theme_panel.BringToFront();


            }

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
            ChangeColorTheme(Color.SteelBlue, Color.LightSteelBlue);
        }

        private void red_theme_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(Color.HotPink, Color.LavenderBlush);
        }

        private void green_theme_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(Color.LimeGreen, Color.LightGreen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(Color.DarkOrange, Color.PeachPuff);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(Color.Gold, Color.LightGoldenrodYellow);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(Color.DarkMagenta, Color.Plum);
        }

        private void bttnMinimize_borderstyle_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        // criando a permissão para MINIMIZAR (pq tirei essa permissão mandando border.none)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }
        //// DEPOIS VER COMO INCULIR ISSO EM TODOS


    }
}
