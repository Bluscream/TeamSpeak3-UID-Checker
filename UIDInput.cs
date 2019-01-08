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
            Form1 mainForm = (Form1)Owner;
            mainForm.listBox1.Items.Clear();
            foreach (var line in this.textBox1.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                mainForm.listBox1.Items.Add(line.Trim());
            }
            this.Close();
        }
    }
}
