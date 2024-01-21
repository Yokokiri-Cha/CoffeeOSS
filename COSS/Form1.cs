using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.Windows.Forms;
using System.Windows.Shell;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using SpeechLib;

namespace COSS
{

    public partial class Form1 : Form
    {
        Form2 mkqr;
        maximizedsc mx;
        Form3 lic;
        Aboutyokoha aboutyokoha;
        stvenv stvenv;
        zatsumu zatsumu;
        public string cps = "";
        public string p2c = "";
        //UASというクラスの中にアクセス装飾子がPublicの文字列UAを保存
        //呼び出す時はインスタンスを作成する
        public class UAS
        {
            public string UA;
        }



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //webView21.CoreWebView2.Navigate("https://google.co.jp/");
            //https://atmarkit.itmedia.co.jp/ait/articles/1509/09/news025.html参照しました。ありがとうございます!
            //JumpListメニューの実装
            var jl = new System.Windows.Shell.JumpList();
            var jt = new System.Windows.Shell.JumpTask()
            {
                CustomCategory = "CoffeeOSSセッションメニュー",
                Title = "新しいセッションを開始",
                Description = "ウィンドウを重複起動し、新規セッションを開始します。",
            };
            


            jl.JumpItems.Add(jt);
            jl.Apply();

        }

        private void webView22_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            //UASクラスをduaと名づける
            
                UAS dua = new UAS();
            //dua内のUAという文字列ストアに既定のUserAgentを格納
            //後に使用します。
            dua.UA = webView22.CoreWebView2.Settings.UserAgent;
            webView22.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 16_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.0 Mobile/15E148 Safari/604.1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をグーグルで検索します", fl);
            }
            reconnect();
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(Google)
                string baseline = "https://www.google.com/search?q=";
                webView22.CoreWebView2.Navigate(baseline + usr6);

            }
            else
            {
                //ユーザー入力文字列変数usr→URLエンコード処理済みはusr6に格納。
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(Google)
                string baseline = "https://www.google.com/search?q=";
                webView21.CoreWebView2.Navigate(baseline + usr6);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をダックダックゴーで検索します", fl);
            }
            reconnect();
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(DuckDuckGo)
                string baseline = "https://duckduckgo.com/?q=";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(DuckDuckGo)
                string baseline = "https://duckduckgo.com/?q=";
                webView21.CoreWebView2.Navigate(baseline + usr6);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をユーチューブで検索します", fl);
            }
            reconnect();
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(YouTube)
                string baseline = "https://www.youtube.com/results?search_query=";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(YouTube)
                string baseline = "https://www.youtube.com/results?search_query=";
                webView21.CoreWebView2.Navigate(baseline + usr6);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reconnect();
            if (checkBox1.Checked)
            {
                string usr6 = this.textBox1.Text;
                if (usr6.Contains("."))
                {
                    if (usr6.Contains("http"))
                    {
                        if (invisiblestore.Checked)
                        {
                            SpVoice syab = new SpVoice();

                            SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                            syab.Speak("ご指定のURL先のサイトへ移動します", fl);
                        }
                        webView22.CoreWebView2.Navigate(usr6);
                    }
                    else
                    {
                        if (invisiblestore.Checked)
                        {
                            SpVoice syab = new SpVoice();

                            SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                            syab.Speak("不完全なURLを検出しました。ダイアログボックスを閉じるとhttpsモードで続行します", fl);
                        }
                        MessageBox.Show("httpやhttpsの省略を検知しました。httpsモードで続行します。アクセス不可の場合はhttp://をURLの先頭に付加して下さい。");
                        string usr7 = "https://" + usr6;
                        webView22.CoreWebView2.Navigate(usr7);


                    }

                }
                else
                {
                    if (invisiblestore.Checked)
                    {
                        SpVoice syab = new SpVoice();

                        SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                        syab.Speak("ご指定のURL先のサイトへの移動が出来ませんでした。", fl);
                    }
                    MessageBox.Show("指定されたURLは無効である可能性があります。ご確認下さい。\nErr:Malformed URL");
                }
            }
            else
            {
                string usr6 = this.textBox1.Text;
                if (usr6.Contains("."))
                {
                    if (usr6.Contains("http"))
                    {
                        webView21.CoreWebView2.Navigate(usr6);
                    }
                    else
                    {
                        MessageBox.Show("httpやhttpsの省略を検知しました。httpsモードで続行します。アクセス不可の場合はhttp://をURLの先頭に付加して下さい。");
                        string usr7 = "https://" + usr6;
                        webView21.CoreWebView2.Navigate(usr7);


                    }

                }
                else
                {
                    MessageBox.Show("指定されたURLは無効である可能性があります。ご確認下さい。\nErr:Malformed URL");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をユーチューブミュージックで楽曲検索します", fl);
            }
            reconnect();
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(YouTubeMusic)
                string baseline = "https://music.youtube.com/search?q=";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            {

                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(YouTubeMusic)
                string baseline = "https://music.youtube.com/search?q=";
                webView21.CoreWebView2.Navigate(baseline + usr6);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak(textBox1.Text + "をニコニコ動画で検索します", fl);
            }
            reconnect();
            if (checkBox1.Checked)
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(Nicovideo)
                string baseline = "https://www.nicovideo.jp/search/";
                webView22.CoreWebView2.Navigate(baseline + usr6);
            }
            else
            {
                string usr = this.textBox1.Text;
                string usr2 = usr.Replace("+", "%2B");
                string usr3 = usr2.Replace("　", "+");
                string usr4 = usr3.Replace(" ", "+");
                string usr5 = usr4.Replace("#", "%23");
                string usr6 = usr5.Replace("*", "%2A");
                //先頭付加用検索エンジンURL(Nicovideo)
                string baseline = "https://www.nicovideo.jp/search/";
                webView21.CoreWebView2.Navigate(baseline + usr6);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("文字を削除しました。", fl);
            }
            textBox1.Text = string.Empty;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("戻るボタンを押しました", fl);
            }
            reconnect();
            //戻る
            webView21.CoreWebView2.GoBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("新規セッションを開始しました。", fl);
            }
            Form1 fa = new Form1();
            fa.Show();
        }

        private void toolStripLabel13_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("完全終了します。ご利用いただきありがとうございました。またのご利用をお待ちしています。", fl);
                MessageBox.Show("[アクセシビリティーサービス]音声リーダーを終了します。");
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }

        }

        private void タスクマネージャーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ブラウザーのタスクマネージャーを開きます", fl);
            }
            webView21.CoreWebView2.OpenTaskManagerWindow();
        }

        private void fastPortalBy横茶横葉へ移動ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reconnect();
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("よこちゃよこはが製作した最軽量汎用ポータルサイトへ移動します", fl);
            }
            //横茶横葉の最軽量ポータルサイトへ移動します。//PCスペックを考慮せず、快適に使えるようにする工夫です!
            webView21.CoreWebView2.Navigate("https://yokochayokoha.github.io/fastportal");
        }

        private void 詳細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("アプリの詳細を表示します", fl);
            }
            MessageBox.Show("©2023 横茶横葉\nAndroid版Coffeeブラウザーと同様の操作感をWindowsでも!\nオープンソースで安心なブラウジングを第一に考えて製作された軽量のブラウザーです!\n//横茶横葉より//ご利用頂きありがとうございます!!Android版Coffeeブラウザーもどうぞよろしくお願い致します!!\nPlease visit!:yokochayokoha.github.io");
        }

        private void ソフトウェア配布ページへToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reconnect();
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("このブラウザーのソースコードを表示します", fl);
            }
            webView21.CoreWebView2.Navigate("https://github.com/Yokokiri-Cha/CoffeeOSS");
        }

        private void このアプリについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("アプリの詳細を表示します", fl);
            }
            MessageBox.Show("©2023 横茶横葉\nAndroid版Coffeeブラウザーと同様の操作感をWindowsでも!\nオープンソースで安心なブラウジングを第一に考えて製作された軽量のブラウザーです!\n//横茶横葉より//ご利用頂きありがとうございます!!Android版Coffeeブラウザーもどうぞよろしくお願い致します!!\nPlease visit!:yokochayokoha.github.io");
        }

        private void toolStripLabel12_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("全画面表示に切り替えます", fl);
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripLabel11_Click(object sender, EventArgs e)
        {

            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("操作パネルを隠します", fl);
            }


            toolStrip1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;

            //  notifyIcon1.ShowBalloonTip(5);
        }

        private void 操作バーの再表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStrip1.Visible = true;

            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;

            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            webView21.Dock = DockStyle.None;
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void toolStripLabel10_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("印刷プレビュー画面を表示します", fl);
            }
            webView21.CoreWebView2.ShowPrintUI();
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ダウンロード中のファイルの進捗状況を表示します", fl);
            }
            webView21.CoreWebView2.OpenDefaultDownloadDialog();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            reconnect();
            //JS無効化による簡易広告ブロック機能from Coffee(for Android)
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("広告ブロック機能のオンオフを切り替えます", fl);
            }
            if (toolStripLabel6.Text.Contains("無効"))
            {
                MessageBox.Show("簡易広告ブロック機能を有効化しました。このメッセージを閉じると適用され、ページが更新されます。この機能の使用によって多くのサイトで正常に閲覧できなります。金銭取引に関わるサイトでは絶対に使用しないでください。この機能を使用したことで発生した全ての事柄について製作者は一切の責任を負いかねます。ご利用の際は十分に注意してください。");
                //文字列でオンオフの判定
                toolStripLabel6.Text = "簡易広告ブロック(現在:有効)";
                webView21.CoreWebView2.Settings.IsScriptEnabled = false;
                webView21.CoreWebView2.Reload();
            }
            else
            {
                MessageBox.Show("簡易広告ブロック機能を無効化しました。");
                toolStripLabel6.Text = "簡易広告ブロック(現在:無効)";
                webView21.CoreWebView2.Settings.IsScriptEnabled = true;
                webView21.CoreWebView2.Reload();
            }
        }

        private void iOSモードiOS16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reconnect();
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 16_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.0 Mobile/15E148 Safari/604.1";
            webView21.CoreWebView2.Reload();
        }

        private void googleChromeモード116ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reconnect();
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36";
            webView21.CoreWebView2.Reload();
        }

        private void safariモード16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reconnect();
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.3 Safari/605.1.15";
            webView21.CoreWebView2.Reload();
        }

        private void firefoxモード117ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reconnect();
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/119.0";
            webView21.CoreWebView2.Reload();
        }

        private void androidモードAndroid13TiramisuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reconnect();
            webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Linux; Android 13; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Mobile Safari/537.36";
            webView21.CoreWebView2.Reload();
        }

        private void 既定のユーザーエージェントToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  UAS dua = new UAS();
            //webView21.CoreWebView2.Settings.UserAgent = dua.UA;
            //webView21.CoreWebView2.Reload();
            MessageBox.Show("お手数ですが、ブラウザーを再起動してください。元のユーザーエージェントに戻ります。");
        }

        private void 適用するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("テキストが入力されていません。誤動作を防止するため、処理を行いませんでした。/Err:No text");
            }
            else
            {
                reconnect();
                webView21.CoreWebView2.Settings.UserAgent = toolStripTextBox1.Text;
                webView21.CoreWebView2.Reload();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ホームページボタンを押しました。", fl);
            }
            reconnect();
            //ホーム(Google)
            webView21.CoreWebView2.Navigate("https://google.co.jp");

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("進むボタンを押しました", fl);
            }
            reconnect();
            //進む
            webView21.CoreWebView2.GoForward();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("更新ボタンを押しました", fl);
            }
            reconnect();
                //再読み込み
                webView21.CoreWebView2.Reload();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("QRコードを作成します", fl);
            }
            //QRコード生成from速作成QR
            mkqr = new Form2();
            mkqr.label1.Text = "https://api.qrserver.com/v1/create-qr-code/?data=" + webView21.CoreWebView2.Source;
            mkqr.Show();
        }

        private void toolStripLabel14_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("新規セッションを開始します。", fl);
            }
            Form1 fa = new Form1();
            fa.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("このバーはアップラインと呼ばれる操作パネルです。様々な機能をご利用いただけます", fl);
            }
            MessageBox.Show("このバーはUplineと呼ばれる操作パネルです。様々な機能をご利用いただけます");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (invisiblestore.Checked)
            {
                invisiblestore.Checked = false;

                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("こちらは音声リーダーアクセシビリティーサービスです。読み上げ機能を無効化しました。", fl);
                MessageBox.Show("[アクセシビリティーサービス]音声リーダーを無効化しました。");
            }
            else
            {
                invisiblestore.Checked = true;

                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("こちらは音声リーダーアクセシビリティーサービスです。読み上げ機能を有効化しました。おこなった操作内容を音声で読み上げます。", fl);
                MessageBox.Show("[アクセシビリティーサービス]音声リーダーを有効化しました。無効化するにはもう一度ロゴマークをクリックして下さい。");
            }
            //https://www.kyoukasho.net/entry/csharp-textToSpeech参照。ありがとうございます!

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("変更しました", fl);
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ユーザーエージェントの設定項目を表示します", fl);
            }
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("開発者向けツールを開きます", fl);
            }
            webView21.CoreWebView2.OpenDevToolsWindow();
        }

        private void オープンソースライセンス表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("オープンソースライセンスを表示します", fl);
            }
            lic = new Form3();
            lic.Show();
        }

        private void toolStripLabel2_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用戻るアクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearch戻る";
            webView22.CoreWebView2.GoBack();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            toolStripLabel1.Text = "Upline";
        }

        private void toolStripLabel3_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用ホームアクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearchホーム";
            webView22.CoreWebView2.Navigate("https://yokokiri-cha.github.io/minisearch");
            timer1.Enabled = true;
        }

        private void toolStripLabel4_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用進むアクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearch進む";
            webView22.CoreWebView2.GoForward();
            timer1.Enabled = true;
        }

        private void toolStripLabel5_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用更新アクションを指定しました", fl);
            }
            //戻る
            toolStripLabel1.Text = "[ダブルクリック検知]MiniSearch更新";
            webView22.CoreWebView2.Reload();
            timer1.Enabled = true;
        }

        private void toolStripLabel7_DoubleClick(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチ用QRコード作成アクションを指定しました", fl);
            }
            //QRコード生成from速作成QR
            mkqr = new Form2();
            mkqr.label1.Text = "https://api.qrserver.com/v1/create-qr-code/?data=" + webView22.CoreWebView2.Source;
            mkqr.Show();
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            timer2.Enabled = true;
            webView21.CoreWebView2.NewWindowRequested += sosi;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox2.Text = webView21.CoreWebView2.DocumentTitle;
            textBox3.Text = webView21.CoreWebView2.Source;

            
            this.Text ="CoffeeOSS"+ " - "+textBox2.Text+" "+textBox3.Text;

            //YouTube等全画面化判別動作(思い付き) ニコニコ動画は仕組みが違っている(?)ので使えないかもです....
            if (drindicator.Checked)
                //レジストリ(drindicatorに以下の作業を既に行ったかを保存し、重複作動を回避)
            {
                if (!webView21.CoreWebView2.ContainsFullScreenElement)
                {
                    //全画面モード終了検知
                    drindicator.Checked = false;

                    if (cps == "1")
                    {
                        //状態保存-値を戻すだけ
                        cps = "";
                    }
                    else
                    {
                        //Coffee右サイドパネルUIを表示させる
                        splitContainer1.Panel2Collapsed = false;
                    }
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                    toolStrip1.Visible = true;
                }
            }
            else
            {
                if (webView21.CoreWebView2.ContainsFullScreenElement)
                {
                    //全画面モード開始検知
                    drindicator.Checked = true;

                    this.WindowState = FormWindowState.Maximized;
                    if (splitContainer1.Panel2Collapsed == true)
                    {
                        //cpのcpにこの動作をする前からPanel2Collapsed = trueであったかを書き込む。(Panel2が見えない状態になっていたかを記録)
                       
                        cps = "1";
                    }
                    else
                    {
                        splitContainer1.Panel2Collapsed = true;
                    }
                        this.FormBorderStyle = FormBorderStyle.None;
                    toolStrip1.Visible = false;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reconnect();
            string tenso1 = webView21.CoreWebView2.Source;
            string tenso2 = webView22.CoreWebView2.Source;
            webView21.CoreWebView2.Navigate(tenso2);
            webView22.CoreWebView2.Navigate(tenso1);
        }
        //別Window表示防止(https://web.biz-prog.net/praxis/webview/linkself.htmlプログラムでネットサーフィン様のコードの一部を使用しました。ありがとうございます!)

        private void sosi(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {

            e.Handled = true;


            webView21.CoreWebView2.Navigate(e.Uri);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox2.Text, true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox3.Text, true);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reconnect();
            webView22.GoBack();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            reconnect();
            webView22.GoForward();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            reconnect();
            webView22.CoreWebView2.Navigate("https://yokokiri-cha.github.io/minisearch");
        }

        private void toolStripLabel11_Click_1(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("全画面で表示します", fl);
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("無効なURLです。");
            }
            else
            {
                mx = new maximizedsc();
                mx.label1.Text = textBox3.Text;
                mx.Show();
                mx.TopMost = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //esc key function not work
            Application.Exit();
        }




        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("隠しダイアログを表示します", fl);
            }
            aboutyokoha = new Aboutyokoha();
            aboutyokoha.Show();
        }

        private void 英語日本語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("翻訳表示を開始します", fl);
            }
            reconnect();
            string ur = webView21.CoreWebView2.Source;
            string moto = "https://translate.google.com/translate?sl=en&tl=ja&u=";
            webView21.CoreWebView2.Navigate(moto + ur);
        }

        private void 日本語英語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("翻訳表示を開始します", fl);
            }
            reconnect();
            string ur = webView21.CoreWebView2.Source;
            string moto = "https://translate.google.com/translate?sl=ja&tl=en&u=";
            webView21.CoreWebView2.Navigate(moto + ur);
        }

        private void poweredByGoogleTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("Google翻訳を表示します", fl);
            }
            reconnect();
            webView21.CoreWebView2.Navigate("https://translate.google.com/");
        }

        private void toolStripLabel15_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("スマートテレビエミュレーションモードを別ウィンドウで開始します", fl);
            }
            stvenv = new stvenv();
            stvenv.Show();
        }

        private void toolStripLabel16_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("Googleアカウントの管理画面をポップアップウィンドウで表示します", fl);
            }
            zatsumu = new zatsumu();
            zatsumu.label1.Text = "https://myaccount.google.com/";
            zatsumu.Show();
        }

        private void coffeeブラウザToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reconnect();
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("コーヒーブラウザーシリーズの公式サイトを開きます", fl);

            }
            zatsumu = new zatsumu();
            zatsumu.label1.Text = "https://sites.google.com/view/coffeebr";
            zatsumu.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("参考文献明示文の作成が完了しました", fl);
            }
            if (checkBox2.Checked == false)
            {
                //パターン1使用
                string num = "[" + numericUpDown1.Value + "]";
                string auth = textBox4.Text + " ";
                string appen = "(" + dateTimePicker1.Text + "アクセス)";
                string url = textBox3.Text;
                string title = "“" + textBox2.Text + "”";

                if (auth == " ")
                {
                    if (num == "[0]")
                    {
                        textBox5.Text = title + "\r\n" + "URL " + url + appen;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                    else
                    {
                        textBox5.Text = num + title + "\r\n" + "URL " + url + appen;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                }
                else
                {
                    if (num == "[0]")
                    {
                        textBox5.Text = auth + title + "\r\n" + "URL " + url + appen;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                    else
                    {
                        textBox5.Text = num + auth + title + "\r\n" + "URL " + url + appen;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                }
            }
            else
            {
                //パターン2使用
                string num = "[" + numericUpDown1.Value + "]";
                string auth = textBox4.Text + " ";
                string auth2 = textBox4.Text;
                string appen = "(" + dateTimePicker1.Text + "アクセス" + ")";
                string url = textBox3.Text;
                string title = "“" + textBox2.Text + "”";

                if (auth == " ")
                {
                    if (num == "[0]")
                    {
                        textBox5.Text = title + "\r\n" + "URL " + url + appen;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                    else
                    {
                        textBox5.Text = num + title + "\r\n" + "URL " + url + appen;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                }
                else
                {

                    //author 有り
                    if (num == "[0]")
                    {//番号未指定
                        textBox5.Text = auth2 + "." + "(" + dateTimePicker1.Value.Year + ")." + title.Replace(auth, "") + "\r\n" + url;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                    else
                    {//vice vasa
                        textBox5.Text = num + auth2 + "." + "(" + dateTimePicker1.Value.Year + ")." + title.Replace(auth, "") + "\r\n" + url;
                        Clipboard.SetDataObject(textBox5.Text, true);
                        MessageBox.Show("参考文献明示文を作成し、クリップボードにコピーしました!");
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("パターンを変更しました", fl);
            }
            if (checkBox2.Checked)
            {
                label9.Text = "構成: [番号(指定した場合)]著者名.(年).タイトル\r\nURL";
            }
            else
            {
                label9.Text = "構成: [番号(指定した場合)] 著者名 \"タイトル\"\r\nURL \"URL\"(取得日時)";
            }

        }

        private void toolStripLabel17_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("参考文献リスト作成支援機能を切り替えます", fl);
            }
            if (flowLayoutPanel1.Visible==false)
            {
                tabPage2.Text = "参考文献リスト作成支援機能";
                flowLayoutPanel1.Visible = true;
            }
            else
            {
                flowLayoutPanel1.Visible = false;
                tabPage2.Text = "その他";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("参考文献リスト作成支援機能モードをオフにします", fl);
            }
            flowLayoutPanel1.Visible = false;
            tabPage2.Text = "その他";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripLabel18_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ウィンドウ前面固定設定でポップアップ表示します", fl);
            }
            zatsumu = new zatsumu();
            zatsumu.label1.Text = webView21.CoreWebView2.Source;
            zatsumu.TopMost = true;
            zatsumu.Show();
        }

        private void toolStripLabel19_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ポップアップ表示します", fl);
            }
            zatsumu = new zatsumu();
            zatsumu.label1.Text = webView21.CoreWebView2.Source;
            zatsumu.TopMost = false;
            zatsumu.Show();
        }

        private void toolStripLabel20_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2.Source.Contains("embed"))
            {
                MessageBox.Show("既に埋め込みビューである可能性があります。URL欄にembedという文字が含まれているため、実行できません。");
            }
            else
            {
                if (webView21.CoreWebView2.Source.Contains("outu"))
                {
                    //有識者向けの没機能です。Androidではこれを導入しないと全画面化できませんでしたが、PCではいらなかったです!
                    //それを知らずに作ってしまったため、お蔵入りになりました!

                    //suspicious youtube.com? or youtu.be?
                    if (webView21.CoreWebView2.Source.Contains("watch?v="))
                    {//Maybe, sure! it's a ytmusic's url!
                        if (webView21.CoreWebView2.Source.Contains("music"))
                        {
                            string MSK = webView21.CoreWebView2.Source;
                            webView21.CoreWebView2.Navigate(MSK.Replace("music", "www"));
                            MessageBox.Show("[自動選択]:YouTubeMusicをYouTubeで表示します。");
                        }
                        else
                        {// Maybe,it is a yt video's url!
                         //[Recreation:Android Coffee]YouTubeID extractor script Developed by YokochaYokoha  ©YokochaYokoha All Rights Reserved.
                            try
                            {
                                string term1 = webView21.CoreWebView2.Source.Replace("youtu.be/", "");
                                string term2 = term1.Replace("embed/", "");
                                string term3 = term2.Replace("https://www.youtube.com/", "");
                                string term4 = term3.Replace("http://m.youtube.com/", "");
                                string term5 = term4.Replace("watch?v=", "");
                                string term6 = term5.Replace("&feature=emb_rel_pause", "");
                                string term7 = term6.Replace("&feture=emb_rel_pause", "");
                                string term8 = term7.Replace("https://", "");
                                string ID = term8.Substring(0, 11);
                                //make embed player instance

                                webView21.CoreWebView2.Navigate("https://www.youtube.com/embed/" + ID);
                                MessageBox.Show("[自動変換]:埋め込みビューに変更しました!");
                            }
                            catch (Exception ex)
                            {
                                //例外処理
                                MessageBox.Show("URLの変換が正常に行われませんでした。非対応のURLである可能性があります。開発者向けコード:" + ex.Message);
                            }

                        }
                    }
                    else
                    {

                    }
                }
                else if (webView21.CoreWebView2.Source.Contains("nico"))
                {
                    try
                    {
                        //suspicious nicovideo.jp? or nico.ms?
                        //nicovideo embedded video URL maker script by YokochaYokoha
                        string t1 = webView21.CoreWebView2.Source.Replace("https://www.", "https://");
                        string t2 = t1.Replace("https://sp.", "https://");
                        string t3 = t2.Replace("nicovideo.jp/", "embed.nicovideo.jp/");
                        if (t3.Length > 44)
                        {
                            string embed = t3.Substring(0, 44);
                            webView21.CoreWebView2.Navigate(embed);
                            MessageBox.Show("埋め込みモードに変更しました!");
                        }
                        else
                        {
                            string embed = t3;
                            webView21.CoreWebView2.Navigate(embed);
                            MessageBox.Show("埋め込みモードに変更しました!");
                        }


                    }
                    catch (Exception ex)
                    {
                        //例外処理
                        MessageBox.Show("URLの変換が正常に行われませんでした。非対応のURLである可能性があります。開発者向けコード:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ご指定のサイトが動画サイトではないため、この機能はご利用いただけません。");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cookieを削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("クッキーを全て削除しました", fl);
            }
            webView21.CoreWebView2.CookieManager.DeleteAllCookies();
            MessageBox.Show("Cookieの削除が完了しました。");

        }

        private void cookieをコピーToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel21_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチにYouTubeライブ配信のチャット枠を分割表示します", fl);
            }
            if (webView21.CoreWebView2.Source.Contains("outube"))
            {
                if (webView21.CoreWebView2.Source.Contains("watch?v="))
                {
                    //[Recreation:Android Coffee]YouTubeID extractor script Developed by YokochaYokoha  ©YokochaYokoha All Rights Reserved.
                    try
                    {
                        string term1 = webView21.CoreWebView2.Source.Replace("youtu.be/", "");
                        string term2 = term1.Replace("embed/", "");
                        string term3 = term2.Replace("https://www.youtube.com/", "");
                        string term4 = term3.Replace("http://m.youtube.com/", "");
                        string term5 = term4.Replace("watch?v=", "");
                        string term6 = term5.Replace("&feature=emb_rel_pause", "");
                        string term7 = term6.Replace("&feture=emb_rel_pause", "");
                        string term8 = term7.Replace("https://", "");
                        string ID = term8.Substring(0, 11);
                        //make comments window instance

                        webView22.CoreWebView2.Navigate("https://www.youtube.com/live_chat?v=" + ID);
                        MessageBox.Show("MiniSearchにチャット枠を表示しました。この機能はライブ配信動画でのみ正常に動作します。通常の動画では動作しません。");
                    }
                    catch (Exception ex)
                    {
                        //例外処理
                        MessageBox.Show("例外が発生しました。非対応のURLである可能性があります。開発者向けコード:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("非対応のサイトです。YouTubeのライブ配信動画のみ対応しています。");
                }
            }
            else
            {
                MessageBox.Show("非対応のサイトです。YouTubeのライブ配信動画のみ対応しています。");
            }
        }

        private void toolStripLabel22_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("YouTubeライブ配信のチャット枠を前面固定でポップアップ表示します", fl);
            }
            if (webView21.CoreWebView2.Source.Contains("outube"))
            {
                if (webView21.CoreWebView2.Source.Contains("watch?v="))
                {
                    //[Recreation:Android Coffee]YouTubeID extractor script Developed by YokochaYokoha  ©YokochaYokoha All Rights Reserved.
                    try
                    {
                        string term1 = webView21.CoreWebView2.Source.Replace("youtu.be/", "");
                        string term2 = term1.Replace("embed/", "");
                        string term3 = term2.Replace("https://www.youtube.com/", "");
                        string term4 = term3.Replace("http://m.youtube.com/", "");
                        string term5 = term4.Replace("watch?v=", "");
                        string term6 = term5.Replace("&feature=emb_rel_pause", "");
                        string term7 = term6.Replace("&feture=emb_rel_pause", "");
                        string term8 = term7.Replace("https://", "");
                        string ID = term8.Substring(0, 11);
                        //make comments window instance
                        zatsumu = new zatsumu();
                        zatsumu.TopMost = true;
                        zatsumu.label1.Text = "https://www.youtube.com/live_chat?v=" + ID;
                        zatsumu.Show();
                        MessageBox.Show("チャット枠を前面固定でポップアップ表示しました。この機能はライブ配信動画でのみ正常に動作します。通常の動画では動作しません。");
                    }
                    catch (Exception ex)
                    {
                        //例外処理
                        MessageBox.Show("例外が発生しました。非対応のURLである可能性があります。開発者向けコード:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("非対応のサイトです。YouTubeのライブ配信動画のみ対応しています。");
                }
            }
            else
            {
                MessageBox.Show("非対応のサイトです。YouTubeのライブ配信動画のみ対応しています。");
            }
        }

        private void toolStripLabel23_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("YouTubeライブ配信のチャット枠をポップアップ表示します", fl);
            }
            if (webView21.CoreWebView2.Source.Contains("outube"))
            {
                if (webView21.CoreWebView2.Source.Contains("watch?v="))
                {
                    //[Recreation:Android Coffee]YouTubeID extractor script Developed by YokochaYokoha  ©YokochaYokoha All Rights Reserved.
                    try
                    {
                        string term1 = webView21.CoreWebView2.Source.Replace("youtu.be/", "");
                        string term2 = term1.Replace("embed/", "");
                        string term3 = term2.Replace("https://www.youtube.com/", "");
                        string term4 = term3.Replace("http://m.youtube.com/", "");
                        string term5 = term4.Replace("watch?v=", "");
                        string term6 = term5.Replace("&feature=emb_rel_pause", "");
                        string term7 = term6.Replace("&feture=emb_rel_pause", "");
                        string term8 = term7.Replace("https://", "");
                        string ID = term8.Substring(0, 11);
                        //make comments window instance
                        zatsumu = new zatsumu();
                        zatsumu.TopMost = false;
                        zatsumu.label1.Text = "https://www.youtube.com/live_chat?v=" + ID;
                        zatsumu.Show();
                        MessageBox.Show("チャット枠をポップアップ表示しました。この機能はライブ配信動画でのみ正常に動作します。通常の動画では動作しません。");
                    }
                    catch (Exception ex)
                    {
                        //例外処理
                        MessageBox.Show("例外が発生しました。非対応のURLである可能性があります。開発者向けコード:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("非対応のサイトです。YouTubeのライブ配信動画のみ対応しています。");
                }
            }
            else
            {
                MessageBox.Show("非対応のサイトです。YouTubeのライブ配信動画のみ対応しています。");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            toolStripLabel20.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible)
            {
                if (invisiblestore.Checked)
                {
                    SpVoice syab = new SpVoice();

                    SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                    syab.Speak("ミニサーチを非表示にしました", fl);
                }
                tableLayoutPanel1.Visible = false;

            }
            else
            {
                if (invisiblestore.Checked)
                {
                    SpVoice syab = new SpVoice();

                    SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                    syab.Speak("ミニサーチを表示しました", fl);

                }
                tableLayoutPanel1.Visible = true;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("戻るボタンを押しました", fl);
            }
            reconnect();
            //戻る
            webView21.CoreWebView2.GoBack();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ホームページボタンを押しました。", fl);
            }
            reconnect();
            //ホーム(Google)
            webView21.CoreWebView2.Navigate("https://google.co.jp");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("進むボタンを押しました", fl);
            }
            reconnect();
            //進む
            webView21.CoreWebView2.GoForward();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("更新ボタンを押しました", fl);
            }
            //再読み込み
            reconnect();
            webView21.CoreWebView2.Reload();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("QRコードを作成します", fl);
            }
            //QRコード生成from速作成QR
            mkqr = new Form2();
            mkqr.label1.Text = "https://api.qrserver.com/v1/create-qr-code/?data=" + webView21.CoreWebView2.Source;
            mkqr.Show();
        }


        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {


        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void toolStripLabel24_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("右側パネルの表示と非表示を切り替えました", fl);
            }
            if (splitContainer1.Panel2Collapsed==true)
            { 
            splitContainer1.Panel2Collapsed = false;
            }
            else
            {
            splitContainer1.Panel2Collapsed=true;
            }
        }

        private void splitContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Cursor = Cursors.Hand;
        }

        private void splitContainer1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Cursor = Cursors.Default;
        }

        private void verificationtimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void webView23_Click(object sender, EventArgs e)
        {

        }

        private void webView23_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
         
        }

        private void webView23_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (webView23.CoreWebView2.DocumentTitle.Contains("offee"))
            { }

            else
            {
                if (webView23.CoreWebView2.DocumentTitle.Contains("インターネット接続なし"))
                { }
                else
                { 
                    //Q:今時marqueeを使うのですか!? A:はい!完全廃止になるまでは!


                webView23.CoreWebView2.NavigateToString("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n  <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\">\r\n  <title>インターネット接続なし</title>\r\n  <meta charset=\"UTF-8\">\r\n</head>\r\n<body>\r\n<marquee scrollamount=\"5\">インターネット接続が不安定または切断されているため、最新情報を取得できませんでした。インターネット接続をご確認ください。<a href=\"https://yokokiri-cha.github.io/latestnewsoss\">再取得する場合は青色のこのテキストをクリックしてください。</a></marquee>\r\n</body>\r\n</html>");
            }
            }
        }
        private void reconnect()
        {
            /*
            if (webView23.CoreWebView2.DocumentTitle.Contains("offee"))
            {

            }
            else
            {
                webView23.CoreWebView2.Reload();
                webView22.CoreWebView2.Reload();
            }

            */
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_3(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("右側パネルを非表示にしました", fl);
            }
            splitContainer1.Panel2Collapsed = true;
            
        }

        private void toolStripLabel25_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("ミニサーチの表示と非表示を切り替えました", fl);
            }
            if (tableLayoutPanel1.Visible)
            {
                if (p2c == "1")
                {
                    p2c = "";
                    splitContainer1.Panel2Collapsed = true;  //形状復元
                    tableLayoutPanel1.Visible = false;
                }
                else
                {
                    tableLayoutPanel1.Visible = false;
                }
            }
            else
            {
                if (splitContainer1.Panel2Collapsed == true)
                {
                    p2c = "1";//形状記憶
                    splitContainer1.Panel2Collapsed = false;
                    tableLayoutPanel1.Visible = true;
                }
                else
                {
                    tableLayoutPanel1.Visible = true;
                }
            }

        }

        private void toolStripLabel26_Click(object sender, EventArgs e)
        {
            if (invisiblestore.Checked)
            {
                SpVoice syab = new SpVoice();

                SpeechVoiceSpeakFlags fl = SpeechVoiceSpeakFlags.SVSFlagsAsync | SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak;

                syab.Speak("前面固定設定を切り替えました", fl);
            }
            if (this.TopMost == true)
            {
                MessageBox.Show("前面固定を解除しました");
            this.TopMost = false;
            }
            else
            {
                MessageBox.Show("前面固定に設定しました");
                this.TopMost = true;
            }
        }
    }
}