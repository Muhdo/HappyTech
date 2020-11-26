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
            this.tabNew = new System.Windows.Forms.TabPage();
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.lblMaxTabsError = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tabSections.SuspendLayout();
            this.tabNew.SuspendLayout();
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
            this.lblTemplateName.Location = new System.Drawing.Point(323, 14);
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
            // tabNew
            // 
            this.tabNew.AutoScroll = true;
            this.tabNew.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.tabNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.tabNew.Controls.Add(this.textBox11);
            this.tabNew.Controls.Add(this.textBox10);
            this.tabNew.Controls.Add(this.textBox9);
            this.tabNew.Controls.Add(this.textBox8);
            this.tabNew.Controls.Add(this.textBox7);
            this.tabNew.Controls.Add(this.textBox6);
            this.tabNew.Controls.Add(this.textBox5);
            this.tabNew.Controls.Add(this.textBox4);
            this.tabNew.Controls.Add(this.button1);
            this.tabNew.Controls.Add(this.textBox3);
            this.tabNew.Controls.Add(this.textBox2);
            this.tabNew.Controls.Add(this.textBox1);
            this.tabNew.Location = new System.Drawing.Point(4, 30);
            this.tabNew.Name = "tabNew";
            this.tabNew.Size = new System.Drawing.Size(957, 332);
            this.tabNew.TabIndex = 0;
            this.tabNew.Text = "    +";
            this.tabNew.Enter += new System.EventHandler(this.newTab);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Section Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Code 1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 93);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(889, 73);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Comment space";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.button1.Location = new System.Drawing.Point(771, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Comment";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 29);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Code 2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(23, 207);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(889, 73);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Comment space";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(23, 286);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 29);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Code 3";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(23, 321);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(889, 73);
            this.textBox7.TabIndex = 9;
            this.textBox7.Text = "Comment space";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(23, 400);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(145, 29);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "Code 4";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(23, 435);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(889, 73);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "Comment space";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(23, 514);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(145, 29);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "Code 5";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(23, 549);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(889, 73);
            this.textBox11.TabIndex = 13;
            this.textBox11.Text = "Comment space";
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
            this.tabNew.ResumeLayout(false);
            this.tabNew.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}
