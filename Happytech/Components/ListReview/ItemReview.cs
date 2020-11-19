using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.databaseDataSetTableAdapters;
using PdfiumViewer;
using Happytech.Pages;
using System.IO;

namespace Happytech.Components.ListReview
{
    public partial class ItemReview : UserControl
    {
        Database db = new Database();

        public ItemReview(int ApplicationID)
        {
            InitializeComponent();

            // Set the name
            Name = ApplicationID.ToString();
            lblName.Text = db.FindApplicantName(ApplicationID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: MAKE DELETING WORK (too lazy at 3am)
            var result = MessageBox.Show("Are you sure you want to delete this application? This will also delete the CV.", "Delete application", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes)) 
            {
                try
                {
                    // Remove the CV, the reply if there is one and finally the application.
                    File.Delete($"{Directory.GetCurrentDirectory()}\\cv\\{db.FindCurriculumName(int.Parse(Name))}.pdf");
                    db.RemoveReply(int.Parse(Name));
                    db.RemoveApplication(int.Parse(Name));
                }
                catch(Exception ex)
                {
                    // TODO: Specific exception
                    MessageBox.Show(ex.Message);
                }

                // Delete the user from the list
                Dispose();
            }
        }

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            // Find the control where the PDF viewer is stored
            Control rootUserControl = Parent;
            while((rootUserControl.Name != "RepliedApplications"))
                rootUserControl = rootUserControl.Parent;

            // Render the pdf
            var app = (RepliedApplications)rootUserControl;
            app.OpenPDF(db.FindCurriculumName(int.Parse(Name)));
        }

        /// <summary>
        /// Changes the visibility of the buttons to the opposite state
        /// </summary>
        private void ItemClick(object sender, EventArgs e)
        {
            // TODO: SIMPLIFY THE CODE (Make it a method)
            switch (btnDelete.Visible)
            {
                case true: 
                    ApplicationSelected(false); 
                    break;
                case false:
                    // Unselect any other application
                    foreach (ItemReview application in Parent.Controls)
                        if (application.btnDelete.Visible)
                            application.ApplicationSelected(false);

                    // Enable this application's buttons
                    ApplicationSelected(true);
                    break;
            }
        }
        private void PointerHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(46, 56, 82);
        }

        private void PointerLeave(object sender, EventArgs e)
        {
            // If the button was not clicked (isn't active)
            if(!btnDelete.Visible)
                panel1.BackColor = Color.FromArgb(26, 36, 62);
        }

        /// <summary>
        /// Changes the application in the list to the selected one or not
        /// </summary>
        /// <param name="state">Application state</param>
        private void ApplicationSelected(bool state)
        {
            if (state)
            {
                btnDelete.Visible = true;
                btnCurriculum.Visible = true;
                btnApplication.Visible = true;
                panel1.BackColor = Color.FromArgb(46, 56, 82);
            }
            else
            {
                btnDelete.Visible = false;
                btnCurriculum.Visible = false;
                btnApplication.Visible = false;
                panel1.BackColor = Color.FromArgb(26, 36, 62);
            }
        }
    }



}
