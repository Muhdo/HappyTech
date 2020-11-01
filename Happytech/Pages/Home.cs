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

namespace Happytech.Pages
{
    public partial class Home : UserControl
    {
        Database db = new Database();
        public Home()
        {
            InitializeComponent();

            if (CurrentEmployee.Id == 0) btnSettings.Visible = true;

            lblWelcome.Text = $"Welcome back, {CurrentEmployee.Name}!";

            lblRepliedApplications.Text = db.QuantityRepliedApplications().ToString(); //Gets number of replied applications
            lblNewApplications.Text = db.QuantityNewApplications().ToString(); //Gets number of new applications
        }

        private void ChangeWindow(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //Converts sender into a button
            Panel window = (Panel) this.Parent;
            window.Controls.Clear(); //Clears every page in the main panel 
            
            //Switches between the different possible pages
            switch (btn.Tag)
            {
                //Applications
                case "NewApplications": window.Controls.Add(new ViewApplications()); break;
                case "RepliedApplications": window.Controls.Add(new ViewApplications()); break;
                case "AllApplications": window.Controls.Add(new ViewApplications()); break;
                case "ContinueReplying": window.Controls.Add(new ViewApplications()); break;
                //Templates
                case "ViewTemplates": window.Controls.Add(new ViewTemplates()); break;
                case "NewTemplate": window.Controls.Add(new ViewTemplates()); break;
                case "EditTemplates": window.Controls.Add(new ViewTemplates()); break;
                //Responses
                case "ViewResponses": window.Controls.Add(new ViewResponses()); break;
                case "SuccessfulApplicants": window.Controls.Add(new ViewResponses()); break;
                case "UnsuccessfulApplicants": window.Controls.Add(new ViewResponses()); break;
                case "WaitingResponse": window.Controls.Add(new ViewResponses()); break;
                //Settings
                case "Settings": window.Controls.Add(new Settings()); break;
            }

            UserPages.firstAction = btn.Tag.ToString(); //Sets the first action to perform when the page opens
        }
    }
}
