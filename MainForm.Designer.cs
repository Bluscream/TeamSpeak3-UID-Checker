namespace UIDChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enterUIDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.web_ts3index = new System.Windows.Forms.WebBrowser();
            this.web_tsviewer = new System.Windows.Forms.WebBrowser();
            this.grp_tsviewer = new System.Windows.Forms.GroupBox();
            this.txt_tsviewer = new System.Windows.Forms.TextBox();
            this.grp_ts3index = new System.Windows.Forms.GroupBox();
            this.txt_ts3index = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grp_tsviewer.SuspendLayout();
            this.grp_ts3index.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterUIDsToolStripMenuItem,
            this.loadFromDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enterUIDsToolStripMenuItem
            // 
            this.enterUIDsToolStripMenuItem.Name = "enterUIDsToolStripMenuItem";
            this.enterUIDsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.enterUIDsToolStripMenuItem.Text = "Enter UIDs";
            this.enterUIDsToolStripMenuItem.Click += new System.EventHandler(this.enterUIDsToolStripMenuItem_Click);
            // 
            // loadFromDatabaseToolStripMenuItem
            // 
            this.loadFromDatabaseToolStripMenuItem.Enabled = false;
            this.loadFromDatabaseToolStripMenuItem.Name = "loadFromDatabaseToolStripMenuItem";
            this.loadFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.loadFromDatabaseToolStripMenuItem.Text = "Load From Database";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 736);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // web_ts3index
            // 
            this.web_ts3index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_ts3index.Location = new System.Drawing.Point(3, 16);
            this.web_ts3index.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_ts3index.Name = "web_ts3index";
            this.web_ts3index.ScriptErrorsSuppressed = true;
            this.web_ts3index.Size = new System.Drawing.Size(498, 717);
            this.web_ts3index.TabIndex = 0;
            this.web_ts3index.Url = new System.Uri("", System.UriKind.Relative);
            this.web_ts3index.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.web_ts3index_Navigating);
            // 
            // web_tsviewer
            // 
            this.web_tsviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_tsviewer.Location = new System.Drawing.Point(3, 16);
            this.web_tsviewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_tsviewer.Name = "web_tsviewer";
            this.web_tsviewer.ScriptErrorsSuppressed = true;
            this.web_tsviewer.Size = new System.Drawing.Size(559, 717);
            this.web_tsviewer.TabIndex = 0;
            this.web_tsviewer.Url = new System.Uri("", System.UriKind.Relative);
            this.web_tsviewer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_tsviewer_DocumentCompleted);
            this.web_tsviewer.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.web_tsviewer_Navigating);
            // 
            // grp_tsviewer
            // 
            this.grp_tsviewer.Controls.Add(this.txt_tsviewer);
            this.grp_tsviewer.Controls.Add(this.web_tsviewer);
            this.grp_tsviewer.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_tsviewer.Location = new System.Drawing.Point(671, 24);
            this.grp_tsviewer.Name = "grp_tsviewer";
            this.grp_tsviewer.Size = new System.Drawing.Size(565, 736);
            this.grp_tsviewer.TabIndex = 3;
            this.grp_tsviewer.TabStop = false;
            this.grp_tsviewer.Text = "TSViewer";
            // 
            // txt_tsviewer
            // 
            this.txt_tsviewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_tsviewer.Location = new System.Drawing.Point(3, 16);
            this.txt_tsviewer.Name = "txt_tsviewer";
            this.txt_tsviewer.ReadOnly = true;
            this.txt_tsviewer.Size = new System.Drawing.Size(559, 20);
            this.txt_tsviewer.TabIndex = 1;
            // 
            // grp_ts3index
            // 
            this.grp_ts3index.Controls.Add(this.txt_ts3index);
            this.grp_ts3index.Controls.Add(this.web_ts3index);
            this.grp_ts3index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_ts3index.Location = new System.Drawing.Point(167, 24);
            this.grp_ts3index.Name = "grp_ts3index";
            this.grp_ts3index.Size = new System.Drawing.Size(504, 736);
            this.grp_ts3index.TabIndex = 4;
            this.grp_ts3index.TabStop = false;
            this.grp_ts3index.Text = "TS3Index";
            // 
            // txt_ts3index
            // 
            this.txt_ts3index.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_ts3index.Location = new System.Drawing.Point(3, 16);
            this.txt_ts3index.Name = "txt_ts3index";
            this.txt_ts3index.ReadOnly = true;
            this.txt_ts3index.Size = new System.Drawing.Size(498, 20);
            this.txt_ts3index.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 760);
            this.Controls.Add(this.grp_ts3index);
            this.Controls.Add(this.grp_tsviewer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TeamSpeak 3 UID Checker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_tsviewer.ResumeLayout(false);
            this.grp_tsviewer.PerformLayout();
            this.grp_ts3index.ResumeLayout(false);
            this.grp_ts3index.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enterUIDsToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser web_ts3index;
        private System.Windows.Forms.WebBrowser web_tsviewer;
        private System.Windows.Forms.ToolStripMenuItem loadFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_tsviewer;
        private System.Windows.Forms.TextBox txt_tsviewer;
        private System.Windows.Forms.GroupBox grp_ts3index;
        private System.Windows.Forms.TextBox txt_ts3index;
    }
}

