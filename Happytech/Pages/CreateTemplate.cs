using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happytech.Pages
{
    public partial class CreateTemplate : UserControl
    {
        Database db = new Database();

        public CreateTemplate()
        {
            InitializeComponent();
        }

        private void backHome(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Home());
        }

        private void templateSetUp(string templateName)
        {
            Controls.Clear();
            Label lblTemplateName = new Label();
            lblTemplateName.Text = templateName;
            lblTemplateName.ForeColor = Color.FromArgb(213, 83, 127);
            lblTemplateName.Name = "lblTemplateName";
            lblTemplateName.Font = new Font("Segoe UI", 36F);
            lblTemplateName.AutoSize = true;
            //figuring out where the label should be positioned so it's central
            int halfwidth = (int)Math.Round((decimal)Width / 2);
            int halfTextWidth = (int)Math.Round((decimal)lblTemplateName.Width / 2);
            int x = halfwidth - halfTextWidth;
            lblTemplateName.Location = new Point(x, 20);
            Controls.Add(lblTemplateName);
        }

        private void setTemplateName(object sender, EventArgs e)
        {
            if(txtTemplateName.Text == "")
            {
                lblNoNameError.Visible = true;
            }
            else
            {
                string templateName = txtTemplateName.Text;
                templateSetUp(templateName);
            }
        }
    }
}
