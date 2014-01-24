using StUtil.Native.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StUtils.Renamer
{
    public partial class ExpressionsPage : UserControl
    {
        private ExpressionItem firstItem;
        private ExpressionItem secondLastItem;

        public ExpressionsPage()
        {
            InitializeComponent();
            AddItem();
        }

        private void AddItem()
        {
            ExpressionItem item = new ExpressionItem();
            if (firstItem == null)
            {
                firstItem = item;
            }
            else if (secondLastItem == null)
            {
                secondLastItem = item;
            }

            item.TextChanged += item_TextChanged;
            item.TextCleared += item_TextCleared;

            topDockPanel1.SuspendDrawing();
            topDockPanel1.AddControl(item);
            topDockPanel1.ResumeDrawing();
        }

        private void item_TextCleared(object sender, EventArgs e)
        {
            ExpressionItem item = (ExpressionItem)sender;
            if (item == secondLastItem && item != firstItem)
            {
                Control parent = item.Parent;
                parent.Controls.Remove(item);
                secondLastItem = (ExpressionItem)parent.Controls[parent.Controls.Count - 2];
            }
        }

        private void item_TextChanged(object sender, EventArgs e)
        {
            ExpressionItem item = (ExpressionItem)sender;
            if (item == secondLastItem || secondLastItem == null)
            {
                AddItem();
            }
        }
    }
}
