namespace StUtils.Renamer
{
    partial class ExpressionItem
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
            this.llblGroups = new System.Windows.Forms.LinkLabel();
            this.llblMatches = new System.Windows.Forms.LinkLabel();
            this.rtcRegexControl = new StUtils.Renamer.RegexTextControl();
            this.SuspendLayout();
            // 
            // llblGroups
            // 
            this.llblGroups.ActiveLinkColor = System.Drawing.Color.White;
            this.llblGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblGroups.AutoSize = true;
            this.llblGroups.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.llblGroups.Location = new System.Drawing.Point(162, 7);
            this.llblGroups.Name = "llblGroups";
            this.llblGroups.Size = new System.Drawing.Size(48, 13);
            this.llblGroups.TabIndex = 11;
            this.llblGroups.TabStop = true;
            this.llblGroups.Text = "0 groups";
            // 
            // llblMatches
            // 
            this.llblMatches.ActiveLinkColor = System.Drawing.Color.White;
            this.llblMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblMatches.AutoSize = true;
            this.llblMatches.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.llblMatches.Location = new System.Drawing.Point(216, 7);
            this.llblMatches.Name = "llblMatches";
            this.llblMatches.Size = new System.Drawing.Size(56, 13);
            this.llblMatches.TabIndex = 12;
            this.llblMatches.TabStop = true;
            this.llblMatches.Text = "0 matches";
            // 
            // rtcRegexControl
            // 
            this.rtcRegexControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtcRegexControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.rtcRegexControl.Location = new System.Drawing.Point(0, 3);
            this.rtcRegexControl.Name = "rtcRegexControl";
            this.rtcRegexControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.rtcRegexControl.Size = new System.Drawing.Size(156, 22);
            this.rtcRegexControl.TabIndex = 10;
            // 
            // ExpressionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.llblMatches);
            this.Controls.Add(this.llblGroups);
            this.Controls.Add(this.rtcRegexControl);
            this.Name = "ExpressionItem";
            this.Size = new System.Drawing.Size(279, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegexTextControl rtcRegexControl;
        private System.Windows.Forms.LinkLabel llblGroups;
        private System.Windows.Forms.LinkLabel llblMatches;
    }
}
