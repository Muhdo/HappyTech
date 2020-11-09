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
            //db.RemoveReply(ReplyID);
            Dispose();
        }

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            // Find the control where the PDF viewer is stored
            Control rootUserControl = Parent;
            while((rootUserControl.Name != "RepliedApplications"))
            {
                rootUserControl = rootUserControl.Parent;
            }

            // Render the pdf
            var app = (RepliedApplications)rootUserControl;
            app.OpenPDF(db.FindCurriculumName(int.Parse(Name)));
        }
    }



}
