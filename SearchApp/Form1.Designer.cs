namespace SearchApp
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tbSearchDir = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.currentD = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.resetBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filesFoundLabel = new System.Windows.Forms.Label();
            this.timeElapsed = new System.Windows.Forms.Label();
            this.stat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 62);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(378, 462);
            this.treeView1.TabIndex = 0;
            // 
            // tbSearchDir
            // 
            this.tbSearchDir.Location = new System.Drawing.Point(661, 62);
            this.tbSearchDir.Name = "tbSearchDir";
            this.tbSearchDir.Size = new System.Drawing.Size(583, 20);
            this.tbSearchDir.TabIndex = 1;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(661, 118);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(583, 20);
            this.tbFN.TabIndex = 2;
            // 
            // currentD
            // 
            this.currentD.Location = new System.Drawing.Point(661, 177);
            this.currentD.Name = "currentD";
            this.currentD.Size = new System.Drawing.Size(583, 20);
            this.currentD.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(661, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(583, 303);
            this.listBox1.TabIndex = 4;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(1334, 62);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click_1);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(1334, 116);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click_1);
            // 
            // resetBut
            // 
            this.resetBut.Location = new System.Drawing.Point(1334, 174);
            this.resetBut.Name = "resetBut";
            this.resetBut.Size = new System.Drawing.Size(75, 23);
            this.resetBut.TabIndex = 7;
            this.resetBut.Text = "Reset";
            this.resetBut.UseVisualStyleBackColor = true;
            this.resetBut.Click += new System.EventHandler(this.resetBut_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1263, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Files prosessed:";
            // 
            // filesFoundLabel
            // 
            this.filesFoundLabel.AutoSize = true;
            this.filesFoundLabel.Location = new System.Drawing.Point(1263, 310);
            this.filesFoundLabel.Name = "filesFoundLabel";
            this.filesFoundLabel.Size = new System.Drawing.Size(61, 13);
            this.filesFoundLabel.TabIndex = 9;
            this.filesFoundLabel.Text = "Files found:";
            // 
            // timeElapsed
            // 
            this.timeElapsed.AutoSize = true;
            this.timeElapsed.Location = new System.Drawing.Point(1263, 352);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(73, 13);
            this.timeElapsed.TabIndex = 10;
            this.timeElapsed.Text = "Time elapsed:";
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Location = new System.Drawing.Point(23, 13);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(64, 13);
            this.stat.TabIndex = 11;
            this.stat.Text = "Work status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "File name";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1435, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.timeElapsed);
            this.Controls.Add(this.filesFoundLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetBut);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.currentD);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.tbSearchDir);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "FileScan";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private System.Windows.Forms.Label searchDir;
       // private System.Windows.Forms.TreeView treeView1;
      
       // private System.Windows.Forms.Label fn;
       // private System.Windows.Forms.TextBox tbFN;
       // private System.Windows.Forms.ListBox listBox1;
       // private System.Windows.Forms.Button buttonRun;
      //  private System.Windows.Forms.Button buttonStop;
       // private System.Windows.Forms.Label label1;
       // private System.Windows.Forms.Label label3;
       // private System.Windows.Forms.Label filesFoundLabel;
       // private System.Windows.Forms.TextBox currentPath;
       // private System.Windows.Forms.Timer timer1;
       // private System.Windows.Forms.Button resetButton;
       // private System.Windows.Forms.Label status;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbSearchDir;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox currentD;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button resetBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filesFoundLabel;
        private System.Windows.Forms.Label timeElapsed;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

