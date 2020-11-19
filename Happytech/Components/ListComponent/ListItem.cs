using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happytech.Components.ListComponent
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        public ListItem(int id, string name)
        {
            InitializeComponent();

            lblName.Text = name;
            btnDelete.Tag = id;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            if (db.RemoveEmployee((int) btnDelete.Tag)) this.Dispose();
        }
    }
}
