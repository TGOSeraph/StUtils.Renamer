using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StUtil.UI.Controls.Explorer;
using System.IO;
using StUtil.Native.Extensions;

namespace StUtils.Renamer
{
    public partial class SelectFilesPage : UserControl
    {
        private Regex currentExpression;

        public SelectFilesPage()
        {
            InitializeComponent();
            this.explorerTreeView1.AfterSelect += explorerTreeView1_AfterSelect;
            lvAdded.HeaderStyle = ColumnHeaderStyle.None;
            regexTextBox1.Text = Properties.Settings.Default.Filter;
        }

        private void explorerTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            explorerTreeView1.SuspendDrawing();
            if (!e.Node.IsExpanded)
            {
                e.Node.Expand();
                e.Node.Collapse();
            }
            explorerTreeView1.ResumeDrawing();
            listView1.Items.Clear();
            string path = ((ShellItem)e.Node.Tag).Path;
            if (!string.IsNullOrWhiteSpace(path))
            {
                try
                {
                    if (Directory.Exists(path))
                    {
                        listView1.Items.AddRange(Directory.GetFiles(path).Select(f => new ListViewItem(Path.GetFileName(f))
                        {
                            Tag = f,
                            Checked = currentExpression == null ? true : currentExpression.IsMatch(Path.GetFileName(f))
                        }).ToArray());
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void regexTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentExpression = new Regex(regexTextBox1.Text);
                foreach (ListViewItem lvi in listView1.Items)
                {
                    lvi.Checked = currentExpression.IsMatch(lvi.Text);
                }
                Properties.Settings.Default.Filter = regexTextBox1.Text;
            }
            catch (Exception)
            {
            }
        }

        private void llblAddChecked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem lvi in listView1.CheckedItems)
            {
                if (!lvAdded.Items.Cast<ListViewItem>().Any(v => v.Text == (string)lvi.Tag))
                {
                    lvAdded.Items.Add(new ListViewItem((string)lvi.Tag));
                }
            }
            lvAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
