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
using HappyTech.Pages;

namespace HappyTech.Components.Templates
{
    public partial class Section : UserControl
    {
        public Section(HappyTech.Classes.Section section)
        {
            InitializeComponent();

            //TODO: Make it change the replies list to have the information updated when the checkboxes are updated

            lblSectionName.Text = section.Title;

            foreach (Comment comment in section.Comments)
            {
                CheckBox cb = new CheckBox
                {
                    Text = comment.ShortName,
                    Tag = comment.CommentId
                };

                cb.CheckedChanged += (sender, args) =>
                {
                    Console.WriteLine("Yo bruh");
                };

                flpComments.Controls.Add(cb);
            }
        }
    }
}
