using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDChecker
{
    public partial class UIDInput : Form
    {
        public UIDInput()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            mainForm.listBox1.Items.Clear();
            foreach (var line in this.textBox1.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                mainForm.listBox1.Items.Add(line.Trim());
            }
            File.WriteAllLines("uids.txt", mainForm.listBox1.Items.Cast<string>().ToArray());
            this.Close();
        }
    }
}
