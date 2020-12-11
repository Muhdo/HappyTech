using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shell;
using Happytech;
using Happytech.Classes;
using HappyTech.Classes;
using PdfiumViewer;
using Section = HappyTech.Components.Templates.Section;

namespace HappyTech.Pages
{
    public partial class Replying : UserControl
    {
        Database db = new Database();

        List<Template> templates = new List<Template>();
        List<Applications> applications = new List<Applications>();
        List<Reply> replies = new List<Reply>();

        private int appIndex = 0;

        List<Section> sections = new List<Section>();

        public Replying(int[] revApplications)
        {
            InitializeComponent();

            //Gets every application data
            foreach (int appID in revApplications)
            {
                applications.Add(db.GetApplication(appID));
                replies.Add(new Reply(){ ApplicationId = appID });
            }

            ChangeCandidate();


            //Fetches the templates and adds it to the combobox
            //TODO: filter the ones for the position
            templates.AddRange(db.GetTemplateNames());
            templates.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));

            foreach (Template template in templates) 
                cbTemplate.Items.Add(template.Name);
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpTemplate.Controls.Clear(); //Clears the panel
            sections.Clear(); //Clears the sections list
            
            if (cbTemplate.SelectedIndex != -1)
            {
                //Loads the template data
                Template selectedTemplate = db.GetTemplateData(templates[cbTemplate.SelectedIndex].TemplateId);

                replies[appIndex].TemplateId = selectedTemplate.TemplateId; //Sets the template id for the current candidate

                int[] selectedComments = replies[appIndex].CommentIds.ToArray();

                //Goes through and creates new sections and comments as it is in the template
                foreach (HappyTech.Classes.Section section in selectedTemplate.Sections)
                {
                    Section sec = new Section(section, selectedComments); //Declares the section
                    sections.Add(sec); //Saves section data

                    flpTemplate.Controls.Add(sec); //Adds section to panel
                }
            }
        }

        private void ChangeCandidate(object sender = null, EventArgs e = null)
        {
            Button btn = (Button) sender;
            string name;
            string curriculum;

            //Saves the data to the specific application
            foreach (Section section in sections)
            {
                foreach (int sectionSelectedComment in section.selectedComments)
                {
                    if (!replies[appIndex].CommentIds.Contains(sectionSelectedComment)) 
                        replies[appIndex].CommentIds.Add(sectionSelectedComment);
                }
            }
            

            //Changes to the previous candidate
            if (btn != null && btn.Tag == "Previous")
            {
                name = applications[--appIndex].Name;
                curriculum = applications[appIndex].Curriculum;
            }
            //Changes to the next candidate
            else if (btn != null && btn.Tag == "Next")
            {
                name = applications[++appIndex].Name;
                curriculum = applications[appIndex].Curriculum;
            }
            //First action when page loads
            else
            {
                name = applications[appIndex].Name;
                curriculum = applications[appIndex].Curriculum;
            }

            cbTemplate.SelectedIndex = -1;

            lblCandidateName.Text = name;
            OpenPDF(curriculum);
            
            //Checks if it's in the lower or upper limit
            btnPrevCandidate.Enabled = appIndex > 0; // ONE LINE IF STATEMENT True = index higher than 0  False = index equal to 0
            btnNextCandidate.Enabled = appIndex < (applications.Count - 1); // ONE LINE IF STATEMENT True = index lower than max length  False = index equal to max length

            if (replies[appIndex].TemplateId != 0) 
                cbTemplate.SelectedIndex = templates.FindIndex(t => t.TemplateId == replies[appIndex].TemplateId);

            txtViewResponse.Text =
                ApplicationReviewing.GetMessage(applications[appIndex].Name, replies[appIndex].CommentIds.ToArray());

            //foreach (Reply reply in replies)
            //{
            //    Console.WriteLine("Application ID: {0}", reply.ApplicationId);
            //    Console.WriteLine("Template ID: {0}", reply.TemplateId);
            //    foreach (int replyCommentId in reply.CommentIds)
            //    {
            //        Console.WriteLine("Comment ID: {0}", replyCommentId);
            //    }

            //    Console.WriteLine("----------------------");
            //}
        }

        public void OpenPDF(string name)
        {
            try
            {
                // Set path and use the in the DB as the name for the .pdf
                byte[] bytes = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\cv\\{name}.pdf");
                var stream = new MemoryStream(bytes);
                PdfDocument pdf = PdfDocument.Load(stream);
                pdfReader.Document = pdf;
            }
            catch(FileNotFoundException)
            {
                // This happens if the file is not in the CV folder
                MessageBox.Show($"The applicants CV must be stored inside {Directory.GetCurrentDirectory()}\\cv");
            }
            catch(Exception ex)
            {
                MessageBox.Show("We don't know what happened, error message: " + ex.Message);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Tag == "Preview")
            {
                //Saves the data to the specific application
                foreach (Section section in sections)
                {
                    foreach (int sectionSelectedComment in section.selectedComments)
                    {
                        if (!replies[appIndex].CommentIds.Contains(sectionSelectedComment)) 
                            replies[appIndex].CommentIds.Add(sectionSelectedComment);
                    }
                }

                //foreach (Reply reply in replies)
                //{
                //    Console.WriteLine("Application ID: {0}", reply.ApplicationId);
                //    Console.WriteLine("Template ID: {0}", reply.TemplateId);
                //    foreach (int replyCommentId in reply.CommentIds)
                //    {
                //        Console.WriteLine("Comment ID: {0}", replyCommentId);
                //    }

                //    Console.WriteLine("----------------------");
                //}

                txtViewResponse.Text = ApplicationReviewing.GetMessage(applications[appIndex].Name, replies[appIndex].CommentIds.ToArray());

                pView.Visible = true;

                btnNext.Text = "Send Responses";
                btnNext.Tag = "Send";
            } 
            else if (btnNext.Tag == "Send")
            {
                bool sent = db.SendResponse(replies.ToArray());

                if (sent)
                {
                    MessageBox.Show("All Responses have been sent to the corresponding applicants.", "Responses Sent", MessageBoxButtons.OK);

                    ApplicationReviewing.ToBeReviewed.Clear();

                    Controls.Clear();
                    Controls.Add(new Dashboard());
                }
                else
                    MessageBox.Show("There was an error replying to the applicants.", "Error Sending Responses", MessageBoxButtons.OK);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Main().Show();
            Hide();
        }
    }
}
