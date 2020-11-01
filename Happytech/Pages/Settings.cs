using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.Classes;
using Happytech.Components.ListComponent;

namespace Happytech.Pages
{
    public partial class Settings : UserControl
    {
        Database db = new Database();
        public Settings()
        {
            InitializeComponent();

            lstEmployees.LoadData(db.ListEmployees());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Panel window = (Panel)this.Parent;
            window.Controls.Clear(); //Clears every page in the main panel 

            window.Controls.Add(new Home());
        }
    }
}
