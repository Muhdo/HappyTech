using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happytech.Pages
{
    public partial class ViewTemplates : UserControl
    {
        Database db = new Database();

        public ViewTemplates()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTemplateName.Text))
            {
                db.AddTemplate(txtTemplateName.Text);
                this.Controls.Clear();
                this.Controls.Add(new Home()); 
            }
        }

        private void backHome(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Home());
        }
    }
}
