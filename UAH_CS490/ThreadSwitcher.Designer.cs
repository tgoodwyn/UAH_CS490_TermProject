
namespace UAH_CS490
{
    partial class ThreadSwitcher
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
            this.loadQueueBtn = new System.Windows.Forms.Button();
            this.appendDataBtn = new System.Windows.Forms.Button();
            this.randomDataBtn = new System.Windows.Forms.Button();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.startSysBtn = new System.Windows.Forms.Button();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.stopSysBtn = new System.Windows.Forms.Button();
            this.QueueBox = new System.Windows.Forms.DataGridView();
            this.fileInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QueueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadQueueBtn
            // 
            this.loadQueueBtn.Location = new System.Drawing.Point(294, 415);
            this.loadQueueBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.loadQueueBtn.Name = "loadQueueBtn";
            this.loadQueueBtn.Size = new System.Drawing.Size(188, 71);
            this.loadQueueBtn.TabIndex = 0;
            this.loadQueueBtn.Text = "Load Queue";
            this.loadQueueBtn.UseVisualStyleBackColor = true;
            this.loadQueueBtn.Click += new System.EventHandler(this.loadQueueBtn_Click);
            // 
            // appendDataBtn
            // 
            this.appendDataBtn.Location = new System.Drawing.Point(294, 225);
            this.appendDataBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.appendDataBtn.Name = "appendDataBtn";
            this.appendDataBtn.Size = new System.Drawing.Size(184, 54);
            this.appendDataBtn.TabIndex = 1;
            this.appendDataBtn.Text = "Append data to file";
            this.appendDataBtn.UseVisualStyleBackColor = true;
            this.appendDataBtn.Click += new System.EventHandler(this.appendDataBtn_Click);
            // 
            // randomDataBtn
            // 
            this.randomDataBtn.Location = new System.Drawing.Point(62, 222);
            this.randomDataBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.randomDataBtn.Name = "randomDataBtn";
            this.randomDataBtn.Size = new System.Drawing.Size(195, 55);
            this.randomDataBtn.TabIndex = 2;
            this.randomDataBtn.Text = "Generate random data";
            this.randomDataBtn.UseVisualStyleBackColor = true;
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(62, 92);
            this.fileSelectBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(152, 36);
            this.fileSelectBtn.TabIndex = 3;
            this.fileSelectBtn.Text = "Select new file";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // startSysBtn
            // 
            this.startSysBtn.Location = new System.Drawing.Point(838, 92);
            this.startSysBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.startSysBtn.Name = "startSysBtn";
            this.startSysBtn.Size = new System.Drawing.Size(152, 71);
            this.startSysBtn.TabIndex = 4;
            this.startSysBtn.Text = "Start System";
            this.startSysBtn.UseVisualStyleBackColor = true;
            this.startSysBtn.Click += new System.EventHandler(this.startSysBtn_Click);
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(62, 415);
            this.readFileBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(152, 71);
            this.readFileBtn.TabIndex = 5;
            this.readFileBtn.Text = "Read File";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_click);
            // 
            // stopSysBtn
            // 
            this.stopSysBtn.Location = new System.Drawing.Point(1084, 92);
            this.stopSysBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.stopSysBtn.Name = "stopSysBtn";
            this.stopSysBtn.Size = new System.Drawing.Size(152, 71);
            this.stopSysBtn.TabIndex = 7;
            this.stopSysBtn.Text = "Pause System";
            this.stopSysBtn.UseVisualStyleBackColor = true;
            this.stopSysBtn.Click += new System.EventHandler(this.stopSysBtn_Click);
            // 
            // QueueBox
            // 
            this.QueueBox.AllowUserToDeleteRows = false;
            this.QueueBox.AllowUserToResizeColumns = false;
            this.QueueBox.AllowUserToResizeRows = false;
            this.QueueBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QueueBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueBox.Location = new System.Drawing.Point(580, 351);
            this.QueueBox.Name = "QueueBox";
            this.QueueBox.RowHeadersWidth = 62;
            this.QueueBox.RowTemplate.Height = 28;
            this.QueueBox.Size = new System.Drawing.Size(562, 320);
            this.QueueBox.TabIndex = 8;
            // 
            // fileInfo
            // 
            this.fileInfo.AutoSize = true;
            this.fileInfo.Location = new System.Drawing.Point(889, 222);
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Size = new System.Drawing.Size(51, 20);
            this.fileInfo.TabIndex = 9;
            this.fileInfo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current File:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentPathLabel
            // 
            this.currentPathLabel.AutoSize = true;
            this.currentPathLabel.Location = new System.Drawing.Point(163, 48);
            this.currentPathLabel.Name = "currentPathLabel";
            this.currentPathLabel.Size = new System.Drawing.Size(87, 20);
            this.currentPathLabel.TabIndex = 11;
            this.currentPathLabel.Text = "<filename>";
            // 
            // ThreadSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 842);
            this.Controls.Add(this.currentPathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileInfo);
            this.Controls.Add(this.QueueBox);
            this.Controls.Add(this.stopSysBtn);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.startSysBtn);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.randomDataBtn);
            this.Controls.Add(this.appendDataBtn);
            this.Controls.Add(this.loadQueueBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ThreadSwitcher";
            this.Text = "Process Execution Sim";
            this.Load += new System.EventHandler(this.ThreadSwitcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadQueueBtn;
        private System.Windows.Forms.Button appendDataBtn;
        private System.Windows.Forms.Button randomDataBtn;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Button startSysBtn;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button stopSysBtn;
        private System.Windows.Forms.DataGridView QueueBox;
        private System.Windows.Forms.Label fileInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPathLabel;
    }
}

