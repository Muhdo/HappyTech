namespace HappyTech.Components
{
    partial class SectionButton
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
            this.lblSection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSection.Location = new System.Drawing.Point(64, 19);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(74, 21);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "Section X";
            this.lblSection.Click += new System.EventHandler(this.lblSection_Click);
            // 
            // SectionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.lblSection);
            this.Name = "SectionButton";
            this.Size = new System.Drawing.Size(212, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
    }
}
