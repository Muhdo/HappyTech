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
using HappyTech.Classes;

namespace HappyTech.Pages
{
    public partial class EditTemplates : UserControl
    {
        Database db = new Database();
        public EditTemplates()
        {
            InitializeComponent();
            List<Template> Templates = db.GetTemplateNames();

            foreach (Template template in Templates)
                cbSelectTemplate.Items.Insert(template.TemplateId, template.Name);
        }

        private void DisplayTemplate(object sender, EventArgs e)
        {
            //get the selected template info
            Template selectedTemplate = db.GetTemplateData(cbSelectTemplate.SelectedIndex);
            int noOfSections = selectedTemplate.Sections.Count;
            //add the right number of tabs to tab control
            //for each section in the template
            //add textbox for section name
            //for each comment
            //add textbox for code
            //add textbox for comment
        }
    }
}
