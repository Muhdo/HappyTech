using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.Classes;

namespace Happytech
{
    public partial class ApplyToPosition : Form
    {
        Database db = new Database();
        Role[] roles; //Roles list

        private string curriculumLocation = null;

        public ApplyToPosition()
        {
            InitializeComponent();

            roles = db.ListRoles(); //Gets the available roles

            //Sorts the array instead of being the comboboxes sorting
            Array.Sort(roles, (aRole, bRole) => string.Compare(aRole.RoleName, bRole.RoleName, StringComparison.Ordinal));

            foreach (Role role in roles) cbRole.Items.Add(role.RoleName); //Adds the roles to the combobox
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            fileDialogForm();
        }

        private void fileDialogForm()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = @"PDF (.pdf)|*.pdf|Word Files (.docx ,.doc)|*.docx;*.doc|All Files|*.docx;*.doc;*.pdf",
                Title = "Select your curriculum file",
                Multiselect = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    curriculumLocation = $"\"{dialog.FileName}\"";
                    lblFileName.Text = dialog.SafeFileName;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Security error.\n\nError message: {e.Message}\n\n" +
                                    $"Details:\n\n{e.StackTrace}");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            lblErrorName.Visible = CheckError(tbName);
            lblErrorEmail.Visible = CheckError(tbEmail);
            lblErrorPosition.Visible = SelectedRole();
            lblErrorCurriculum.Visible = curriculumLocation == null || !File.Exists(curriculumLocation);

            bool existsErrors = VisibleChanged();

            if (!existsErrors)
            {
                lblErrorSubmit.Visible = !db.ApplyToPosition(tbName.Text, tbEmail.Text, roles[cbRole.SelectedIndex].Id, curriculumLocation);

                if (!lblErrorSubmit.Visible)
                {
                    tbName.Text = null;
                    tbEmail.Text = null;
                    cbRole.SelectedIndex = -1;
                    lblFileName.Text = null;
                }
            }
        }

        //Checks if there is an error in the textboxes
        private bool CheckError(object sender, EventArgs e = null)
        {
            TextBox txtbx = (TextBox)sender; //Sets the object as a textbox
            bool error;

            //Is empty?
            if (txtbx.Text.Trim().Length == 0) error = true; //Oopsy Daisy there is an error bruh
            else if (!txtbx.Text.Contains("@") && txtbx.Tag == "Email") error = true; //Hey, we need to contact you...
            else error = false; //No problemo boss

            return error;
        }

        //Checks if there is any selected role
        private bool SelectedRole() => cbRole.SelectedIndex == -1; //Error if nothing is selected

        private bool VisibleChanged()
        {
            if (lblErrorName.Visible || lblErrorEmail.Visible || lblErrorPosition.Visible || lblErrorCurriculum.Visible)
                return true;
            
            return false;
        }
    }
}
