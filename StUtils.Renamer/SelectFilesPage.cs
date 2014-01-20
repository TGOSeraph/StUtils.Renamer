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

namespace StUtils.Renamer
{
    public partial class SelectFilesPage : UserControl
    {
        private Regex currentExpression;

        public SelectFilesPage()
        {
            InitializeComponent();
            this.explorerTreeView1.AfterSelect += explorerTreeView1_AfterSelect;
        }

        private void explorerTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
            }
            catch (Exception)
            {
            }
        }

        private void llblAddChecked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem lvi in listView1.CheckedItems)
            {
                if (!listView2.Items.Cast<ListViewItem>().Any(v => v.Text == (string)lvi.Tag))
                {
                    listView2.Items.Add(new ListViewItem((string)lvi.Tag));
                }
            }
        }
    }
}
