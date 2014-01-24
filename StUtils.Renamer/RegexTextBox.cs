using StUtil.Native.Extensions;
using StUtilEx.RegexParser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace StUtils.Renamer
{
    public class RegexTextBox : RichTextBoxEx
    {
        public class SyntaxFormat
        {
            public TextFormatting AtLeastMinimumQuantifier { get; set; }
            public TextFormatting AtLeastQuantifier { get; set; }
            public TextFormatting Backreference { get; set; }
            public TextFormatting BackspaceEscaped { get; set; }
            public TextFormatting CharacterGroup { get; set; }
            public TextFormatting Comment { get; set; }
            public TextFormatting ControlCharacter { get; set; }
            public TextFormatting DefinedEscaped { get; set; }
            public TextFormatting Error { get; set; }
            public TextFormatting EscapedCharacter { get; set; }
            public TextFormatting ExactQuantifier { get; set; }
            public TextFormatting Greedy { get; set; }
            public TextFormatting Group { get; set; }
            public TextFormatting HexCharacter { get; set; }
            public TextFormatting Invalid { get; set; }
            public TextFormatting InvalidQuantifier { get; set; }
            public TextFormatting MinimumRangeQuantifier { get; set; }
            public TextFormatting NamedBackreference { get; set; }
            public TextFormatting NamedCapture { get; set; }
            public TextFormatting NegateCharacterGroup { get; set; }
            public TextFormatting NegatedCharacterGroup { get; set; }
            public TextFormatting NegativeLookahead { get; set; }
            public TextFormatting NegativeLookbehind { get; set; }
            public TextFormatting NonCapturing { get; set; }
            public TextFormatting OctalCharacter { get; set; }
            public TextFormatting Operator { get; set; }
            public TextFormatting PositiveLookahead { get; set; }
            public TextFormatting PositiveLookbehind { get; set; }
            public TextFormatting RangeQuantifier { get; set; }
            public TextFormatting Root { get; set; }
            public TextFormatting Text { get; set; }
            public TextFormatting Undefined { get; set; }
            public TextFormatting UnicodeCharacter { get; set; }

            public SyntaxFormat()
            {
                Undefined = new TextFormatting(Color.Red, true);
                Root = Text = new TextFormatting(Color.Black);
                EscapedCharacter = DefinedEscaped = new TextFormatting(Color.Orange);
                BackspaceEscaped = UnicodeCharacter = OctalCharacter = ControlCharacter = HexCharacter = new TextFormatting(Color.OrangeRed);
                NamedBackreference = Backreference = NegatedCharacterGroup = CharacterGroup = new TextFormatting(Color.Green);
                NegateCharacterGroup = new TextFormatting(Color.Pink);
                ExactQuantifier = AtLeastQuantifier = RangeQuantifier = AtLeastMinimumQuantifier = MinimumRangeQuantifier = new TextFormatting(Color.Purple);
                NegateCharacterGroup = Operator = new TextFormatting(Color.DodgerBlue);
                Group = NegativeLookahead = PositiveLookbehind = NegativeLookbehind = Greedy = NamedCapture = PositiveLookahead = NonCapturing = new TextFormatting();
                Comment = new TextFormatting(Color.Green);
                Error = Invalid = InvalidQuantifier = new TextFormatting(Color.Red);
            }
        }

        public class TextFormatting
        {
            public bool Bold { get; set; }
            public Color ForeColor { get; set; }
            public bool Special { get; set; }

            public TextFormatting()
            {
                this.Special = true;
            }

            public TextFormatting(Color foreColor)
                : this(foreColor, false)
            {
            }

            public TextFormatting(Color foreColor, bool bold)
            {
                this.ForeColor = foreColor;
                this.Bold = bold;
            }

            public void Apply(RegexTextBox textbox, Color? c = null)
            {
                textbox.SelectionColor = ForeColor;
                if (Bold)
                {
                    textbox.SelectionFont = new Font(textbox.Font, FontStyle.Bold);
                }
                else
                {
                    textbox.SelectionFont = textbox.Font;
                }

                if (c.HasValue)
                {
                    textbox.SelectionBackColor = c.Value;
                }
                textbox.SelectionStart = textbox.SelectionStart + textbox.SelectionLength + 1;
                textbox.SelectionFont = textbox.Font;
            }
        }

        private List<Color> groupColours = new List<Color>();
        private int groupCount = 0;
        private Parser parser = new Parser();
        private Random r = new Random();

        public SyntaxFormat SyntaxHighlighting { get; private set; }
        public bool HasRegexError { get; private set; }

        private RegexPart _parts;
        public RegexPart Parts { get { return _parts; } }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Highlight();
            }
        }

        public RegexTextBox()
        {
            this.SyntaxHighlighting = new SyntaxFormat();
            this.Font = new Font("Consolas", 10.0f);

            this.TextChanged += RegexTextBox_TextChanged;
        }

        private void FormatPart(RegexPart part, List<Color> groupColors)
        {
            this.SelectionStart = part.Index;
            this.SelectionLength = part.ToString().Length;
            if (part.Error != ErrorType.None)
            {
                SyntaxHighlighting.Error.Apply(this);
            }
            else
            {
                switch (part.Type)
                {
                    case PartType.Undefined:
                        SyntaxHighlighting.Undefined.Apply(this);
                        break;

                    case PartType.Root:
                        SyntaxHighlighting.Root.Apply(this);
                        break;

                    case PartType.Text:
                        SyntaxHighlighting.Text.Apply(this);
                        break;

                    case PartType.DefinedEscaped:
                        SyntaxHighlighting.DefinedEscaped.Apply(this);
                        break;

                    case PartType.OctalCharacter:
                        SyntaxHighlighting.OctalCharacter.Apply(this);
                        break;

                    case PartType.HexCharacter:
                        SyntaxHighlighting.HexCharacter.Apply(this);
                        break;

                    case PartType.ControlCharacter:
                        SyntaxHighlighting.ControlCharacter.Apply(this);
                        break;

                    case PartType.UnicodeCharacter:
                        SyntaxHighlighting.UnicodeCharacter.Apply(this);
                        break;

                    case PartType.EscapedCharacter:
                        SyntaxHighlighting.EscapedCharacter.Apply(this);
                        break;

                    case PartType.Backreference:
                        SyntaxHighlighting.Backreference.Apply(this);
                        break;

                    case PartType.CharacterGroup:
                        SyntaxHighlighting.CharacterGroup.Apply(this);
                        break;

                    case PartType.NegatedCharacterGroup:
                        SyntaxHighlighting.NegatedCharacterGroup.Apply(this);
                        break;

                    case PartType.NegateCharacterGroup:
                        SyntaxHighlighting.NegateCharacterGroup.Apply(this);
                        break;

                    case PartType.ExactQuantifier:
                        SyntaxHighlighting.ExactQuantifier.Apply(this);
                        break;

                    case PartType.AtLeastQuantifier:
                        SyntaxHighlighting.AtLeastQuantifier.Apply(this);
                        break;

                    case PartType.RangeQuantifier:
                        SyntaxHighlighting.RangeQuantifier.Apply(this);
                        break;

                    case PartType.AtLeastMinimumQuantifier:
                        SyntaxHighlighting.AtLeastMinimumQuantifier.Apply(this);
                        break;

                    case PartType.Operator:
                        SyntaxHighlighting.Operator.Apply(this);
                        break;

                    case PartType.MinimumRangeQuantifier:
                        SyntaxHighlighting.MinimumRangeQuantifier.Apply(this);
                        break;

                    case PartType.BackspaceEscaped:
                        SyntaxHighlighting.BackspaceEscaped.Apply(this);
                        break;

                    case PartType.NamedBackreference:
                        SyntaxHighlighting.NamedBackreference.Apply(this);
                        break;

                    case PartType.Group:
                        SyntaxHighlighting.Group.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.NegativeLookahead:
                        SyntaxHighlighting.NegativeLookahead.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.PositiveLookbehind:
                        SyntaxHighlighting.PositiveLookbehind.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.NegativeLookbehind:
                        SyntaxHighlighting.NegativeLookbehind.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.Greedy:
                        SyntaxHighlighting.Greedy.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.NamedCapture:
                        SyntaxHighlighting.NamedCapture.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.PositiveLookahead:
                        SyntaxHighlighting.PositiveLookahead.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.NonCapturing:
                        SyntaxHighlighting.NonCapturing.Apply(this, GetColor(groupCount++, groupColors));
                        break;

                    case PartType.Comment:
                        SyntaxHighlighting.Comment.Apply(this);
                        break;

                    case PartType.Invalid:
                        SyntaxHighlighting.Invalid.Apply(this);
                        break;

                    case PartType.InvalidQuantifier:
                        SyntaxHighlighting.InvalidQuantifier.Apply(this);
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private Color GetColor(int id, List<Color> colors)
        {
            if (id < colors.Count)
            {
                return colors[id];
            }
            int count = colors.Count - ((colors.Count / 21) * 21);

            Color c = Color.FromArgb(r.Next(200, 255), r.Next(200, 255), r.Next(200, 255));
            colors.Add(c);
            return c;
        }

        private void Highlight()
        {
            this.groupCount = 0;
            int start = this.SelectionStart;
            try
            {
                _parts = parser.Parse(this.Text);

                Stack<RegexPart> parts = new Stack<RegexPart>();
                Stack<RegexPart> lastChildren = new Stack<RegexPart>();
                parts.Push(_parts);
                HasRegexError = false;
                while (parts.Count > 0)
                {
                    RegexPart p = parts.Pop();
                    //Debug.WriteLine(p.Type.ToString() + " " + p.ToString());
                    if (p.Error != ErrorType.None || p.Type == PartType.Invalid || p.Type == PartType.InvalidQuantifier)
                    {
                        HasRegexError = true;
                    }

                    if (lastChildren.Count > 0 && lastChildren.Peek() == p)
                    {
                        lastChildren.Pop();

                        if (!p.Parent.Parent.IsGroup())
                        {
                            ResetBackFormat(p);
                        }
                    }

                    if (p.IsGroup() && p.Parts.Count > 0)
                    {
                        lastChildren.Push(p.Parts[p.Parts.Count - 1]);
                    }

                    for (int i = p.Parts.Count - 1; i >= 0; i--)
                    {
                        parts.Push(p.Parts[i]);
                    }
                    if (p.ValueStart != null)
                    {
                        FormatPart(p, groupColours);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            this.SelectionStart = start;
            this.SelectionLength = 0;
        }

        private void RegexTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SuspendDrawing();
            int start = this.SelectionStart;
            Text = Text.Replace("\r", "").Replace("\n", "");
            this.SelectionStart = start;
            Highlight();
            this.ResumeDrawing();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                groupColours = new List<Color>();
            }
            base.OnKeyDown(e);
        }

        private void ResetBackFormat(RegexPart p)
        {
            try
            {
                this.SelectionStart = p.Index + p.ToString().Length + 1;
                this.SelectionLength = this.Text.Length;
                this.SelectionBackColor = Color.White;
            }
            catch (Exception)
            {
            }
           
        }
    }
}