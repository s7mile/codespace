using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Diagnostics;

namespace codespace
{
    public partial class Child : myFormPage
    {
        TextStyle blueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Underline);

        public Child()
        {
            InitializeComponent();
            this.pn = panel1;
            //this.lineNumbersForRichText1.ParentRichTextBox = this.richTextBox1;
        }

        public FastColoredTextBox getTextBox()
        {
            return this.fastColoredTextBox1;
        }
        
        private void fastColoredTextBox1_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(blueStyle);
            e.ChangedRange.SetStyle(blueStyle, @"(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?");
        }

        bool CharIsHyperlink(Place place)
        {
            var mask = fastColoredTextBox1.GetStyleIndexMask(new Style[] { blueStyle });
            if (place.iChar < fastColoredTextBox1.GetLineLength(place.iLine))
                if ((fastColoredTextBox1[place].style & mask) != 0)
                    return true;

            return false;
        }

        private void fastColoredTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var p = fastColoredTextBox1.PointToPlace(e.Location);
            if (CharIsHyperlink(p))
                fastColoredTextBox1.Cursor = Cursors.Hand;
            else
                fastColoredTextBox1.Cursor = Cursors.IBeam;
        }

        private void fastColoredTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var p = fastColoredTextBox1.PointToPlace(e.Location);
            if (CharIsHyperlink(p))
            {
                var url = fastColoredTextBox1.GetRange(p, p).GetFragment(@"[\S]").Text;
                Process.Start(url);
            }
        }
    }
}
