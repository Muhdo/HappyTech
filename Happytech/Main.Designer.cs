namespace Happytech
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pWindow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pWindow
            // 
            resources.ApplyResources(this.pWindow, "pWindow");
            this.pWindow.ForeColor = System.Drawing.Color.White;
            this.pWindow.Name = "pWindow";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.pWindow);
            this.Name = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pWindow;
    }
}

