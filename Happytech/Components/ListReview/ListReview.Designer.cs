namespace Happytech.Components.ListReview
{
    partial class ListReview
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
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayout.Location = new System.Drawing.Point(0, 0);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(298, 551);
            this.FlowLayout.TabIndex = 0;
            this.FlowLayout.WrapContents = false;
            // 
            // ListReview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.FlowLayout);
            this.Name = "ListReview";
            this.Size = new System.Drawing.Size(298, 551);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
    }
}
