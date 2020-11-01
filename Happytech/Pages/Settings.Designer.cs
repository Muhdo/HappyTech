namespace Happytech.Pages
{
    partial class Settings
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
            this.lstEmployees = new Happytech.Components.ListComponent.List();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lstEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstEmployees.ForeColor = System.Drawing.Color.White;
            this.lstEmployees.Location = new System.Drawing.Point(21, 19);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(300, 550);
            this.lstEmployees.TabIndex = 0;
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
            this.btnBack.TabIndex = 16;
            this.btnBack.Tag = "";
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstEmployees);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1080, 610);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ListComponent.List lstEmployees;
        private System.Windows.Forms.Button btnBack;
    }
}
