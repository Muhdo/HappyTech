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

        private int appIndex = 0;

        public Replying(int[] revApplications)
        {
            InitializeComponent();

            //Gets every application data
            foreach (int appID in revApplications)
                applications.Add(db.GetApplication(appID));

            ChangeCandidate();


            //Fetches the templates and adds it to the combobox
            //TODO: filter the ones for the position
            templates.AddRange(db.GetTemplateNames());
            templates.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));

            foreach (Template template in templates)
            {
                cbTemplate.Items.Add(template.Name);
            }
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Load every section and comments for that template
            //TODO: Display in the Panel
            //TODO: Save the changes somewhere
            Template selectedTemplate = db.GetTemplateData(templates[cbTemplate.SelectedIndex].TemplateId);


            flpTemplate.Controls.Clear();

            foreach (HappyTech.Classes.Section section in selectedTemplate.Sections) 
                flpTemplate.Controls.Add(new Section(section));
            
        }

        private void ChangeCandidate(object sender = null, EventArgs e = null)
        {
            Button btn = (Button) sender;
            string name;
            string curriculum;

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

            lblCandidateName.Text = name;
            OpenPDF(curriculum);
            
            //Checks if it's in the lower or upper limit
            btnPrevCandidate.Enabled = appIndex > 0; // ONE LINE IF STATEMENT True = index higher than 0  False = index equal to 0
            btnNextCandidate.Enabled = appIndex < (applications.Count - 1); // ONE LINE IF STATEMENT True = index lower than max length  False = index equal to max length

            //TODO: I guess it's missing something to save the response when changing to a different applicant
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
    }
}
