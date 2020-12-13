using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech.Classes;
using Happytech.Pages;
using HappyTech.Pages;
using HappyTech.Properties;
using Settings = Happytech.Pages.Settings;

namespace Happytech
{
    public partial class Main : Form
    {
        // Do not modify
        Thread DragWindowThread;
        Thread AnimationThread;

        // Variables
        bool DrawerOpened = true;

        public Main()
        {
            InitializeComponent();
            pWindow.Controls.Add(new Dashboard());

            // Settings option if admin, otherwise hidden.
            db_Settings.Visible = CurrentEmployee.IsAdmin == true ? true : false;
        }

        private void ChangeDrawerState(object sender, EventArgs e)
        {
            if (AnimationThread == null)
            {
                // Hide labels and logos
                ApplicationsText.Visible = !DrawerOpened;
                ViewTemplatesText.Visible = !DrawerOpened;
                EditTemplatesText.Visible = !DrawerOpened;
                DashboardText.Visible = !DrawerOpened;
                SettingsText.Visible = !DrawerOpened;
                DrawerText.Visible = !DrawerOpened;
                DrawerTitle.Visible = !DrawerOpened;
                SmallLogo.Visible = DrawerOpened;
                Logo.Visible = !DrawerOpened;

                // Change drawer state
                DrawerIcon.Image = DrawerOpened ? Resources.open_drawer : Resources.close_drawer;

                // Start animation thread
                AnimationThread = new Thread(() => AnimateDrawer());
                AnimationThread.Start();
            }
        }

        /// <summary>
        /// Changes the width of the drawer gradually from closed to opened and vice versa
        /// </summary>
        private void AnimateDrawer()
        {
            if (DrawerOpened)
            {
                // Change the state to closed
                DrawerOpened = false;

                // Animate drawer closing
                while (Drawer.Width != 59)
                {
                    Drawer.Invoke((MethodInvoker)(() => Drawer.Width -= 4));
                    Thread.Sleep(1);
                }
            }
            else
            {
                // Change the state to opened
                DrawerOpened = true;

                // Animate drawer closing
                while (Drawer.Width != 211)
                {
                    Drawer.Invoke((MethodInvoker)(() => Drawer.Width += 4));
                    Thread.Sleep(1);
                }
            }
            AnimationThread = null;
        }


        /// <summary>
        /// Sets all buttons in the drawer to the default background color
        /// </summary>
        private void ResetButtonBackground()
        {
            foreach (Control btn in DashboardMenu.Controls)
            {
                if (btn is Panel && btn.Name.Contains("db"))
                    btn.BackColor = Color.FromArgb(39, 44, 74);
            }
        }

        /// <summary>
        /// Sets the color of a panel to the specified values
        /// </summary>
        private void SetButtonBackground(Panel button, int r, int g, int b)
        {
            button.BackColor = Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Select tab from the drawer
        /// </summary>
        private void DrawerSelectTab(object sender, EventArgs e)
        {
            // Reset button colors 
            ResetButtonBackground();
            pWindow.Controls.Clear();

            // Set button color and enable the selected content
            switch (((Control)sender).Tag)
            {
                case "Dashboard":
                    SetButtonBackground(db_Dashboard, 29, 34, 64);
                    pWindow.Controls.Add(new Dashboard());
                    break;
                case "ViewTemplates":
                    SetButtonBackground(db_ViewTemplates, 29, 34, 64);
                    Controls.Clear();
                    Controls.Add(new CreateTemplate());
                    break;
                case "Applications":
                    SetButtonBackground(db_Applications, 29, 34, 64);
                    pWindow.Controls.Add(new RepliedApplications());
                    break;
                case "UserSettings":
                    SetButtonBackground(db_Settings, 29, 34, 64);
                    pWindow.Controls.Add(new Settings());
                    break;
                case "Edit Templates":
                    SetButtonBackground(db_EditTemplates, 29, 34, 64);
                    pWindow.Controls.Add(new EditTemplates());
                    break;
            }
        }

        private void OnHoverButtonColor(object sender, EventArgs e)
        {
            //TODO: Improve if statement
            //Selects the parent of the label or picturebox
            if (sender.GetType() == typeof(Label)) sender = ((Label)sender).Parent;
            else if (sender.GetType() == typeof(PictureBox)) sender = ((PictureBox)sender).Parent;

            Panel btn = (Panel)sender;

            // If button is not selected
            if (btn.BackColor != Color.FromArgb(29, 34, 64))
                btn.BackColor = Color.FromArgb(49, 54, 84);
        }

        private void OffHoverButtonColor(object sender, EventArgs e)
        {
            //TODO: Improve if statement
            //Selects the parent of the label or picturebox
            if (sender.GetType() == typeof(Label)) sender = ((Label)sender).Parent;
            else if (sender.GetType() == typeof(PictureBox)) sender = ((PictureBox)sender).Parent;

            Panel btn = (Panel)sender;

            // If button is not selected
            if (btn.BackColor != Color.FromArgb(29, 34, 64))
                btn.BackColor = Color.FromArgb(39, 44, 74);
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimizeApplication_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (DragWindowThread == null)
            {
                DragWindowThread = new Thread(() => WindowOnDrag(this, ((Panel)sender).Location, e.Location));
                DragWindowThread.Start();
            }
        }

        private void StopDragWindow(object sender, MouseEventArgs e)
        {
            if (DragWindowThread != null)
            {
                DragWindowThread.Abort();
                DragWindowThread = null;
            }
        }
        private void WindowOnDrag(Form form, Point panel, Point location)
        {
            // While the thread is alive, keep dragging the window
            while (true)
            {
                //Moves the form to the mouse position - TopBar position - mouse position
                form.Invoke((MethodInvoker)(() => form.Left = Cursor.Position.X - panel.X - location.X));
                form.Invoke((MethodInvoker)(() => form.Top = Cursor.Position.Y - panel.Y - location.Y));
            }
        }
    }
}
