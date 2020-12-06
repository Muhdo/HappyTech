using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTech.Classes;

namespace HappyTech.Components.Templates
{
    public partial class Section : UserControl
    {
        public Section(HappyTech.Classes.Section section)
        {
            InitializeComponent();

            lblSectionName.Text = section.Title;

            foreach (Comment comment in section.Comments)
            {
                flpComments.Controls.Add(new CheckBox()
                {
                    Text = comment.ShortName, 
                    Tag = comment.CommentId,
                });
            }
        }
    }
}
