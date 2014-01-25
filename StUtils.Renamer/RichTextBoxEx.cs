using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using StUtil.Extensions;
using StUtil.Utilities;

namespace StUtils.Renamer
{
    public class RichTextBoxEx : RichTextBox
    {
        public event EventHandler OnUserStopTyping;
        private DelayedInvokeState state;

        public RichTextBoxEx()
        {
            this.TextChanged += RichTextBoxEx_TextChanged;
        }

        private void RichTextBoxEx_TextChanged(object sender, EventArgs e)
        {
            if (state != null && !state.HasReturned && !state.HasAborted)
            {
                state.Abort();
            }
            state = ((Action)(delegate()
            {
                state = null;
                this.Invoke((Action)delegate()
                {
                    OnUserStopTyping.RaiseEvent(this);
                });
            })).DelayedInvoke(500);
        }
    }
}
