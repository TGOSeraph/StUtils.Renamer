using StUtil.UI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StUtils.Renamer
{
    public partial class Form1 : Form
    {
        private ColorFaderLabel currentSelectedLabel;
        private Dictionary<Label, Control> pages = new Dictionary<Label, Control>();

        public Form1()
        {
            InitializeComponent();

            currentSelectedLabel = lblSelectFiles;

            this.lblSelectFiles.MouseEnter += colorFaderLabel_MouseEnter;
            this.lblSelectFiles.MouseLeave += colorFaderLabel_MouseLeave;
            this.lblSelectFiles.Click += colorFaderLabel_Click;
            AddPage(this.lblSelectFiles, new SelectFilesPage());

            this.lblDefineExpressions.MouseEnter += colorFaderLabel_MouseEnter;
            this.lblDefineExpressions.MouseLeave += colorFaderLabel_MouseLeave;
            this.lblDefineExpressions.Click += colorFaderLabel_Click;
            AddPage(this.lblDefineExpressions, new ExpressionsPage());

            this.lblPreview.MouseEnter += colorFaderLabel_MouseEnter;
            this.lblPreview.MouseLeave += colorFaderLabel_MouseLeave;
            this.lblPreview.Click += colorFaderLabel_Click;
            AddPage(this.lblPreview, new PreviewPage());

            this.lblRename.MouseEnter += colorFaderLabel_MouseEnter;
            this.lblRename.MouseLeave += colorFaderLabel_MouseLeave;
            this.lblRename.Click += colorFaderLabel_Click;
            AddPage(this.lblRename, new PreviewPage());

            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void AddPage(Label lbl, Control page)
        {
            page.Dock = DockStyle.Fill;
            if (pages.Count > 0)
            {
                page.Visible = false;
            }
            pnlStage.Controls.Add(page);
            pages.Add(lbl, page);
        }

        private void colorFaderLabel_Click(object sender, EventArgs e)
        {
            ColorFaderLabel lbl = (ColorFaderLabel)sender;
            if (lbl != currentSelectedLabel)
            {
                pages[currentSelectedLabel].Visible = false;
                pages[lbl].Visible = true;

                currentSelectedLabel.ForeColor = this.ForeColor;
                currentSelectedLabel = lbl;
                currentSelectedLabel.ForeColor = SystemColors.Highlight;
            }
        }

        private void colorFaderLabel_MouseLeave(object sender, EventArgs e)
        {
            ColorFaderLabel lbl = (ColorFaderLabel)sender;
            if (lbl == currentSelectedLabel)
            {
                lbl.ForeColor = SystemColors.Highlight;
            }
            else
            {
                lbl.ForeColor = this.ForeColor;
            }
        }
        private void colorFaderLabel_MouseEnter(object sender, EventArgs e)
        {
            ColorFaderLabel lbl = (ColorFaderLabel)sender;
            if (lbl != currentSelectedLabel)
            {
                lbl.ForeColor = Color.Orange;
            }
        }
    }
}