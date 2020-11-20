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
        private int nextSectionNumber = 2;
        private string nextTabText = "";
        
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

        //Something's a little bit broken but I'm not sure what
        private void newTab(object sender, EventArgs e)
        {
            //condition should check if it was tabNew that was clicked
            if (true)
            {
                nextTabText = "Section " + nextSectionNumber;
                tabSections.Controls.Remove(tabNew);
                tabSections.Controls.Add(new TabPage(nextTabText));
                nextSectionNumber++; 
            }
            
        }
    }
}
