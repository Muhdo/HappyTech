using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech;

namespace HappyTech.Pages
{
    public partial class Dashboard : UserControl
    {
        Database db = new Database();

        public Dashboard()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // Set label values
            lblWelcome.Text = $"Welcome back, {CurrentEmployee.Name}!";
            lblRepliedApplications.Text = db.QuantityRepliedApplications().ToString(); //Gets number of replied applications
            lblNewApplications.Text = db.FetchNewApplications().Rows.Count.ToString(); //Gets number of new applications
        }
    }
}
