namespace HappyTech.Pages
{
    partial class EditTemplates
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
            this.cbSelectTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateFields = new System.Windows.Forms.Button();
            this.flSectionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.flSection = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteSection = new System.Windows.Forms.Button();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelectTemplate
            // 
            this.cbSelectTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.cbSelectTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectTemplate.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbSelectTemplate.ForeColor = System.Drawing.SystemColors.Control;
            this.cbSelectTemplate.FormattingEnabled = true;
            this.cbSelectTemplate.Items.AddRange(new object[] {
            " "});
            this.cbSelectTemplate.Location = new System.Drawing.Point(32, 49);
            this.cbSelectTemplate.Name = "cbSelectTemplate";
            this.cbSelectTemplate.Size = new System.Drawing.Size(231, 33);
            this.cbSelectTemplate.TabIndex = 0;
            this.cbSelectTemplate.SelectedIndexChanged += new System.EventHandler(this.SelectTemplate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Template: ";
            // 
            // btnUpdateFields
            // 
            this.btnUpdateFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btnUpdateFields.FlatAppearance.BorderSize = 0;
            this.btnUpdateFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateFields.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFields.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFields.Location = new System.Drawing.Point(665, 516);
            this.btnUpdateFields.Name = "btnUpdateFields";
            this.btnUpdateFields.Size = new System.Drawing.Size(170, 48);
            this.btnUpdateFields.TabIndex = 3;
            this.btnUpdateFields.Text = "UPDATE FIELDS";
            this.btnUpdateFields.UseVisualStyleBackColor = false;
            this.btnUpdateFields.Visible = false;
            this.btnUpdateFields.Click += new System.EventHandler(this.UpdateTemplate);
            // 
            // flSectionButtons
            // 
            this.flSectionButtons.Location = new System.Drawing.Point(279, 46);
            this.flSectionButtons.Name = "flSectionButtons";
            this.flSectionButtons.Size = new System.Drawing.Size(553, 38);
            this.flSectionButtons.TabIndex = 5;
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.flSection);
            this.grpSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.grpSection.Location = new System.Drawing.Point(32, 103);
            this.grpSection.Name = "grpSection";
            this.grpSection.Size = new System.Drawing.Size(803, 398);
            this.grpSection.TabIndex = 6;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "No section selected";
            // 
            // flSection
            // 
            this.flSection.AutoScroll = true;
            this.flSection.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flSection.Location = new System.Drawing.Point(6, 24);
            this.flSection.Name = "flSection";
            this.flSection.Size = new System.Drawing.Size(791, 368);
            this.flSection.TabIndex = 0;
            this.flSection.WrapContents = false;
            // 
            // btnDeleteSection
            // 
            this.btnDeleteSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btnDeleteSection.FlatAppearance.BorderSize = 0;
            this.btnDeleteSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSection.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSection.Location = new System.Drawing.Point(32, 0);
            this.btnDeleteSection.Name = "btnDeleteSection";
            this.btnDeleteSection.Size = new System.Drawing.Size(200, 26);
            this.btnDeleteSection.TabIndex = 7;
            this.btnDeleteSection.Text = "Delete selected section";
            this.btnDeleteSection.UseVisualStyleBackColor = false;
            this.btnDeleteSection.Visible = false;
            this.btnDeleteSection.Click += new System.EventHandler(this.DeleteSection);
            // 
            // btnAddComment
            // 
            this.btnAddComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btnAddComment.FlatAppearance.BorderSize = 0;
            this.btnAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComment.ForeColor = System.Drawing.Color.White;
            this.btnAddComment.Location = new System.Drawing.Point(32, 516);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(200, 48);
            this.btnAddComment.TabIndex = 8;
            this.btnAddComment.Text = "Add new comment";
            this.btnAddComment.UseVisualStyleBackColor = false;
            this.btnAddComment.Visible = false;
            this.btnAddComment.Click += new System.EventHandler(this.AddComment);
            // 
            // EditTemplates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.btnDeleteSection);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.flSectionButtons);
            this.Controls.Add(this.btnUpdateFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectTemplate);
            this.Name = "EditTemplates";
            this.Size = new System.Drawing.Size(869, 585);
            this.grpSection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateFields;
        private System.Windows.Forms.FlowLayoutPanel flSectionButtons;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.FlowLayoutPanel flSection;
        private System.Windows.Forms.Button btnDeleteSection;
        private System.Windows.Forms.Button btnAddComment;
    }
}
