using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using StUtil.Generic;
using StUtil.Extensions;

namespace StUtils.Renamer
{
    public partial class ExpressionItem : UserControl
    {
        public event EventHandler TextCleared;
        public event EventHandler TextChanged;

        public event EventHandler<EventArgs<List<string>>> RequestFileList;

        private List<string> matchedFiles = new List<string>();
        private List<string> groupNames = new List<string>();

        public ExpressionItem()
        {
            InitializeComponent();

            this.rtcRegexControl.RegexTextBox.OnUserStopTyping += RegexTextBox_OnUserStopTyping;
            this.rtcRegexControl.RegexTextBox.LostFocus += RegexTextBox_LostFocus;
        }

        private void RegexTextBox_LostFocus(object sender, EventArgs e)
        {
            if (this.rtcRegexControl.RegexTextBox.Text.Length == 0)
            {
                TextCleared.RaiseEvent(this);
            }
        }

        private void RegexTextBox_OnUserStopTyping(object sender, EventArgs e)
        {
            if (this.rtcRegexControl.RegexTextBox.Text.Length != 0)
            {
                TextChanged.RaiseEvent(this);
            }
            if (!this.rtcRegexControl.RegexTextBox.HasRegexError)
            {
                try
                {
                    Regex regex = new Regex(this.rtcRegexControl.RegexTextBox.Text);
                    EventArgs<List<string>> filesEvent = new EventArgs<List<string>>();
                    RequestFileList.RaiseEvent(this, filesEvent);

                    UpdateGroups(regex.GetGroupNames());
                }
                catch (Exception)
                {
                }
            }
        }

        private void UpdateGroups(string[] names)
        {
            groupNames.Clear();
            groupNames.AddRange(names);
            llblGroups.Text = groupNames.Count + " Groups";
        }

        private void UpdateMatches(string[] files)
        {
            matchedFiles.Clear();
            matchedFiles.AddRange(files);
            llblGroups.Text = matchedFiles.Count + " Matches";
        }
    }
}
