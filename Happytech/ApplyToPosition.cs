using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happytech
{
    public partial class ApplyToPosition : Form
    {
        public ApplyToPosition()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "Select your curriculum",
                Filter = "Documents (*.pdf)|*.docx|*.doc",
                Title = "Open document file",
                Multiselect = false
            };
        }
    }
}
