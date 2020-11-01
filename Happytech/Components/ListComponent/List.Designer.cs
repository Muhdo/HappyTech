namespace Happytech.Components.ListComponent
{
    partial class List
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
            this.VerticalFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // VerticalFlow
            // 
            this.VerticalFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.VerticalFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.VerticalFlow.Location = new System.Drawing.Point(0, 0);
            this.VerticalFlow.Margin = new System.Windows.Forms.Padding(0);
            this.VerticalFlow.Name = "VerticalFlow";
            this.VerticalFlow.Size = new System.Drawing.Size(298, 548);
            this.VerticalFlow.TabIndex = 0;
            this.VerticalFlow.WrapContents = false;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.VerticalFlow);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "List";
            this.Size = new System.Drawing.Size(298, 548);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel VerticalFlow;
    }
}
