namespace HappyTech.Pages
{
    partial class TemplateSetup
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSections = new System.Windows.Forms.TabControl();
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.lblMaxTabsError = new System.Windows.Forms.Label();
            this.tabNew = new System.Windows.Forms.TabPage();
            this.tabSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnBack.Location = new System.Drawing.Point(53, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 31);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBackPage);
            // 
            // lblTemplateName
            // 
            this.lblTemplateName.AutoSize = true;
            this.lblTemplateName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.lblTemplateName.Location = new System.Drawing.Point(289, 16);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(467, 65);
            this.lblTemplateName.TabIndex = 4;
            this.lblTemplateName.Text = "New Template Name";
            this.lblTemplateName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(275, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSections
            // 
            this.tabSections.Controls.Add(this.tabNew);
            this.tabSections.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSections.Location = new System.Drawing.Point(53, 122);
            this.tabSections.Name = "tabSections";
            this.tabSections.Padding = new System.Drawing.Point(0, 0);
            this.tabSections.SelectedIndex = 0;
            this.tabSections.Size = new System.Drawing.Size(965, 366);
            this.tabSections.TabIndex = 8;
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnCreateTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTemplate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCreateTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnCreateTemplate.Location = new System.Drawing.Point(883, 542);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(135, 31);
            this.btnCreateTemplate.TabIndex = 9;
            this.btnCreateTemplate.Text = "Save Template";
            this.btnCreateTemplate.UseVisualStyleBackColor = false;
            // 
            // lblMaxTabsError
            // 
            this.lblMaxTabsError.AutoSize = true;
            this.lblMaxTabsError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMaxTabsError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblMaxTabsError.Location = new System.Drawing.Point(53, 509);
            this.lblMaxTabsError.Name = "lblMaxTabsError";
            this.lblMaxTabsError.Size = new System.Drawing.Size(333, 19);
            this.lblMaxTabsError.TabIndex = 10;
            this.lblMaxTabsError.Text = "You have reached the maximum number of sections. ";
            this.lblMaxTabsError.Visible = false;
            // 
            // tabNew
            // 
            this.tabNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.tabNew.Location = new System.Drawing.Point(4, 30);
            this.tabNew.Name = "tabNew";
            this.tabNew.Size = new System.Drawing.Size(957, 332);
            this.tabNew.TabIndex = 0;
            this.tabNew.Text = "    +";
            this.tabNew.Click += new System.EventHandler(newTab);
            // 
            // TemplateSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.lblMaxTabsError);
            this.Controls.Add(this.btnCreateTemplate);
            this.Controls.Add(this.tabSections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TemplateSetup";
            this.Size = new System.Drawing.Size(1080, 610);
            this.tabSections.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabSections;
        private System.Windows.Forms.Button btnCreateTemplate;
        private System.Windows.Forms.Label lblMaxTabsError;
        private System.Windows.Forms.TabPage tabNew;
    }
}
