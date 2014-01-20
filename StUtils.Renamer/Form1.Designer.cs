using StUtil.UI.Controls;
namespace StUtils.Renamer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlBottomRight = new System.Windows.Forms.Panel();
            this.pgbProgress = new StUtil.UI.Controls.DarkBlueProgressBar();
            this.pnlBottomLeft = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlBottomBorder = new System.Windows.Forms.Panel();
            this.pnlStage = new System.Windows.Forms.Panel();
            this.lblRename = new ColorFaderLabel();
            this.lblPreview = new ColorFaderLabel();
            this.lblDefineExpressions = new ColorFaderLabel();
            this.lblSelectFiles = new ColorFaderLabel();
            this.pnlBottom.SuspendLayout();
            this.pnlBottomRight.SuspendLayout();
            this.pnlBottomLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlBottomRight);
            this.pnlBottom.Controls.Add(this.pnlBottomLeft);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 537);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1170, 30);
            this.pnlBottom.TabIndex = 12;
            // 
            // pnlBottomRight
            // 
            this.pnlBottomRight.Controls.Add(this.pgbProgress);
            this.pnlBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomRight.Location = new System.Drawing.Point(49, 0);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.Padding = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.pnlBottomRight.Size = new System.Drawing.Size(1121, 30);
            this.pnlBottomRight.TabIndex = 14;
            // 
            // pgbProgress
            // 
            this.pgbProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.pgbProgress.BarImage = ((System.Drawing.Image)(resources.GetObject("pgbProgress.BarImage")));
            this.pgbProgress.BarMargins = new System.Windows.Forms.Padding(10, 2, 50, 2);
            this.pgbProgress.CustomLabel = null;
            this.pgbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbProgress.DrawLabel = true;
            this.pgbProgress.EnableAnimation = false;
            this.pgbProgress.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.pgbProgress.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.pgbProgress.GradientInnerModifier = ((sbyte)(0));
            this.pgbProgress.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.pgbProgress.LabelOffset = new System.Drawing.Point(11, -7);
            this.pgbProgress.LabelOffsetX = StUtil.UI.Controls.CustomProgressBar.LabelXOffsetEnum.FromBarRight;
            this.pgbProgress.LabelOffsetY = StUtil.UI.Controls.CustomProgressBar.LabelYOffsetEnum.FromBarMiddle;
            this.pgbProgress.LabelOfString = "/";
            this.pgbProgress.LabelType = StUtil.UI.Controls.CustomProgressBar.LabelTypeEnum.Percent;
            this.pgbProgress.Location = new System.Drawing.Point(0, 5);
            this.pgbProgress.MaxValue = ((long)(100));
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(1111, 20);
            this.pgbProgress.Step = ((long)(1));
            this.pgbProgress.TabIndex = 1;
            this.pgbProgress.Value = ((long)(0));
            // 
            // pnlBottomLeft
            // 
            this.pnlBottomLeft.AutoSize = true;
            this.pnlBottomLeft.Controls.Add(this.lblStatus);
            this.pnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomLeft.Name = "pnlBottomLeft";
            this.pnlBottomLeft.Size = new System.Drawing.Size(49, 30);
            this.pnlBottomLeft.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(17, 6, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(46, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Idle";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottomBorder
            // 
            this.pnlBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.pnlBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBorder.Location = new System.Drawing.Point(0, 536);
            this.pnlBottomBorder.Name = "pnlBottomBorder";
            this.pnlBottomBorder.Size = new System.Drawing.Size(1170, 1);
            this.pnlBottomBorder.TabIndex = 13;
            // 
            // pnlStage
            // 
            this.pnlStage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStage.Location = new System.Drawing.Point(29, 29);
            this.pnlStage.Name = "pnlStage";
            this.pnlStage.Size = new System.Drawing.Size(1113, 442);
            this.pnlStage.TabIndex = 22;
            // 
            // lblRename
            // 
            this.lblRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRename.AutoSize = true;
            this.lblRename.BackColor = System.Drawing.Color.Transparent;
            this.lblRename.BackgroundFadeEnabled = true;
            this.lblRename.BackgroundFadeSpeed = 20;
            this.lblRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRename.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRename.ForegroundFadeEnabled = true;
            this.lblRename.ForegroundFadeSpeed = 10;
            this.lblRename.Location = new System.Drawing.Point(552, 487);
            this.lblRename.Name = "lblRename";
            this.lblRename.Size = new System.Drawing.Size(105, 33);
            this.lblRename.TabIndex = 21;
            this.lblRename.Tag = "";
            this.lblRename.Text = "Rename";
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.BackgroundFadeEnabled = true;
            this.lblPreview.BackgroundFadeSpeed = 20;
            this.lblPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreview.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPreview.ForegroundFadeEnabled = true;
            this.lblPreview.ForegroundFadeSpeed = 10;
            this.lblPreview.Location = new System.Drawing.Point(426, 487);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(101, 33);
            this.lblPreview.TabIndex = 20;
            this.lblPreview.Tag = "";
            this.lblPreview.Text = "Preview";
            // 
            // lblDefineExpressions
            // 
            this.lblDefineExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDefineExpressions.AutoSize = true;
            this.lblDefineExpressions.BackColor = System.Drawing.Color.Transparent;
            this.lblDefineExpressions.BackgroundFadeEnabled = true;
            this.lblDefineExpressions.BackgroundFadeSpeed = 20;
            this.lblDefineExpressions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDefineExpressions.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblDefineExpressions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDefineExpressions.ForegroundFadeEnabled = true;
            this.lblDefineExpressions.ForegroundFadeSpeed = 10;
            this.lblDefineExpressions.Location = new System.Drawing.Point(181, 487);
            this.lblDefineExpressions.Name = "lblDefineExpressions";
            this.lblDefineExpressions.Size = new System.Drawing.Size(220, 33);
            this.lblDefineExpressions.TabIndex = 19;
            this.lblDefineExpressions.Tag = "";
            this.lblDefineExpressions.Text = "Define Expressions";
            // 
            // lblSelectFiles
            // 
            this.lblSelectFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectFiles.AutoSize = true;
            this.lblSelectFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectFiles.BackgroundFadeEnabled = true;
            this.lblSelectFiles.BackgroundFadeSpeed = 20;
            this.lblSelectFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelectFiles.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblSelectFiles.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSelectFiles.ForegroundFadeEnabled = true;
            this.lblSelectFiles.ForegroundFadeSpeed = 10;
            this.lblSelectFiles.Location = new System.Drawing.Point(23, 487);
            this.lblSelectFiles.Name = "lblSelectFiles";
            this.lblSelectFiles.Size = new System.Drawing.Size(133, 33);
            this.lblSelectFiles.TabIndex = 18;
            this.lblSelectFiles.Tag = "";
            this.lblSelectFiles.Text = "Select Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1170, 567);
            this.Controls.Add(this.pnlStage);
            this.Controls.Add(this.lblRename);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.lblDefineExpressions);
            this.Controls.Add(this.lblSelectFiles);
            this.Controls.Add(this.pnlBottomBorder);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlBottomRight.ResumeLayout(false);
            this.pnlBottomLeft.ResumeLayout(false);
            this.pnlBottomLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlBottomBorder;
        private System.Windows.Forms.Panel pnlBottomLeft;
        private System.Windows.Forms.Panel pnlBottomRight;
        private System.Windows.Forms.Label lblStatus;
        private StUtil.UI.Controls.DarkBlueProgressBar pgbProgress;
        private ColorFaderLabel lblSelectFiles;
        private ColorFaderLabel lblDefineExpressions;
        private ColorFaderLabel lblPreview;
        private ColorFaderLabel lblRename;
        private System.Windows.Forms.Panel pnlStage;
    }
}

