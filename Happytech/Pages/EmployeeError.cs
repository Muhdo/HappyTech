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
    public partial class EmployeeError : UserControl
    {
        public EmployeeError()
        {
            InitializeComponent();

            lblUsername.Text = Environment.UserName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
