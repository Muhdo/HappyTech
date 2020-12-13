namespace Happytech
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pWindow = new System.Windows.Forms.Panel();
            this.Drawer = new System.Windows.Forms.Panel();
            this.DashboardMenu = new System.Windows.Forms.Panel();
            this.db_EditTemplates = new System.Windows.Forms.Panel();
            this.EditTemplatesText = new System.Windows.Forms.Label();
            this.EditTemplatesIcon = new System.Windows.Forms.PictureBox();
            this.db_Settings = new System.Windows.Forms.Panel();
            this.SettingsText = new System.Windows.Forms.Label();
            this.SettingsIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DrawerText = new System.Windows.Forms.Label();
            this.DrawerIcon = new System.Windows.Forms.PictureBox();
            this.db_Applications = new System.Windows.Forms.Panel();
            this.ApplicationsText = new System.Windows.Forms.Label();
            this.ApplicationsIcon = new System.Windows.Forms.PictureBox();
            this.db_ViewTemplates = new System.Windows.Forms.Panel();
            this.ViewTemplatesText = new System.Windows.Forms.Label();
            this.ViewTemplatesIcon = new System.Windows.Forms.PictureBox();
            this.DrawerTitle = new System.Windows.Forms.Label();
            this.db_Dashboard = new System.Windows.Forms.Panel();
            this.DashboardText = new System.Windows.Forms.Label();
            this.DashboardIcon = new System.Windows.Forms.PictureBox();
            this.SmallLogo = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizeApplication = new System.Windows.Forms.PictureBox();
            this.btnCloseApplication = new System.Windows.Forms.PictureBox();
            this.Drawer.SuspendLayout();
            this.DashboardMenu.SuspendLayout();
            this.db_EditTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditTemplatesIcon)).BeginInit();
            this.db_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerIcon)).BeginInit();
            this.db_Applications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsIcon)).BeginInit();
            this.db_ViewTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTemplatesIcon)).BeginInit();
            this.db_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // pWindow
            // 
            this.pWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            resources.ApplyResources(this.pWindow, "pWindow");
            this.pWindow.ForeColor = System.Drawing.Color.White;
            this.pWindow.Name = "pWindow";
            // 
            // Drawer
            // 
            this.Drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.Drawer.Controls.Add(this.DashboardMenu);
            this.Drawer.Controls.Add(this.SmallLogo);
            this.Drawer.Controls.Add(this.Logo);
            resources.ApplyResources(this.Drawer, "Drawer");
            this.Drawer.Name = "Drawer";
            // 
            // DashboardMenu
            // 
            this.DashboardMenu.Controls.Add(this.db_EditTemplates);
            this.DashboardMenu.Controls.Add(this.db_Settings);
            this.DashboardMenu.Controls.Add(this.panel1);
            this.DashboardMenu.Controls.Add(this.db_Applications);
            this.DashboardMenu.Controls.Add(this.db_ViewTemplates);
            this.DashboardMenu.Controls.Add(this.DrawerTitle);
            this.DashboardMenu.Controls.Add(this.db_Dashboard);
            resources.ApplyResources(this.DashboardMenu, "DashboardMenu");
            this.DashboardMenu.Name = "DashboardMenu";
            // 
            // db_EditTemplates
            // 
            this.db_EditTemplates.Controls.Add(this.EditTemplatesText);
            this.db_EditTemplates.Controls.Add(this.EditTemplatesIcon);
            resources.ApplyResources(this.db_EditTemplates, "db_EditTemplates");
            this.db_EditTemplates.Name = "db_EditTemplates";
            this.db_EditTemplates.Tag = "Edit Templates";
            this.db_EditTemplates.Click += new System.EventHandler(this.DrawerSelectTab);
            this.db_EditTemplates.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.db_EditTemplates.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // EditTemplatesText
            // 
            resources.ApplyResources(this.EditTemplatesText, "EditTemplatesText");
            this.EditTemplatesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditTemplatesText.Name = "EditTemplatesText";
            this.EditTemplatesText.Tag = "Edit Templates";
            this.EditTemplatesText.Click += new System.EventHandler(this.DrawerSelectTab);
            this.EditTemplatesText.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.EditTemplatesText.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // EditTemplatesIcon
            // 
            this.EditTemplatesIcon.Image = global::HappyTech.Properties.Resources.curriculum_vitae;
            resources.ApplyResources(this.EditTemplatesIcon, "EditTemplatesIcon");
            this.EditTemplatesIcon.Name = "EditTemplatesIcon";
            this.EditTemplatesIcon.TabStop = false;
            this.EditTemplatesIcon.Tag = "Edit Templates";
            this.EditTemplatesIcon.Click += new System.EventHandler(this.DrawerSelectTab);
            this.EditTemplatesIcon.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.EditTemplatesIcon.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // db_Settings
            // 
            this.db_Settings.Controls.Add(this.SettingsText);
            this.db_Settings.Controls.Add(this.SettingsIcon);
            resources.ApplyResources(this.db_Settings, "db_Settings");
            this.db_Settings.Name = "db_Settings";
            this.db_Settings.Tag = "UserSettings";
            this.db_Settings.Click += new System.EventHandler(this.DrawerSelectTab);
            this.db_Settings.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.db_Settings.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // SettingsText
            // 
            resources.ApplyResources(this.SettingsText, "SettingsText");
            this.SettingsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SettingsText.Name = "SettingsText";
            this.SettingsText.Tag = "UserSettings";
            this.SettingsText.Click += new System.EventHandler(this.DrawerSelectTab);
            this.SettingsText.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.SettingsText.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // SettingsIcon
            // 
            this.SettingsIcon.Image = global::HappyTech.Properties.Resources.settings;
            resources.ApplyResources(this.SettingsIcon, "SettingsIcon");
            this.SettingsIcon.Name = "SettingsIcon";
            this.SettingsIcon.TabStop = false;
            this.SettingsIcon.Tag = "UserSettings";
            this.SettingsIcon.Click += new System.EventHandler(this.DrawerSelectTab);
            this.SettingsIcon.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.SettingsIcon.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.DrawerText);
            this.panel1.Controls.Add(this.DrawerIcon);
            this.panel1.Name = "panel1";
            // 
            // DrawerText
            // 
            resources.ApplyResources(this.DrawerText, "DrawerText");
            this.DrawerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DrawerText.Name = "DrawerText";
            // 
            // DrawerIcon
            // 
            this.DrawerIcon.Image = global::HappyTech.Properties.Resources.close_drawer;
            resources.ApplyResources(this.DrawerIcon, "DrawerIcon");
            this.DrawerIcon.Name = "DrawerIcon";
            this.DrawerIcon.TabStop = false;
            this.DrawerIcon.Click += new System.EventHandler(this.ChangeDrawerState);
            // 
            // db_Applications
            // 
            this.db_Applications.Controls.Add(this.ApplicationsText);
            this.db_Applications.Controls.Add(this.ApplicationsIcon);
            resources.ApplyResources(this.db_Applications, "db_Applications");
            this.db_Applications.Name = "db_Applications";
            this.db_Applications.Tag = "Applications";
            this.db_Applications.Click += new System.EventHandler(this.DrawerSelectTab);
            this.db_Applications.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.db_Applications.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // ApplicationsText
            // 
            resources.ApplyResources(this.ApplicationsText, "ApplicationsText");
            this.ApplicationsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplicationsText.Name = "ApplicationsText";
            this.ApplicationsText.Tag = "Applications";
            this.ApplicationsText.Click += new System.EventHandler(this.DrawerSelectTab);
            this.ApplicationsText.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.ApplicationsText.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // ApplicationsIcon
            // 
            this.ApplicationsIcon.Image = global::HappyTech.Properties.Resources.curriculum_vitae;
            resources.ApplyResources(this.ApplicationsIcon, "ApplicationsIcon");
            this.ApplicationsIcon.Name = "ApplicationsIcon";
            this.ApplicationsIcon.TabStop = false;
            this.ApplicationsIcon.Tag = "Applications";
            this.ApplicationsIcon.Click += new System.EventHandler(this.DrawerSelectTab);
            this.ApplicationsIcon.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.ApplicationsIcon.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // db_ViewTemplates
            // 
            this.db_ViewTemplates.Controls.Add(this.ViewTemplatesText);
            this.db_ViewTemplates.Controls.Add(this.ViewTemplatesIcon);
            resources.ApplyResources(this.db_ViewTemplates, "db_ViewTemplates");
            this.db_ViewTemplates.Name = "db_ViewTemplates";
            this.db_ViewTemplates.Tag = "ViewTemplates";
            this.db_ViewTemplates.Click += new System.EventHandler(this.DrawerSelectTab);
            this.db_ViewTemplates.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.db_ViewTemplates.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // ViewTemplatesText
            // 
            resources.ApplyResources(this.ViewTemplatesText, "ViewTemplatesText");
            this.ViewTemplatesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ViewTemplatesText.Name = "ViewTemplatesText";
            this.ViewTemplatesText.Tag = "ViewTemplates";
            this.ViewTemplatesText.Click += new System.EventHandler(this.DrawerSelectTab);
            this.ViewTemplatesText.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.ViewTemplatesText.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // ViewTemplatesIcon
            // 
            this.ViewTemplatesIcon.Image = global::HappyTech.Properties.Resources.templates;
            resources.ApplyResources(this.ViewTemplatesIcon, "ViewTemplatesIcon");
            this.ViewTemplatesIcon.Name = "ViewTemplatesIcon";
            this.ViewTemplatesIcon.TabStop = false;
            this.ViewTemplatesIcon.Tag = "ViewTemplates";
            this.ViewTemplatesIcon.Click += new System.EventHandler(this.DrawerSelectTab);
            this.ViewTemplatesIcon.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.ViewTemplatesIcon.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // DrawerTitle
            // 
            resources.ApplyResources(this.DrawerTitle, "DrawerTitle");
            this.DrawerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.DrawerTitle.Name = "DrawerTitle";
            // 
            // db_Dashboard
            // 
            this.db_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.db_Dashboard.Controls.Add(this.DashboardText);
            this.db_Dashboard.Controls.Add(this.DashboardIcon);
            resources.ApplyResources(this.db_Dashboard, "db_Dashboard");
            this.db_Dashboard.Name = "db_Dashboard";
            this.db_Dashboard.Tag = "Dashboard";
            this.db_Dashboard.Click += new System.EventHandler(this.DrawerSelectTab);
            this.db_Dashboard.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.db_Dashboard.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // DashboardText
            // 
            resources.ApplyResources(this.DashboardText, "DashboardText");
            this.DashboardText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DashboardText.Name = "DashboardText";
            this.DashboardText.Tag = "Dashboard";
            this.DashboardText.Click += new System.EventHandler(this.DrawerSelectTab);
            this.DashboardText.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.DashboardText.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // DashboardIcon
            // 
            this.DashboardIcon.Image = global::HappyTech.Properties.Resources.dashboard__1_;
            resources.ApplyResources(this.DashboardIcon, "DashboardIcon");
            this.DashboardIcon.Name = "DashboardIcon";
            this.DashboardIcon.TabStop = false;
            this.DashboardIcon.Tag = "Dashboard";
            this.DashboardIcon.Click += new System.EventHandler(this.DrawerSelectTab);
            this.DashboardIcon.MouseEnter += new System.EventHandler(this.OnHoverButtonColor);
            this.DashboardIcon.MouseLeave += new System.EventHandler(this.OffHoverButtonColor);
            // 
            // SmallLogo
            // 
            this.SmallLogo.Image = global::HappyTech.Properties.Resources.Small_Logo;
            resources.ApplyResources(this.SmallLogo, "SmallLogo");
            this.SmallLogo.Name = "SmallLogo";
            this.SmallLogo.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::HappyTech.Properties.Resources.logotipo;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnMinimizeApplication);
            this.panel2.Controls.Add(this.btnCloseApplication);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDragWindow);
            // 
            // btnMinimizeApplication
            // 
            resources.ApplyResources(this.btnMinimizeApplication, "btnMinimizeApplication");
            this.btnMinimizeApplication.Image = global::HappyTech.Properties.Resources.minimizebutton;
            this.btnMinimizeApplication.Name = "btnMinimizeApplication";
            this.btnMinimizeApplication.TabStop = false;
            this.btnMinimizeApplication.Click += new System.EventHandler(this.btnMinimizeApplication_Click);
            // 
            // btnCloseApplication
            // 
            resources.ApplyResources(this.btnCloseApplication, "btnCloseApplication");
            this.btnCloseApplication.Image = global::HappyTech.Properties.Resources.close_button;
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.TabStop = false;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.pWindow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Drawer.ResumeLayout(false);
            this.DashboardMenu.ResumeLayout(false);
            this.db_EditTemplates.ResumeLayout(false);
            this.db_EditTemplates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditTemplatesIcon)).EndInit();
            this.db_Settings.ResumeLayout(false);
            this.db_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerIcon)).EndInit();
            this.db_Applications.ResumeLayout(false);
            this.db_Applications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsIcon)).EndInit();
            this.db_ViewTemplates.ResumeLayout(false);
            this.db_ViewTemplates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTemplatesIcon)).EndInit();
            this.db_Dashboard.ResumeLayout(false);
            this.db_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApplication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pWindow;
        private System.Windows.Forms.Panel Drawer;
        private System.Windows.Forms.Panel DashboardMenu;
        private System.Windows.Forms.Panel db_Settings;
        private System.Windows.Forms.Label SettingsText;
        private System.Windows.Forms.PictureBox SettingsIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DrawerText;
        private System.Windows.Forms.PictureBox DrawerIcon;
        private System.Windows.Forms.Panel db_Applications;
        private System.Windows.Forms.Label ApplicationsText;
        private System.Windows.Forms.PictureBox ApplicationsIcon;
        private System.Windows.Forms.Panel db_ViewTemplates;
        private System.Windows.Forms.Label ViewTemplatesText;
        private System.Windows.Forms.PictureBox ViewTemplatesIcon;
        private System.Windows.Forms.Label DrawerTitle;
        private System.Windows.Forms.Panel db_Dashboard;
        private System.Windows.Forms.Label DashboardText;
        private System.Windows.Forms.PictureBox DashboardIcon;
        private System.Windows.Forms.PictureBox SmallLogo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnMinimizeApplication;
        private System.Windows.Forms.PictureBox btnCloseApplication;
        private System.Windows.Forms.Panel db_EditTemplates;
        private System.Windows.Forms.Label EditTemplatesText;
        private System.Windows.Forms.PictureBox EditTemplatesIcon;
    }
}

