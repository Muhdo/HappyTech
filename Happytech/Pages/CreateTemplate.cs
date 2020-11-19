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
            Controls.Add(new HappyTech.Pages.TemplateSetup(templateName));
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
