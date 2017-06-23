namespace HiraKana
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timeIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.characterSetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiraganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katakanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 153);
            this.label1.TabIndex = 2;
            this.label1.Text = "か";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "HiraKana";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeIntervalToolStripMenuItem,
            this.characterSetsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            this.contextMenuStrip1.Text = "Time interval";
            // 
            // timeIntervalToolStripMenuItem
            // 
            this.timeIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem,
            this.minToolStripMenuItem,
            this.minToolStripMenuItem1,
            this.minToolStripMenuItem2});
            this.timeIntervalToolStripMenuItem.Name = "timeIntervalToolStripMenuItem";
            this.timeIntervalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.timeIntervalToolStripMenuItem.Text = "Time interval";
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.secToolStripMenuItem.Tag = "0";
            this.secToolStripMenuItem.Text = "30 sec";
            this.secToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem.Tag = "1";
            this.minToolStripMenuItem.Text = "1 min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            this.minToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem1.Tag = "2";
            this.minToolStripMenuItem1.Text = "5 min";
            this.minToolStripMenuItem1.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            this.minToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem2.Tag = "3";
            this.minToolStripMenuItem2.Text = "10 min";
            this.minToolStripMenuItem2.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // characterSetsToolStripMenuItem
            // 
            this.characterSetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiraganaToolStripMenuItem,
            this.katakanaToolStripMenuItem});
            this.characterSetsToolStripMenuItem.Name = "characterSetsToolStripMenuItem";
            this.characterSetsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.characterSetsToolStripMenuItem.Text = "Character sets";
            // 
            // hiraganaToolStripMenuItem
            // 
            this.hiraganaToolStripMenuItem.Checked = true;
            this.hiraganaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hiraganaToolStripMenuItem.Name = "hiraganaToolStripMenuItem";
            this.hiraganaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.hiraganaToolStripMenuItem.Text = "Hiragana";
            this.hiraganaToolStripMenuItem.Click += new System.EventHandler(this.hiraganaToolStripMenuItem_Click);
            // 
            // katakanaToolStripMenuItem
            // 
            this.katakanaToolStripMenuItem.Checked = true;
            this.katakanaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.katakanaToolStripMenuItem.Name = "katakanaToolStripMenuItem";
            this.katakanaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.katakanaToolStripMenuItem.Text = "Katakana";
            this.katakanaToolStripMenuItem.Click += new System.EventHandler(this.katakanaToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Quit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "What sound does this make?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem timeIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem characterSetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiraganaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katakanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

