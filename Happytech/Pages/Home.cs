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
using Happytech.Properties;
using System.IO;

namespace Happytech.Pages
{
    public partial class Home : UserControl
    {
        Database db = new Database();
        public Home()
        {
            InitializeComponent();

            if (CurrentEmployee.IsAdmin) btnSettings.Visible = true;

            lblWelcome.Text = $"Welcome back, {CurrentEmployee.Name}!";

            lblRepliedApplications.Text = db.QuantityRepliedApplications().ToString(); //Gets number of replied applications
            lblNewApplications.Text = db.QuantityNewApplications().ToString(); //Gets number of new applications

            // Create curriculum folder if non existant
            var currentDirectory = Directory.GetCurrentDirectory();
            if(!Directory.Exists(currentDirectory + "/cv"))
                Directory.CreateDirectory(currentDirectory + "/cv");
        }

        private void ChangeWindow(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //Converts sender into a button
            Controls.Clear(); //Clears every page in the main panel 
            
            //Switches between the different possible pages
            switch (btn.Tag)
            {
                //Applications
                case "NewApplications": Controls.Add(new ViewApplications()); break;
                case "RepliedApplications": Controls.Add(new RepliedApplications()); break;
                case "AllApplications": Controls.Add(new ViewApplications()); break;
                case "ContinueReplying": Controls.Add(new ViewApplications()); break;
                //Templates
                case "ViewTemplates": Controls.Add(new ViewTemplates()); break;
                case "NewTemplate": Controls.Add(new CreateTemplate()); break;
                case "EditTemplates": Controls.Add(new ViewTemplates()); break;
                //Responses
                case "ViewResponses": Controls.Add(new ViewResponses()); break;
                case "SuccessfulApplicants": Controls.Add(new ViewResponses()); break;
                case "UnsuccessfulApplicants": Controls.Add(new ViewResponses()); break;
                case "WaitingResponse": Controls.Add(new ViewResponses()); break;
                //Settings
                case "Settings": Controls.Add(new Settings()); break;
            }

            UserPages.firstAction = btn.Tag.ToString(); //Sets the first action to perform when the page opens
        }
    }
}
