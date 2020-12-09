namespace HappyTech.Pages
{
    partial class Replying
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
            this.btnPrevCandidate = new System.Windows.Forms.Button();
            this.btnNextCandidate = new System.Windows.Forms.Button();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.pdfReader = new PdfiumViewer.PdfViewer();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flpTemplate = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pReview = new System.Windows.Forms.Panel();
            this.pView = new System.Windows.Forms.Panel();
            this.txtViewResponse = new System.Windows.Forms.RichTextBox();
            this.pReview.SuspendLayout();
            this.pView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnBack.Location = new System.Drawing.Point(895, 544);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 45);
            this.btnBack.TabIndex = 17;
            this.btnBack.Tag = "";
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnPrevCandidate
            // 
            this.btnPrevCandidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnPrevCandidate.Enabled = false;
            this.btnPrevCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevCandidate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnPrevCandidate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnPrevCandidate.Location = new System.Drawing.Point(3, 3);
            this.btnPrevCandidate.Name = "btnPrevCandidate";
            this.btnPrevCandidate.Size = new System.Drawing.Size(60, 45);
            this.btnPrevCandidate.TabIndex = 18;
            this.btnPrevCandidate.Tag = "Previous";
            this.btnPrevCandidate.Text = "<";
            this.btnPrevCandidate.UseVisualStyleBackColor = false;
            this.btnPrevCandidate.Click += new System.EventHandler(this.ChangeCandidate);
            // 
            // btnNextCandidate
            // 
            this.btnNextCandidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnNextCandidate.Enabled = false;
            this.btnNextCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCandidate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNextCandidate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnNextCandidate.Location = new System.Drawing.Point(379, 3);
            this.btnNextCandidate.Name = "btnNextCandidate";
            this.btnNextCandidate.Size = new System.Drawing.Size(60, 45);
            this.btnNextCandidate.TabIndex = 19;
            this.btnNextCandidate.Tag = "Next";
            this.btnNextCandidate.Text = ">";
            this.btnNextCandidate.UseVisualStyleBackColor = false;
            this.btnNextCandidate.Click += new System.EventHandler(this.ChangeCandidate);
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCandidateName.Location = new System.Drawing.Point(69, 3);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(304, 45);
            this.lblCandidateName.TabIndex = 20;
            this.lblCandidateName.Text = "Candidate Name";
            this.lblCandidateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pdfReader
            // 
            this.pdfReader.Location = new System.Drawing.Point(3, 54);
            this.pdfReader.Name = "pdfReader";
            this.pdfReader.Size = new System.Drawing.Size(436, 553);
            this.pdfReader.TabIndex = 21;
            // 
            // cbTemplate
            // 
            this.cbTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTemplate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbTemplate.ForeColor = System.Drawing.Color.White;
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Location = new System.Drawing.Point(7, 21);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(367, 27);
            this.cbTemplate.TabIndex = 26;
            this.cbTemplate.Tag = "Role";
            this.cbTemplate.SelectedIndexChanged += new System.EventHandler(this.cbTemplate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Template";
            // 
            // flpTemplate
            // 
            this.flpTemplate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTemplate.Location = new System.Drawing.Point(7, 54);
            this.flpTemplate.Name = "flpTemplate";
            this.flpTemplate.Size = new System.Drawing.Size(611, 481);
            this.flpTemplate.TabIndex = 28;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.btnNext.Location = new System.Drawing.Point(703, 544);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 45);
            this.btnNext.TabIndex = 29;
            this.btnNext.Tag = "Preview";
            this.btnNext.Text = "Preview Responses";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnPreviewResponses_Click);
            // 
            // pReview
            // 
            this.pReview.Controls.Add(this.pView);
            this.pReview.Controls.Add(this.label4);
            this.pReview.Controls.Add(this.cbTemplate);
            this.pReview.Controls.Add(this.flpTemplate);
            this.pReview.Location = new System.Drawing.Point(449, 3);
            this.pReview.Name = "pReview";
            this.pReview.Size = new System.Drawing.Size(628, 535);
            this.pReview.TabIndex = 30;
            // 
            // pView
            // 
            this.pView.Controls.Add(this.txtViewResponse);
            this.pView.Location = new System.Drawing.Point(0, 0);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(628, 535);
            this.pView.TabIndex = 31;
            this.pView.Visible = false;
            // 
            // txtViewResponse
            // 
            this.txtViewResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.txtViewResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtViewResponse.ForeColor = System.Drawing.Color.White;
            this.txtViewResponse.Location = new System.Drawing.Point(3, 3);
            this.txtViewResponse.Name = "txtViewResponse";
            this.txtViewResponse.ReadOnly = true;
            this.txtViewResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtViewResponse.Size = new System.Drawing.Size(622, 529);
            this.txtViewResponse.TabIndex = 0;
            this.txtViewResponse.Text = "";
            // 
            // Replying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pdfReader);
            this.Controls.Add(this.lblCandidateName);
            this.Controls.Add(this.btnNextCandidate);
            this.Controls.Add(this.btnPrevCandidate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pReview);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Replying";
            this.Size = new System.Drawing.Size(1080, 610);
            this.pReview.ResumeLayout(false);
            this.pReview.PerformLayout();
            this.pView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrevCandidate;
        private System.Windows.Forms.Button btnNextCandidate;
        private System.Windows.Forms.Label lblCandidateName;
        private PdfiumViewer.PdfViewer pdfReader;
        private System.Windows.Forms.ComboBox cbTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpTemplate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pReview;
        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.RichTextBox txtViewResponse;
    }
}
