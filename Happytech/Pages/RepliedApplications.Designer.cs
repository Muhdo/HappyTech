﻿namespace Happytech.Pages
{
    partial class RepliedApplications
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpApplications = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbApplicationList = new System.Windows.Forms.ComboBox();
            this.pCV = new System.Windows.Forms.Panel();
            this.pdfReader = new PdfiumViewer.PdfViewer();
            this.btnHome = new System.Windows.Forms.Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.pCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // grpApplications
            // 
            this.grpApplications.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grpApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.grpApplications.Location = new System.Drawing.Point(24, 121);
            this.grpApplications.Name = "grpApplications";
            this.grpApplications.Size = new System.Drawing.Size(362, 454);
            this.grpApplications.TabIndex = 0;
            this.grpApplications.TabStop = false;
            this.grpApplications.Text = "Application List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(24, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbApplicationList
            // 
            this.cbApplicationList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.cbApplicationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApplicationList.ForeColor = System.Drawing.Color.White;
            this.cbApplicationList.FormattingEnabled = true;
            this.cbApplicationList.Items.AddRange(new object[] {
            "All Applications",
            "New Applications",
            "Replied Applications"});
            this.cbApplicationList.Location = new System.Drawing.Point(138, 78);
            this.cbApplicationList.Name = "cbApplicationList";
            this.cbApplicationList.Size = new System.Drawing.Size(248, 32);
            this.cbApplicationList.TabIndex = 2;
            this.cbApplicationList.SelectedIndexChanged += new System.EventHandler(this.cbApplicationList_SelectedIndexChanged);
            // 
            // pCV
            // 
            this.pCV.Controls.Add(this.pdfReader);
            this.pCV.Location = new System.Drawing.Point(644, 0);
            this.pCV.Name = "pCV";
            this.pCV.Size = new System.Drawing.Size(436, 610);
            this.pCV.TabIndex = 3;
            // 
            // pdfReader
            // 
            this.pdfReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfReader.Location = new System.Drawing.Point(0, 0);
            this.pdfReader.Name = "pdfReader";
            this.pdfReader.Size = new System.Drawing.Size(436, 610);
            this.pdfReader.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.Location = new System.Drawing.Point(24, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 32);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.ReturnHome);
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.White;
            this.picHome.Image = global::HappyTech.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(30, 18);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(24, 24);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 5;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.ReturnHome);
            // 
            // RepliedApplications
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pCV);
            this.Controls.Add(this.cbApplicationList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpApplications);
            this.Name = "RepliedApplications";
            this.Size = new System.Drawing.Size(1080, 610);
            this.pCV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpApplications;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbApplicationList;
        private System.Windows.Forms.Panel pCV;
        private PdfiumViewer.PdfViewer pdfReader;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picHome;
    }
}