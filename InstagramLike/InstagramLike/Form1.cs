using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace InstagramLike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                HtmlElementCollection instagram = webBrowser1.Document.GetElementsByTagName("a");
                foreach (HtmlElement item in instagram)
                {
                    if (item.GetAttribute("className") == "gmFkV")
                    {
                        label1.Text = item.GetAttribute("OuterText");
                    }
                }
            }
            catch
            {

            }
        }
    }
}
