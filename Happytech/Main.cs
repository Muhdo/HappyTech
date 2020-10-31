using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.Pages;

namespace Happytech
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            pWindow.Controls.Add(new Home());
        }
    }
}
