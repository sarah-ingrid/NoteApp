using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteLogin
{
    public partial class NoteApp : Form
    {
        bool sidebarOpen;


        public NoteApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NoteApp_Load(object sender, EventArgs e)
        {

        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarOpen)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width <= Sidebar.MinimumSize.Width)
                {
                    sidebarOpen = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
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

        private void user_welcome_Click(object sender, EventArgs e)
        {

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
    }
}
