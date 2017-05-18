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
            customTabControl1.TabPages.Add(new myTabPage(new Child()));
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
                customTabControl1.TabPages.Add(new myTabPage(child));
                this.customTabControl1.SelectedTab = this.customTabControl1.TabPages[customTabControl1.TabPages.Count - 1];

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
            save(customTabControl1.SelectedTab);
        }

        private bool save(TabPage tab)
        {
            var tb = (tab.Controls[0].Controls[0] as FastColoredTextBox);
            if (tab.Tag == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tab.Text = Path.GetFileName(saveFileDialog1.FileName);
                    tab.Tag = saveFileDialog1.FileName;

                    StreamWriter write = new StreamWriter(tab.Text);
                    write.Write(tb.Text);
                    write.Close();
                }
            }

            return true;
        }

        private void saveasMenu_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class myFormPage : Form
    {
        public Panel pn;
    }

    public class myTabPage : TabPage
    {
        private Form frm;
        public myTabPage (myFormPage mfp)
        {
            this.frm = mfp;
            this.Controls.Add(mfp.pn);
            this.Text = "new";
        }
    }
}
