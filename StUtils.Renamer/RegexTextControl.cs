using StUtil.Native.Extensions;
using StUtilEx.RegexParser;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StUtils.Renamer
{
    public partial class RegexTextControl : UserControl
    {
        private bool hScrollVisible = false;

        public RegexTextControl()
        {
            InitializeComponent();

            this.regexTextBox1.TextChanged += regexTextBox1_TextChanged;
            this.regexTextBox1.MouseHover += regexTextBox1_MouseHover;
        }

        private static string AddSpacesToSentence(string text, bool preserveAcronyms)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    if ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) &&
                         i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                        newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }

        private RegexPart GetPartUnderMouse()
        {
            Point pt = regexTextBox1.PointToClient(Cursor.Position);
            int index = regexTextBox1.GetCharIndexFromPosition(pt);
            RegexPart part = regexTextBox1.Parts;
            while (true)
            {
                bool found = false;
                foreach (RegexPart child in part.Parts)
                {
                    if (child.Index <= index && child.Index + child.ToString().Length > index)
                    {
                        found = true;
                        part = child;
                        break;
                    }
                }
                if (!found)
                {
                    return part;
                }
            }
        }

        private void regexTextBox1_MouseHover(object sender, EventArgs e)
        {
            RegexPart part = GetPartUnderMouse();
            Point pt = regexTextBox1.PointToClient(Cursor.Position);
            if (part.Type != PartType.Root)
            {
                toolTip1.Show(part.Error != ErrorType.None
                    ? (AddSpacesToSentence(part.Error.ToString(), true) + " (" + AddSpacesToSentence(part.Type.ToString(), true) + ")")
                    : AddSpacesToSentence(part.Type.ToString(), true), regexTextBox1, new Point(pt.X, regexTextBox1.Bottom), 3000);
            }
        }

        private void regexTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool isVisible = regexTextBox1.IsHScrollVisible();
            if (isVisible && !hScrollVisible)
            {
                this.Height += SystemInformation.HorizontalScrollBarHeight;
                hScrollVisible = true;
            }
            else if (!isVisible && hScrollVisible)
            {
                this.Height -= SystemInformation.HorizontalScrollBarHeight;
                hScrollVisible = false;
            }
        }
    }
}
