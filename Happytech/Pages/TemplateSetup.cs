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
        TabPage tabSection1 = new TabPage();
        TabPage tabSection2 = new TabPage();
        TabPage tabSection3 = new TabPage();
        TabPage tabSection4 = new TabPage();
        TabPage tabSection5 = new TabPage();
        private List<TabPage> tabs = new List<TabPage>();
        TextBox code1 = new TextBox();
        TextBox code2 = new TextBox();
        TextBox code3 = new TextBox();
        TextBox code4 = new TextBox();
        TextBox code5 = new TextBox();
        private List<TextBox> codes = new List<TextBox>();
        TextBox comment1 = new TextBox();
        TextBox comment2 = new TextBox();
        TextBox comment3 = new TextBox();
        TextBox comment4 = new TextBox();
        TextBox comment5 = new TextBox();
        private List<TextBox> comments = new List<TextBox>();

        public TemplateSetup(string templateName)
        {
            InitializeComponent();
            lblTemplateName.Text = templateName;
            lblTemplateName.Visible = true;
            tabs.Add(tabSection1);
            tabs.Add(tabSection2);
            tabs.Add(tabSection3);
            tabs.Add(tabSection4);
            tabs.Add(tabSection5);
            codes.Add(code1);
            codes.Add(code2);
            codes.Add(code3);
            codes.Add(code4);
            codes.Add(code5);
            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);
            comments.Add(comment4);
            comments.Add(comment5);
            foreach (TextBox code in codes)
            {
                codeDesign(code);
            }
            foreach (TextBox comment in comments)
            {
                commentDesign(comment);
            }
            foreach (TabPage tab in tabs)
            {
                tabDesign(tab);
            }
        }

        private void newTab(object sender, EventArgs e)
        {
            tabSections.Controls.Remove(tabNew);
            try
            {
                tabSections.Controls.Add(tabs.ElementAt(tabsIndex-1));
                //if there are still more allowed sections
                if(tabsIndex < 5)
                {
                    //add the ability to add a new tab
                    tabSections.Controls.Add(tabNew);
                }
            }
            catch (IndexOutOfRangeException)
            {
                lblMaxTabsError.Visible = true;
            }
            tabsIndex++;
        }

        public void tabDesign(TabPage tab)
        {
            nextTabText = "Section " + (tabs.IndexOf(tab) + 1);
            tab.BackColor = Color.FromArgb(39, 44, 74);
            tab.Text = nextTabText;
            //here will also go code for adding text boxes and stuff to the tabs
            TextBox sectionName = new TextBox();
            sectionName.Text = "Section name";
            sectionName.Location = new Point(23, 19);
            tab.Controls.Add(sectionName);
            Button addComment = new Button();
            addComment.Text = "Add Comment";
            addComment.BackColor = Color.FromArgb(39, 44, 74);
            addComment.FlatStyle = FlatStyle.Flat;
            addComment.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addComment.ForeColor = Color.FromArgb(213, 83, 217);
            addComment.Location = new Point(771, 19);
            addComment.Size = new Size(141, 31);
            tab.Controls.Add(addComment);
            addComment.Click += AddComment_Click;
        }

        private void AddComment_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //add the next code and comment in the list for that tab
        }

        private void codeDesign(TextBox code)
        {
            code.Text = "Code " + (codes.IndexOf(code) + 1);
            //code.Location = ?
        }
        private void commentDesign(TextBox comment)
        {
            comment.Text = "Comment...";
            comment.Multiline = true;
            //comment.Location = ?
        }

        private void btnBackPage(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Happytech.Pages.CreateTemplate());
        }
    }
}
