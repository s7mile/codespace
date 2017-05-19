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

namespace codespace
{
    public partial class Form1 : Form
    {
        Child child;
        int nChild = 0;
        String filter = "텍스트 파일|*.txt|c 파일|*.c|C# 파일|*.cs|JAVA 파일|*.java|HTML 파일|*.html|CSS 파일|*.css|JavaScript 파일| *.js|모든 파일|*.*";

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
            OpenFileDialog openFDlg = new OpenFileDialog();
            openFDlg.Filter = filter;
            if (openFDlg.ShowDialog() == DialogResult.OK)
            {
                Stream str = openFDlg.OpenFile();
                StreamReader reader = new StreamReader(str);

                child = new Child();
                customTabControl1.TabPages.Add(new myTabPage(child, Path.GetFileName(openFDlg.FileName)));
                customTabControl1.SelectedTab = this.customTabControl1.TabPages[customTabControl1.TabPages.Count - 1];
                customTabControl1.SelectedTab.Tag = openFDlg.FileName;

                child.getTextBox().Text = reader.ReadToEnd();
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

        private void WebBtn_Click(object sender, EventArgs e)
        {
            TabPage tab = customTabControl1.SelectedTab;
            webView wv = new webView();
            SplitContainer sc = new SplitContainer();
            sc.Orientation = Orientation.Horizontal;
            customTabControl1.TabPages.Add(new myTabPage(wv, tab.Text+" - web view"));
            customTabControl1.SelectedTab = this.customTabControl1.TabPages[customTabControl1.TabPages.Count - 1];
            //webBrowser1.Navigate();
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
