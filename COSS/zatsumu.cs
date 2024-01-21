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
    public partial class zatsumu : Form
    {
        Form2 mkqr;
        public zatsumu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timer1.Enabled = false;
            webView21.CoreWebView2.Navigate(label1.Text);
            timer2.Enabled = true;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate(label1.Text);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = "ポップアップ表示" +"  "+ webView21.CoreWebView2.DocumentTitle + "/" + webView21.CoreWebView2.Source;
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(webView21.CoreWebView2.DocumentTitle, true);
            MessageBox.Show("クリップボードにコピーしました!");
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(webView21.CoreWebView2.Source, true);
            MessageBox.Show("クリップボードにコピーしました!");
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            mkqr = new Form2();
            mkqr.label1.Text = "https://api.qrserver.com/v1/create-qr-code/?data=" + webView21.CoreWebView2.Source;
            mkqr.Show();
        }
    }
}
