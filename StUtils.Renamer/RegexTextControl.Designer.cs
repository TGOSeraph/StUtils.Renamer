namespace StUtils.Renamer
{
    partial class RegexTextControl
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
            this.components = new System.ComponentModel.Container();
            this.RegexTextBox = new StUtils.Renamer.RegexTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // RegexTextBox
            // 
            this.RegexTextBox.AutoWordSelection = true;
            this.RegexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegexTextBox.DetectUrls = false;
            this.RegexTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegexTextBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.RegexTextBox.Location = new System.Drawing.Point(4, 3);
            this.RegexTextBox.Name = "RegexTextBox";
            this.RegexTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RegexTextBox.Size = new System.Drawing.Size(586, 24);
            this.RegexTextBox.TabIndex = 1;
            this.RegexTextBox.Text = "";
            this.RegexTextBox.WordWrap = false;
            // 
            // RegexTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RegexTextBox);
            this.Name = "RegexTextControl";
            this.Padding = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.Size = new System.Drawing.Size(594, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public RegexTextBox RegexTextBox;

    }
}
