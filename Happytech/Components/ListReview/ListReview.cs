using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Happytech.Components.ListReview
{
    public partial class ListReview : UserControl
    {
        Database db = new Database();

        public ListReview()
        {
            InitializeComponent();
            FlowLayout.HorizontalScroll.Visible = false;
        }

        public void RefreshList(int filterDropdown, int roleDropdownIndex) 
        {
            // Delete previous list
            FlowLayout.Controls.Clear();

            // Populate the list and assign the replyID as the name of the control
            switch (filterDropdown)
            {
                case 0:
                    foreach (DataRow application in db.FetchApplications().Rows)
                    {
                        // Filter by role
                        if (roleDropdownIndex != 0)
                        {
                            if (int.Parse(application["RoleID"].ToString()) == roleDropdownIndex)
                            {
                                var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                                FlowLayout.Controls.Add(item);
                            }
                        }
                        else
                        {
                            var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                            FlowLayout.Controls.Add(item);
                        }
                    }
                    break;

                case 1:
                    foreach (DataRow application in db.FetchNewApplications().Rows)
                    {
                        if (roleDropdownIndex != 0)
                        {
                            if (int.Parse(application["RoleID"].ToString()) == roleDropdownIndex)
                            {
                                var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                                FlowLayout.Controls.Add(item);
                            }
                        }
                        else
                        {
                            var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                            FlowLayout.Controls.Add(item);
                        }
                    }
                    break;

                case 2:
                    foreach (DataRow application in db.FetchRepliedApplications().Rows)
                    {
                        if (roleDropdownIndex != 0)
                        {
                            if (int.Parse(application["RoleID"].ToString()) == roleDropdownIndex)
                            {
                                var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                                FlowLayout.Controls.Add(item);
                            }
                        }
                        else
                        {
                            var item = new ItemReview(int.Parse(application["ApplicationID"].ToString()));
                            FlowLayout.Controls.Add(item);
                        }
                    }
                    break;
            }
        }
    }
}
