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
        Database db = new Database(); //DB connection
        Role[] roles; //Roles list

        public Settings()
        {
            InitializeComponent();

            lstEmployees.LoadData(db.ListEmployees()); //Populates the employee list

            PopulateRolesCb();
        }

        //Just... returns to the previous page...
        private void btnBack_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Home());
        }

        //Saves a new employee
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            CheckAvailability(tbUsername);
            SelectedRole(cbRole);

            //Checks if there is any error
            //If doesn't have errors, it will try to add the employee
            if (!lblUsernameError.Visible && !lblSelectRoleError.Visible)
                lblErrorInsertingUser.Visible = !db.AddEmployee(tbUsername.Text, roles[cbRole.SelectedIndex].Id);

            //If there is no error
            if (!lblErrorInsertingUser.Visible)
            {
                //Clear fields
                tbUsername.Text = null;
                cbRole.SelectedIndex = -1;

                lstEmployees.LoadData(db.ListEmployees()); //Repopulates the employee list
            }
        }

        //Saves a new role
        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            CheckAvailability(tbRoleName);

            //Checks if there is any error
            //If doesn't have errors, it will try to add the role
            if (!lblNewRoleError.Visible) lblErrorInsertingRole.Visible = !db.AddRole(tbRoleName.Text);

            //If there is no error
            if (!lblErrorInsertingRole.Visible)
            {
                //Clear field
                tbRoleName.Text = null;
                PopulateRolesCb(); //Repopulates the comboboxes
            }
        }

        //Removes a role
        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            SelectedRole(cbRemoveRole);

            lblErrorRemovingRole.Visible = db.IsRoleInUse(roles[cbRemoveRole.SelectedIndex].Id); //Checks if the role is in use by any employee.

            //Checks if there is any error
            if (!lblErrorRemovingRole.Visible)
                if (db.RemoveRole(roles[cbRemoveRole.SelectedIndex].Id)) //Removes the role and checks if it was successful
                    PopulateRolesCb(); //If removed, it updates the comboboxes
        }

        //Checks if there is a username and if it is already in use
        private void CheckAvailability(object sender, EventArgs e = null)
        {
            TextBox txtbx = (TextBox)sender; //Sets the object as a textbox
            string error;

            //Is empty?
            if (txtbx.Text.Trim().Length == 0)
                error = $"Please write a {txtbx.Tag.ToString().ToLower()}."; //Error message
            //Already Exists?
            else if (txtbx.Tag == "Username" && db.FindEmployee(txtbx.Text) ||
                     txtbx.Tag == "Role" && Array.Exists(roles, r => r.RoleName == txtbx.Text.Trim()))
                error = $"{txtbx.Tag} already exists."; //Error message
            else error = null; //No problemo boss

            //Displaying errors
            if (error == null)
            {
                lblUsernameError.Visible = false;
                lblNewRoleError.Visible = false;
            } else switch (txtbx.Tag)
            {
                case "Username":
                    lblUsernameError.Text = error;
                    lblUsernameError.Visible = true;
                    break;
                case "Role":
                    lblNewRoleError.Text = error;
                    lblNewRoleError.Visible = true;
                    break;
            }
        }

        //Displays error in case there is no selected role
        private void SelectedRole(object sender = null, EventArgs e = null)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Name == "cbRole") lblSelectRoleError.Visible = cb.SelectedIndex == -1;
            else if (cb.Name == "cbRemoveRole") lblRemoveRoleError.Visible = cb.SelectedIndex == -1;
        }

        //Populates both comboboxes of roles in the page
        private void PopulateRolesCb()
        {
            roles = db.ListRoles(); //Gets the available roles

            //Sorts the array instead of being the comboboxes sorting
            Array.Sort(roles, (aRole, bRole) => string.Compare(aRole.RoleName, bRole.RoleName, StringComparison.Ordinal));

            cbRole.Items.Clear();
            cbRemoveRole.Items.Clear();

            foreach (Role role in roles)
            {
                cbRole.Items.Add(role.RoleName); //Adds the roles to the "New Employee" combobox
                cbRemoveRole.Items.Add(role.RoleName); //Adds the roles to the "Remove Role" combobox
            }
        }
    }
}
