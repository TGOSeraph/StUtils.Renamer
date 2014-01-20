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
            this.regexTextBox1 = new StUtils.Renamer.RegexTextBox();
            this.SuspendLayout();
            // 
            // regexTextBox1
            // 
            this.regexTextBox1.AutoWordSelection = true;
            this.regexTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regexTextBox1.DetectUrls = false;
            this.regexTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regexTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.regexTextBox1.Location = new System.Drawing.Point(4, 3);
            this.regexTextBox1.Name = "regexTextBox1";
            this.regexTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.regexTextBox1.Size = new System.Drawing.Size(586, 24);
            this.regexTextBox1.TabIndex = 1;
            this.regexTextBox1.Text = "";
            this.regexTextBox1.WordWrap = false;
            // 
            // RegexTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.regexTextBox1);
            this.Name = "RegexTextControl";
            this.Padding = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.Size = new System.Drawing.Size(594, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private RegexTextBox regexTextBox1;

    }
}
