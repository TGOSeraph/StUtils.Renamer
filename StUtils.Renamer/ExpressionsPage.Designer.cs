namespace StUtils.Renamer
{
    partial class ExpressionsPage
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
            this.label4 = new System.Windows.Forms.Label();
            this.topDockPanel1 = new StUtil.UI.Controls.TopDockPanel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expressions";
            // 
            // topDockPanel1
            // 
            this.topDockPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.topDockPanel1.AutoDockControls = true;
            this.topDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.topDockPanel1.Location = new System.Drawing.Point(3, 27);
            this.topDockPanel1.Name = "topDockPanel1";
            this.topDockPanel1.Size = new System.Drawing.Size(473, 395);
            this.topDockPanel1.TabIndex = 5;
            // 
            // ExpressionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topDockPanel1);
            this.Controls.Add(this.label4);
            this.Name = "ExpressionsPage";
            this.Size = new System.Drawing.Size(749, 428);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private StUtil.UI.Controls.TopDockPanel topDockPanel1;
    }
}
