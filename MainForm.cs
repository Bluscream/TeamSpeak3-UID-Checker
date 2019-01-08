using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Windows.Forms;

namespace UIDChecker
{
    public partial class MainForm : Form
    {
        private string[] ignoredSchemes = { "res", "about" };
        private string[] ignoredDomains = { "googleads.g.doubleclick.net", "www.instant-gaming.com" };
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (File.Exists("uids.txt"))
            {
                listBox1.Items.AddRange(File.ReadAllLines("uids.txt").Cast<object>().ToArray());
            }
        }

        private void enterUIDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            var uidForm = new UIDInput();
            uidForm.Owner = this;
            // Show the settings form
            uidForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = listBox1.SelectedItem.ToString();
            if (string.IsNullOrEmpty(str)) return;
            // str = Uri.HexEscape(str.ToCharArray());
            str = HttpUtility.UrlEncode(str);
            // str = Uri.EscapeUriString(str);
            web_ts3index.Navigate($"http://ts3index.com/?page=searchclient&uid={str}");
            web_tsviewer.Navigate($"http://www.tsviewer.com/index.php?page=userinfo&ident={str}");
        }

        private void web_ts3index_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!CheckURL(e)) return;
            txt_ts3index.Text = e.Url.ToString();
        }

        private void web_tsviewer_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!CheckURL(e)) return;
            txt_tsviewer.Text = e.Url.ToString();
        }

        private bool CheckURL(WebBrowserNavigatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.TargetFrameName) == false) return false;
            if (ignoredSchemes.Contains(e.Url.Scheme)) return false;
            if (ignoredDomains.Contains(e.Url.Host)) return false;
            return true;
        }

        private void web_tsviewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            web_tsviewer.Document.Window.ScrollTo(0, web_tsviewer.Document.Window.Size.Height);
        }
    }
}
