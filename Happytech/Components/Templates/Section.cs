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
        public List<int> selectedComments = new List<int>();


        public Section(HappyTech.Classes.Section section, int[] selectedComments)
        {
            InitializeComponent();

            //TODO: Make it change the replies list to have the information updated when the checkboxes are updated

            lblSectionName.Text = section.Title;

            foreach (Comment comment in section.Comments)
            {
                CheckBox cb = new CheckBox
                {
                    Text = comment.ShortName,
                    Tag = comment.CommentId,
                    Checked = selectedComments.Contains(comment.CommentId)
                };

                cb.CheckedChanged += updateData;

                flpComments.Controls.Add(cb);
            }
        }

        private void updateData(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!selectedComments.Contains((int)cb.Tag)) 
                selectedComments.Add((int)cb.Tag);
            else 
                selectedComments.Remove((int)cb.Tag); 
            
            selectedComments.Sort();
        }
    }
}
