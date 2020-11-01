using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.Classes;

namespace Happytech.Pages
{
    public partial class Settings : UserControl
    {
        Database db = new Database();
        Role[] roles;

        public Settings()
        {
            InitializeComponent();

            roles = db.ListRoles(); //Gets the available roles

            lstEmployees.LoadData(db.ListEmployees()); //Populates the Employee list

            foreach (Role role in roles) cbRole.Items.Add(role.RoleName); //Adds the roles to the combobox
        }

        //Just... returns to the previous page...
        private void btnBack_Click(object sender, EventArgs e)
        {
            Panel window = (Panel)this.Parent; //Gets the main panel
            window.Controls.Clear(); //Clears every page in the main panel 

            window.Controls.Add(new Home()); //Sets the new page
        }

        //Saves a new employee
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            CheckUsername();
            SelectedRole();

            //Checks if there is any error
            //If doesn't have errors, it will try to add the employee
            if (!lblUsernameError.Visible && !lblSelectRoleError.Visible)
                lblErrorInsertingUser.Visible = !db.AddEmployee(tbUsername.Text, roles[cbRole.SelectedIndex].Id);

            if (!lblErrorInsertingUser.Visible)
            {
                tbUsername.Text = null;
                cbRole.SelectedIndex = -1;
            }
            
        }

        //Checks if there is a username and if it is already in use
        private void CheckUsername(object sender = null, EventArgs e = null)
        {
            bool visible = true;

            if (tbUsername.Text.Trim().Length == 0) //Is empty?
                lblUsernameError.Text = "Please write a username.";
            else if (db.FindEmployee(tbUsername.Text)) //Already Exists?
                lblUsernameError.Text = "Username already in use.";
            else visible = false; //No problemo boss

            lblUsernameError.Visible = visible;
        }

        //Displays error in case there is no selected role
        private void SelectedRole(object sender = null, EventArgs e = null) => lblSelectRoleError.Visible = cbRole.SelectedIndex == -1;
    }
}
