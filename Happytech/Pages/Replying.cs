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
    public partial class Replying : UserControl
    {
        Database db = new Database();

        List<Template> templates = new List<Template>();

        public Replying(int[] revApplications)
        {
            InitializeComponent();

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
        }
    }
}
