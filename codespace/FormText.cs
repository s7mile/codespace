using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace codespace
{
    public partial class Child : myFormPage
    {
        public string fileType = ".c";

        public Child()
        {
            InitializeComponent();
            this.pn = panel1;
            this.lineNumbersForRichText1.ParentRichTextBox = this.richTextBox1;
        }

        public RichTextBox getTextBox()
        {
            return this.richTextBox1;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
                richTextBox1.SelectedText = new string(' ', 4);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            SyntaxHighlight();
        }

        private void SyntaxHighlight()
        {
            string keywords = "";

            if (fileType == ".c")
            {
                keywords = "(auto |double |int |struct |break |else |long |switch |case |enum |register |typedef |char |extern |return |union |const |float |short |unsigned |continue |for |signed |void |default |goto |sizeof |volatile |do |if |static |while |)";
            }
            else if (fileType == ".cpp" || fileType == ".cc")
            {
                keywords = "(alignas |alignof |and |and_eq |asm |auto |bitand |bitor |bool |break |case |catch |char |char16_t |char32_t |class |compl |const |constexpr |const_cast |continue |decltype |default |delete |do |double |dynamic_cast |else |enum |explicit |export(1) |extern |false |float |for |friend |goto |if |inline |int |long |mutable |namespace |new |noexcept |not |not_eq |nullptr |operator |or |or_eq |private |protected |public |register |reinterpret_cast |return |short |signed |sizeof |static |static_assert |static_cast |struct |switch |template |this |thread_local |throw |true |try |typedef |typeid |typename |union |unsigned |using |virtual |void |volatile |wchar_t |while |xor |xor_eq )";
            }
            else if (fileType == ".java")
            {
                keywords = "(abstract |boolean |break |byte |case |catch |char |class |const |continue |default |do |double |else |extends |final |finally |float |for |goto |if |implements |import |instanceof |int |interface |long |native |new |package |private |protected |public |return |short |static |strictfp |super |switch |synchronized |this |throw |throws |transient |try |void |volatile |while )";
            }
            else if (fileType == ".html")
            {
                keywords = "(olatile |while )";
            }

            Regex regex = new Regex(keywords, RegexOptions.Compiled);
            MatchCollection matchCollection = regex.Matches(richTextBox1.Text);

            try
            {
                int startPosition = richTextBox1.SelectionStart;

                foreach (Match item in matchCollection)
                {
                    int start = item.Index;
                    int stop = item.Length;

                    richTextBox1.Select(start, stop);
                    richTextBox1.SelectionColor = Color.Blue;
                }

                richTextBox1.Select(startPosition, 0);
                richTextBox1.SelectionColor = Color.Black;
            }
            finally
            {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool LockWindowUpdate(IntPtr hWndLock);
    }
}
