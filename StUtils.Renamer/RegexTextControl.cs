using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StUtil.Native.Extensions;
using StUtil.Native.Misc;
using System.Diagnostics;

namespace StUtils.Renamer
{
    public partial class RegexTextControl : UserControl
    {
        private bool hScrollVisible = false;

        public RegexTextControl()
        {
            InitializeComponent();

            this.regexTextBox1.TextChanged += regexTextBox1_TextChanged;
        }

        private void regexTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool isVisible = regexTextBox1.IsHScrollVisible();
            if (isVisible && !hScrollVisible)
            {
                this.Height += SystemInformation.HorizontalScrollBarHeight;
                hScrollVisible = true;
            }
            else if(!isVisible && hScrollVisible)
            {
                this.Height -= SystemInformation.HorizontalScrollBarHeight;
                hScrollVisible = false;
            }
        }
    }
}
