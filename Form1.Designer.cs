namespace CpuSchedulingWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelProcess = new System.Windows.Forms.Label();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.fcfs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.strfBtn = new System.Windows.Forms.Button();
            this.ltrfBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(79, 45);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(108, 13);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "Number of Processes";
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(218, 42);
            this.txtProcess.Multiline = true;
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(132, 33);
            this.txtProcess.TabIndex = 1;
            this.txtProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProcess.TextChanged += new System.EventHandler(this.txtProcess_TextChanged);
            // 
            // fcfs
            // 
            this.fcfs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fcfs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fcfs.Location = new System.Drawing.Point(4, 99);
            this.fcfs.Name = "fcfs";
            this.fcfs.Size = new System.Drawing.Size(137, 45);
            this.fcfs.TabIndex = 2;
            this.fcfs.Text = "FCFS";
            this.fcfs.UseVisualStyleBackColor = true;
            this.fcfs.Click += new System.EventHandler(this.fcfs_Click);
            // 
            // button2 (Shortest Job First)
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(160, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "SHORTEST JOB FIRST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPriority.Location = new System.Drawing.Point(312, 99);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(134, 45);
            this.btnPriority.TabIndex = 4;
            this.btnPriority.Text = "PRIORITY";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // strfBtn (Shortest Remaining Time First)
            // 
            this.strfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.strfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.strfBtn.Location = new System.Drawing.Point(4, 160);
            this.strfBtn.Name = "strfBtn";
            this.strfBtn.Size = new System.Drawing.Size(137, 44);
            this.strfBtn.TabIndex = 5;
            this.strfBtn.Text = "SRTF";
            this.strfBtn.UseVisualStyleBackColor = true;
            this.strfBtn.Click += new System.EventHandler(this.strfBtn_Click);
            // 
            // ltrfBtn (Longest Remaining Time First)
            // 
            this.ltrfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltrfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ltrfBtn.Location = new System.Drawing.Point(160, 160);
            this.ltrfBtn.Name = "ltrfBtn";
            this.ltrfBtn.Size = new System.Drawing.Size(134, 44);
            this.ltrfBtn.TabIndex = 6;
            this.ltrfBtn.Text = "LRTF";
            this.ltrfBtn.UseVisualStyleBackColor = true;
            this.ltrfBtn.Click += new System.EventHandler(this.ltrfBtn_Click);
            // 
            // label1 (Restart Application)
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(353, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Restart Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltrfBtn);
            this.Controls.Add(this.strfBtn);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fcfs);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.labelProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU SCHEDULING";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelProcess;
        public System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Button fcfs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button strfBtn;
        private System.Windows.Forms.Button ltrfBtn;
        private System.Windows.Forms.Label label1;
    }
}
