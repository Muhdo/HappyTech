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
        private int tabsIndex = 1;
        private string nextTabText = "";
        TabPage tabSection2 = new TabPage();
        TabPage tabSection3 = new TabPage();
        TabPage tabSection4 = new TabPage();
        TabPage tabSection5 = new TabPage();
        private List<TabPage> tabs = new List<TabPage>();
        

        public TemplateSetup(string templateName)
        {
            InitializeComponent();
            lblTemplateName.Text = templateName;
            lblTemplateName.Visible = true;
            tabs.Add(tabSection2);
            tabs.Add(tabSection3);
            tabs.Add(tabSection4);
            tabs.Add(tabSection5);
            foreach (TabPage tab in tabs)
            {
                tabDesign(tab);
            }
        }

        public void tabDesign(TabPage tab)
        {
            nextTabText = "Section " + (tabs.IndexOf(tab) + 1);
            tab.BackColor = Color.FromArgb(39, 44, 74);
            tab.Text = nextTabText;
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
                tabSections.Controls.Remove(tabNew);
                try
                {
                    //add the next tab
                    tabSections.Controls.Add(tabs.ElementAt(tabsIndex));
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
