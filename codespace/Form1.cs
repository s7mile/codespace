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

namespace codespace
{
    public partial class Form1 : Form
    {
        Child child;
        int nChild = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void newMenu_Click(object sender, EventArgs e)
        {
            customTabControl1.TabPages.Add(new myTabPage(new Child()));
            this.customTabControl1.SelectedTab = this.customTabControl1.TabPages[customTabControl1.TabPages.Count-1];
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFDlg = new OpenFileDialog();
            if(openFDlg.ShowDialog() == DialogResult.OK)
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
            SaveFileDialog saveDlg = new SaveFileDialog();
            if(saveDlg.ShowDialog() == DialogResult.OK)
            {
                string fName = this.customTabControl1.SelectedTab.Text;
                StreamWriter write = new StreamWriter(fName);
                //write.Write(this.customTabControl1.SelectedTab.);
                write.Close();
            }
        }

        private void saveasMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string fName = saveDlg.FileName;
                StreamWriter write = new StreamWriter(fName);
                //write.Write(this.customTabControl1.SelectedTab.);
                write.Close();
                child.Text = fName;
            }
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
