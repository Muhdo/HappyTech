using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech.Pages
{
    public partial class TemplateSetup : UserControl
    {
        
        public TemplateSetup(string templateName)
        {
            InitializeComponent();
            lblTemplateName.Text = templateName;
            lblTemplateName.Visible = true;
        }

        private void btnBackPage(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Happytech.Pages.CreateTemplate());
        }
    }
}
