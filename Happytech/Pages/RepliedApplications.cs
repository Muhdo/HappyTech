using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.Components.ListReview;
using System.Windows.Controls;
using System.IO;
using PdfiumViewer;
using HappyTech.Pages;
using Happytech.Classes;

namespace Happytech.Pages
{
    public partial class RepliedApplications : System.Windows.Forms.UserControl
    {
        System.Windows.Forms.Panel pWindow;
        ApplyToPosition ApplyForm; // Used as to know if there's one open already
        ListReview ListReview;
        Database db = new Database();

        public RepliedApplications()
        {
            InitializeComponent();
            pWindow = (System.Windows.Forms.Panel)Parent;
            Dock = DockStyle.Fill;

            // Insert all roles onto the roles dropdown menu
            Role[] roles = db.ListRoles();

            // The cb index will be indicative of the role ID, e.g If the RoleID is 4, the dropdown menu index will be 4 as well.
            foreach (var role in roles)
                cbRolesList.Items.Insert(role.RoleId, role.RoleName);

            // Set default index for the filter dropdown menu
            cbApplicationList.SelectedIndex = 0;

            // Initialize the applications list
            ListReview = new ListReview();
            ListReview.Dock = DockStyle.Fill;
            grpApplications.Controls.Add(ListReview);

            // Set default index for the roles dropdown menu
            cbRolesList.SelectedIndex = 0;


            // Configure PDF Reader
            pdfReader.ShowBookmarks = false;
            pdfReader.ZoomMode = PdfViewerZoomMode.FitBest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Refresh List
            ListReview.RefreshList(cbApplicationList.SelectedIndex, cbRolesList.SelectedIndex);
        }

        private void cbApplicationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListReview == null)
                return;

            // Set name of GroupBox to selected filter
            grpApplications.Text = cbApplicationList.Text;

            // Refresh the list
            ListReview.RefreshList(cbApplicationList.SelectedIndex, cbRolesList.SelectedIndex);
        }

        public void OpenPDF(string name)
        {
            try
            {
                // Set path and use the in the DB as the name for the .pdf
                byte[] bytes = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\cv\\{name}.pdf");
                var stream = new MemoryStream(bytes);
                PdfDocument pdf = PdfDocument.Load(stream);
                pdfReader.Document = pdf;
            }
            catch(FileNotFoundException)
            {
                // This happens if the file is not in the CV folder
                MessageBox.Show($"The applicants CV must be stored inside {Directory.GetCurrentDirectory()}\\cv");
            }
            catch(Exception ex)
            {
                MessageBox.Show("We don't know what happened, error message: " + ex.Message);
            }

        }
        private void ReturnHome(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Home());
        }

        private void btnInsertApplication_Click(object sender, EventArgs e)
        {
            var parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new ApplyPosition());
        }

        private void cbRolesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListReview == null)
                return;

            // Refresh the list
            ListReview.RefreshList(cbApplicationList.SelectedIndex, cbRolesList.SelectedIndex);
        }

        public void SetReviewingListLabelText(string text)
        {
            lblReviewList.Text = text;
        }
    }
}
