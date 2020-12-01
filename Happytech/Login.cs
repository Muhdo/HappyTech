using Happytech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class Login : Form
    {
        Database db = new Database();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verify if fields are not empty
            if(string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Some fields are empty!", "Fields empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(db.Login(tbUsername.Text, tbPassword.Text))
            {
                Main mainProgram = new Main();
                mainProgram.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Text = null;
                tbUsername.Text = null;
            }
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimizeApplication_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
