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
            var Templates = db.GetTemplateNames();

            foreach (var template in Templates)
                cbSelectTemplate.Items.Insert(template.TemplateId, template.Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
