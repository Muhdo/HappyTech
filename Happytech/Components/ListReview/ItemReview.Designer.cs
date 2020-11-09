namespace Happytech.Components.ListReview
{
    partial class ItemReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemReview));
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCurriculum = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Name = "lblName";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCurriculum.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCurriculum, "btnCurriculum");
            this.btnCurriculum.ForeColor = System.Drawing.Color.White;
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.TabStop = false;
            this.btnCurriculum.UseVisualStyleBackColor = false;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnApplication.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnApplication, "btnApplication");
            this.btnApplication.ForeColor = System.Drawing.Color.White;
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.TabStop = false;
            this.btnApplication.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCurriculum);
            this.panel1.Controls.Add(this.btnApplication);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ItemReview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.panel1);
            this.Name = "ItemReview";
            resources.ApplyResources(this, "$this");
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCurriculum;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Panel panel1;
    }
}
