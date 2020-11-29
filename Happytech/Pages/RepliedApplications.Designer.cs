namespace Happytech.Pages
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
            this.btnInsertApplication = new System.Windows.Forms.Button();
            this.pCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpApplications
            // 
            this.grpApplications.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grpApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.grpApplications.Location = new System.Drawing.Point(24, 121);
            this.grpApplications.Name = "grpApplications";
            this.grpApplications.Size = new System.Drawing.Size(325, 446);
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
            this.cbApplicationList.Size = new System.Drawing.Size(211, 32);
            this.cbApplicationList.TabIndex = 2;
            this.cbApplicationList.SelectedIndexChanged += new System.EventHandler(this.cbApplicationList_SelectedIndexChanged);
            // 
            // pCV
            // 
            this.pCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCV.AutoSize = true;
            this.pCV.Controls.Add(this.pdfReader);
            this.pCV.Location = new System.Drawing.Point(369, 3);
            this.pCV.Name = "pCV";
            this.pCV.Size = new System.Drawing.Size(497, 585);
            this.pCV.TabIndex = 3;
            // 
            // pdfReader
            // 
            this.pdfReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfReader.Location = new System.Drawing.Point(0, 0);
            this.pdfReader.Name = "pdfReader";
            this.pdfReader.Size = new System.Drawing.Size(497, 585);
            this.pdfReader.TabIndex = 0;
            this.pdfReader.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // btnInsertApplication
            // 
            this.btnInsertApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btnInsertApplication.FlatAppearance.BorderSize = 0;
            this.btnInsertApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertApplication.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInsertApplication.Location = new System.Drawing.Point(24, 40);
            this.btnInsertApplication.Name = "btnInsertApplication";
            this.btnInsertApplication.Size = new System.Drawing.Size(325, 32);
            this.btnInsertApplication.TabIndex = 4;
            this.btnInsertApplication.Text = "Insert New Application";
            this.btnInsertApplication.UseVisualStyleBackColor = false;
            this.btnInsertApplication.Click += new System.EventHandler(this.btnInsertApplication_Click);
            // 
            // RepliedApplications
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.btnInsertApplication);
            this.Controls.Add(this.pCV);
            this.Controls.Add(this.cbApplicationList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpApplications);
            this.Name = "RepliedApplications";
            this.Size = new System.Drawing.Size(869, 585);
            this.pCV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpApplications;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbApplicationList;
        private System.Windows.Forms.Panel pCV;
        private PdfiumViewer.PdfViewer pdfReader;
        private System.Windows.Forms.Button btnInsertApplication;
    }
}
