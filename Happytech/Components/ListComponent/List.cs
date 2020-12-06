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

namespace Happytech.Components.ListComponent
{
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

        public void LoadData(Employee[] employees)
        {
            VerticalFlow.Controls.Clear();

            foreach (Employee employee in employees)
            {
                VerticalFlow.Controls.Add(new ListItem(employee.EmployeeId, employee.Name));
            }
        }
    }
}
