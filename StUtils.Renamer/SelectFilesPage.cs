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
            this.explorerTreeView1.NodeMouseClick += explorerTreeView1_NodeMouseClick;
            lvAdded.HeaderStyle = ColumnHeaderStyle.None;
            regexTextBox1.Text = Properties.Settings.Default.Filter;
        }

        private void explorerTreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                explorerTreeView1.SelectedNode = e.Node;
            }
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

        private void AddItem(ListViewItem lvi)
        {
            if (!lvAdded.Items.Cast<ListViewItem>().Any(v => v.Text == (string)lvi.Tag))
            {
                lvAdded.Items.Add(new ListViewItem((string)lvi.Tag));
            }
        }
        private void llblAddChecked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem lvi in listView1.CheckedItems)
            {
                AddItem(lvi);
            }
            lvAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void checkSelectedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                lvi.Checked = true;
            }
        }

        private void uncheckSelectedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                lvi.Checked = false;
            }
        }

        private void toggleCheckOnSelectedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                lvi.Checked = !lvi.Checked;
            }
        }

        private void addSelectedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                AddItem(lvi);
            }
            lvAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void removeSelectedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvAdded.SelectedItems)
            {
                lvAdded.Items.Remove(lvi);
            }
            lvAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void AddFilesInPath(string path, bool recurse)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                try
                {
                    if (Directory.Exists(path))
                    {
                        foreach (string file in Directory.GetFiles(path))
                        {
                            AddItem(new ListViewItem(Path.GetFileName(file))
                            {
                                Tag = file
                            });
                        }
                        if (recurse)
                        {
                            foreach (string dir in Directory.GetDirectories(path))
                            {
                                AddFilesInPath(dir, recurse);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void addFilesInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (explorerTreeView1.SelectedNode != null)
            {
                string path = ((ShellItem)explorerTreeView1.SelectedNode.Tag).Path;
                AddFilesInPath(path, false);
                lvAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void addFilesInFolderRecursiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (explorerTreeView1.SelectedNode != null)
            {
                string path = ((ShellItem)explorerTreeView1.SelectedNode.Tag).Path;
                AddFilesInPath(path, true);
                lvAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
    }
}
