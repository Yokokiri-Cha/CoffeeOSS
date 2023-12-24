using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSS
{
    public partial class stvenv : Form
    {
        public stvenv()
        {
            InitializeComponent();
        }

        private void stvenv_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (SMART-TV-env; Linux; Coffee 12.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 TV Safari/537.36 Coffee-Android/12.0";
            webView21.CoreWebView2.Navigate("https://www.youtube.com/tv#");
        }
    }
}
