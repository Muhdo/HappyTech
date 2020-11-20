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
        private int tabsIndex = 2;
        private string nextTabText = "";
        //private List<TabPage> tabs = new List<TabPage>();
        //TabPage tabSection2 = new TabPage();
        
        public TemplateSetup(string templateName)
        {
            InitializeComponent();
            lblTemplateName.Text = templateName;
            lblTemplateName.Visible = true;
        }

        //public void TabPage()
        //{

        //}

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
                nextTabText = "Section " + tabsIndex;
                tabSections.Controls.Remove(tabNew);
                try
                {
                    //add the next tab
                    tabSections.Controls.Add(new TabPage(nextTabText));
                }
                catch (Exception)
                {
                    //error you can't add more sections
                    throw;
                }
                tabsIndex++;
            }
            
        }
    }
}
