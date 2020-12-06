namespace HappyTech.Components.Templates
{
    partial class Section
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
            this.lblSectionName = new System.Windows.Forms.Label();
            this.flpComments = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSectionName
            // 
            this.lblSectionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            this.lblSectionName.Location = new System.Drawing.Point(0, 0);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(611, 28);
            this.lblSectionName.TabIndex = 0;
            this.lblSectionName.Text = "Section Name";
            this.lblSectionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpComments
            // 
            this.flpComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpComments.Location = new System.Drawing.Point(0, 31);
            this.flpComments.Name = "flpComments";
            this.flpComments.Size = new System.Drawing.Size(608, 53);
            this.flpComments.TabIndex = 1;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.flpComments);
            this.Controls.Add(this.lblSectionName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Section";
            this.Size = new System.Drawing.Size(611, 87);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.FlowLayoutPanel flpComments;
    }
}
