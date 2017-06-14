using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FastColoredTextBoxNS;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace codespace
{
    public partial class Form1 : Form
    {
        Child child;
        int nChild = 0;
        String filter = "모든 파일|*.*|텍스트 파일|*.txt|C# 파일|*.cs|JAVA 파일|*.java|HTML 파일|*.html|CSS 파일|*.css|JavaScript 파일| *.js";
        String lang = "";

        MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

        public Form1()
        {
            InitializeComponent();
            this.saveFileDialog1.Filter = filter;

        }

        private void newMenu_Click(object sender, EventArgs e)
        {
            customTabControl1.TabPages.Add(new myTabPage(new Child(), "new"));
            this.customTabControl1.SelectedTab = this.customTabControl1.TabPages[customTabControl1.TabPages.Count-1];
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = filter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream str = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(str);
                lang = Path.GetExtension(openFileDialog1.FileName);

                child = new Child();
                customTabControl1.TabPages.Add(new myTabPage(child, Path.GetFileName(openFileDialog1.FileName)));
                customTabControl1.SelectedTab = this.customTabControl1.TabPages[customTabControl1.TabPages.Count - 1];
                customTabControl1.SelectedTab.Tag = openFileDialog1.FileName;

                child.getTextBox().Text = reader.ReadToEnd();

                syntax();
                reader.Close();
                str.Close();
            }
        }

        private void lineNumMenu_Click(object sender, EventArgs e)
        {
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            if(customTabControl1.SelectedTab.Tag == null)
                save(customTabControl1.SelectedTab, 0);
            else
                save(customTabControl1.SelectedTab, 1);
        }

        private void saveasMenu_Click(object sender, EventArgs e)
        {
            save(customTabControl1.SelectedTab, 0);
        }

        private bool save(TabPage tab, int type)
        {
            var tb = (tab.Controls[0].Controls[0] as FastColoredTextBox);
            if (type == 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lang = Path.GetExtension(saveFileDialog1.FileName);
                    syntax();
                    tab.Text = Path.GetFileName(saveFileDialog1.FileName);
                    tab.Tag = saveFileDialog1.FileName;
                }
            }

            if (tab.Tag != null)
            {
                StreamWriter write = new StreamWriter((String)tab.Tag);
                write.Write(tb.Text);
                write.Close();

                return true;
            }
            else return false;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            if (tb.UndoEnabled)
                tb.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            if (tb.RedoEnabled)
                tb.Redo();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            if (tb != null)
            {
                var settings = new PrintDialogSettings();
                settings.Title = customTabControl1.SelectedTab.Text;
                settings.Header = "&b&w&b";
                settings.Footer = "&b&p";
                tb.Print(settings);
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutMenu_Click(object sender, EventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            tb.Cut();
        }

        private void copyMenu_Click(object sender, EventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            tb.Copy();
        }

        private void pasteMenu_Click(object sender, EventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            tb.Paste();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            tb.Text = "";
        }

        private void WebBtn_Click(object sender, EventArgs e)
        {
            TabPage tab = customTabControl1.SelectedTab;
            webView wv = new webView();
            SplitContainer sc = new SplitContainer();
            Uri myUri = new Uri((string)tab.Tag);
            sc.Orientation = Orientation.Horizontal;
            customTabControl1.TabPages.Add(new myTabPage(wv, tab.Text + " - web view"));
            customTabControl1.SelectedTab = this.customTabControl1.TabPages[customTabControl1.TabPages.Count - 1];
            var wb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as WebBrowser);
            wb.Navigate(myUri);
        }
        
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            var wb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as WebBrowser);
            wb.Refresh();
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
                tb.Font = fontDialog1.Font;
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Ftp ftp = new Ftp();
            ftp.Show();
        }

        bool tbFindChanged = false;
        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            if (e.KeyChar == '\r' && tb != null)
            {
                Range r = tbFindChanged ? tb.Range.Clone() : tb.Selection.Clone();
                tbFindChanged = false;
                r.End = new Place(tb[tb.LinesCount - 1].Count, tb.LinesCount - 1);
                var pattern = Regex.Escape(tbFind.Text);
                foreach (var found in r.GetRanges(pattern))
                {
                    found.Inverse();
                    tb.Selection = found;
                    tb.DoSelectionVisible();
                    return;
                }
                MessageBox.Show("Not found.");
            }
            else
                tbFindChanged = true;
        }

        private void InitStylesPriority()
        {
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);
            tb.AddStyle(SameWordsStyle);
        }

        private void fctb_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            //some statements: case, default
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }

        private void syntax()
        {   
            var tb = (customTabControl1.SelectedTab.Controls[0].Controls[0] as FastColoredTextBox);

            tb.ClearStylesBuffer();
            tb.Range.ClearStyle(StyleIndex.All);
            InitStylesPriority();
            tb.AutoIndentNeeded -= fctb_AutoIndentNeeded;
            
            switch (lang.ToLower())
            {
                case ".cs": tb.Language = Language.CSharp; break;
                case ".vb": tb.Language = Language.VB; break;
                case ".html": tb.Language = Language.HTML; break;
                case ".xml": tb.Language = Language.XML; break;
                case ".sql": tb.Language = Language.SQL; break;
                case ".php": tb.Language = Language.PHP; break;
                case ".js": tb.Language = Language.JS; break;
            }
            
            tb.OnSyntaxHighlight(new TextChangedEventArgs(tb.Range));
        }
    }

    public class myFormPage : Form
    {
        public Panel pn;
    }

    public class myTabPage : TabPage
    {
        private Form frm;
        public myTabPage (myFormPage mfp, String fn)
        {
            this.frm = mfp;
            this.Controls.Add(mfp.pn);
            this.Text = fn;
        }
    }
}
