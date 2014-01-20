namespace StUtils.Renamer
{
    partial class SelectFilesPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.llblAddChecked = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.pnlExplorer = new System.Windows.Forms.Panel();
            this.explorerTreeView1 = new StUtil.UI.Controls.Explorer.ExplorerTreeView();
            this.regexTextBox1 = new StUtils.Renamer.RegexTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlExplorer);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(994, 469);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pnlFiles);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.splitContainer2.Size = new System.Drawing.Size(771, 469);
            this.splitContainer2.SplitterDistance = 354;
            this.splitContainer2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llblAddChecked);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.regexTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 40);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter: (Regex)";
            // 
            // llblAddChecked
            // 
            this.llblAddChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblAddChecked.AutoSize = true;
            this.llblAddChecked.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAddChecked.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblAddChecked.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.llblAddChecked.Location = new System.Drawing.Point(276, 4);
            this.llblAddChecked.Name = "llblAddChecked";
            this.llblAddChecked.Size = new System.Drawing.Size(75, 15);
            this.llblAddChecked.TabIndex = 2;
            this.llblAddChecked.TabStop = true;
            this.llblAddChecked.Text = "Add checked";
            this.llblAddChecked.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAddChecked_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected Files";
            // 
            // pnlFiles
            // 
            this.pnlFiles.BackColor = System.Drawing.Color.White;
            this.pnlFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiles.Controls.Add(this.listView1);
            this.pnlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiles.Location = new System.Drawing.Point(5, 18);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFiles.Size = new System.Drawing.Size(344, 411);
            this.pnlFiles.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(5, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 397);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Explorer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 18);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(403, 451);
            this.panel2.TabIndex = 4;
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(5, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(389, 437);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // pnlExplorer
            // 
            this.pnlExplorer.BackColor = System.Drawing.Color.White;
            this.pnlExplorer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExplorer.Controls.Add(this.explorerTreeView1);
            this.pnlExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExplorer.Location = new System.Drawing.Point(5, 18);
            this.pnlExplorer.Name = "pnlExplorer";
            this.pnlExplorer.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.pnlExplorer.Size = new System.Drawing.Size(209, 451);
            this.pnlExplorer.TabIndex = 4;
            // 
            // explorerTreeView1
            // 
            this.explorerTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explorerTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerTreeView1.HideSelection = false;
            this.explorerTreeView1.Location = new System.Drawing.Point(0, 5);
            this.explorerTreeView1.Name = "explorerTreeView1";
            this.explorerTreeView1.Size = new System.Drawing.Size(200, 442);
            this.explorerTreeView1.TabIndex = 1;
            // 
            // regexTextBox1
            // 
            this.regexTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.regexTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.regexTextBox1.Location = new System.Drawing.Point(0, 20);
            this.regexTextBox1.Name = "regexTextBox1";
            this.regexTextBox1.Size = new System.Drawing.Size(344, 20);
            this.regexTextBox1.TabIndex = 1;
            this.regexTextBox1.Text = "";
            this.regexTextBox1.TextChanged += new System.EventHandler(this.regexTextBox1_TextChanged);
            // 
            // SelectFilesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SelectFilesPage";
            this.Size = new System.Drawing.Size(994, 469);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFiles.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlExplorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private RegexTextBox regexTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblAddChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel pnlExplorer;
        private StUtil.UI.Controls.Explorer.ExplorerTreeView explorerTreeView1;



    }
}
