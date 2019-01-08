using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDChecker
{
    public partial class Form1 : Form
    {
        public string[] uids;
        public Form1()
        {
            InitializeComponent();
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
            // str = System.Web.HttpUtility.UrlEncode(url);
            str = Uri.EscapeUriString(str);
            //MessageBox.Show(str);
            webBrowser1.Navigate($"http://ts3index.com/?page=searchclient&uid={str}");
            webBrowser2.Navigate($"http://www.tsviewer.com/index.php?page=userinfo&ident={str}");
        }
    }
}
