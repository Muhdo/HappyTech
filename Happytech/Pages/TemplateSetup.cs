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
    public partial class TemplateSetup : UserControl
    {
        Database db = new Database();

        private int tabsIndex = 1;
        private string nextTabText = "";
        TabPage tabSection1 = new TabPage();
        TabPage tabSection2 = new TabPage();
        TabPage tabSection3 = new TabPage();
        TabPage tabSection4 = new TabPage();
        TabPage tabSection5 = new TabPage();
        private List<TabPage> tabs = new List<TabPage>();
        //names of the code text boxes that will be used
        string[] codeNames = new string[5] { "txtCode1", "txtCode2", "txtCode3", "txtCode4", "txtCode5" };
        //y positions for the codes
        int[] codeYs = new int[5] {55, 172, 286, 400, 514 };
        //names of the comment text boxes that will be used
        string[] commentNames = new string[5] { "txtComment1", "txtComment2", "txtComment3", "txtComment4", "txtComment5" };
        //y positions for the comments
        int[] commentYs = new int[5] { 93, 207, 321, 435, 549 };
        //array storing how many codes have been added to each section
        int[] sectionCodes = new int[5] { 0, 0, 0, 0, 0 };
        Label errorMaxComments = new Label();

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
            tab.AutoScroll = true;
            tab.AutoScrollMargin = new Size(10, 10);

            //sectionName textbox
            TextBox sectionName = new TextBox();
            sectionName.Name = "sectionName";
            sectionName.Text = "Section name";
            sectionName.Location = new Point(23, 19);
            tab.Controls.Add(sectionName);

            //addComment button
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

            //error for if they try to add too many comments
            errorMaxComments.AutoSize = true;
            errorMaxComments.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            errorMaxComments.ForeColor = Color.FromArgb(230,60,60);
            errorMaxComments.Location = new Point(3, 628);
            errorMaxComments.Size = new Size(438, 19);
            errorMaxComments.Text = "You have reached the maximum number of comments for this section.";
            errorMaxComments.Visible = false;
            tab.Controls.Add(errorMaxComments);

            //this section is probably very inefficient and bad practise but it does seem to work
            //code setup stuff
            TextBox code1 = new TextBox();
            TextBox code2 = new TextBox();
            TextBox code3 = new TextBox();
            TextBox code4 = new TextBox();
            TextBox code5 = new TextBox();
            List<TextBox> codes = new List<TextBox>();
            codes.Add(code1);
            codes.Add(code2);
            codes.Add(code3);
            codes.Add(code4);
            codes.Add(code5);
            codeDesign(codes);
            foreach (TextBox code in codes)
            {
                code.Name = codeNames[codes.IndexOf(code)];
                tab.Controls.Add(code);
            }

            //comment setup stuff
            TextBox comment1 = new TextBox();
            TextBox comment2 = new TextBox();
            TextBox comment3 = new TextBox();
            TextBox comment4 = new TextBox();
            TextBox comment5 = new TextBox();
            List<TextBox> comments = new List<TextBox>();
            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);
            comments.Add(comment4);
            comments.Add(comment5);
            commentDesign(comments);
            foreach(TextBox comment in comments)
            {
                comment.Name = commentNames[comments.IndexOf(comment)];
                tab.Controls.Add(comment);
            }
        }

        /// <summary>
        /// called when the add comment button is clicked
        /// adds the next code-comment pair to the tab from which it was called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddComment_Click(object sender, EventArgs e)
        {
            //find which tab is selected
            TabPage selectedTab = tabSections.SelectedTab;
            int tabIndex = tabs.IndexOf(selectedTab);
            //find value of sectionCodes for the tab
            int sectionCodesValue = sectionCodes[tabIndex];
            //if there is another code-comment pair that can be added
            if (sectionCodesValue < 5)
            {
                //find the next code
                Control[] codes = selectedTab.Controls.Find(codeNames[sectionCodesValue], true);
                //add it
                codes[0].Visible = true;
                //find the next comment
                Control[] comments = selectedTab.Controls.Find(commentNames[sectionCodesValue], true);
                //add it
                comments[0].Visible = true;
                //increment the number of code-comment pairs used on the tab
                sectionCodes[tabIndex] = sectionCodesValue + 1;
            }
            //for some reason this either doesn't get triggered or the code inside doesn't do anything
            else
            {
                errorMaxComments.Visible = true;
            }
        }
        /// <summary>
        /// configure design properties for the code text boxes
        /// </summary>
        /// <param name="codes">list of codes to be used</param>
        private void codeDesign(List<TextBox> codes)
        {
            foreach (TextBox code in codes)
            {
                code.Text = "Code " + (codes.IndexOf(code) + 1);
                int pos = codes.IndexOf(code);
                int y = codeYs[pos];
                code.Location = new Point(23, y);
                code.Size = new Size(145, 29);
                code.Visible = false; 
            }
        }
        /// <summary>
        /// configure design properties for the comment text boxes
        /// </summary>
        /// <param name="comments">list of comments to be used</param>
        private void commentDesign(List<TextBox> comments)
        {
            foreach (TextBox comment in comments)
            {
                comment.Text = "Comment...";
                comment.Multiline = true;
                int pos = comments.IndexOf(comment);
                int y = commentYs[pos];
                comment.Location = new Point(23, y);
                comment.Size = new Size(889, 73);
                comment.Visible = false; 
            }
        }

        private void btnBackPage(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Happytech.Pages.CreateTemplate());
        }

        /// <summary>
        /// Gathers together template name and each sections name, codes and respective comments
        /// Next step - insert to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTemplate(object sender, EventArgs e)
        {
            //get the template name
            string templateName = lblTemplateName.Text;
            //variable set up
            TabPage[] tabs = (tabSections.Controls.OfType<TabPage>()).ToArray();
            int noOfSections = tabs.Length;
            string[] sectionNames = new string[noOfSections - 1];
            int sectionNumber = 0;
            List<string>[,] codeComments = new List<string>[2, noOfSections];
            //for each tab
            for (int i = 0; i < tabs.Length - 1; i++)
            {
                TabPage tab = tabs[i];
                //get the section name
                TextBox txtSectionName = (TextBox) tab.Controls.Find("sectionName", true)[0];
                sectionNames[sectionNumber] = txtSectionName.Text;
                //get the codes and comments
                List<string> codes = new List<string>();
                List<string> comments = new List<string>();
                foreach (Control control in tab.Controls)
                {
                    if (control.Name.Contains("code"))
                    {
                        codes.Add(((TextBox)control).Text);
                    }
                    else if (control.Name.Contains("comment"))
                    {
                        comments.Add(((TextBox)control).Text);
                    }
                }
                codeComments[0, sectionNumber] = codes;
                codeComments[1, sectionNumber] = comments;
                sectionNumber++;
            }
            //make an sql insert
            db.CreateTemplate(templateName, sectionNames, codeComments);
        }
    }
}
