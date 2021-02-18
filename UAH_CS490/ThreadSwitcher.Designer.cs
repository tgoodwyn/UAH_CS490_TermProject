
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopSysBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadQueueBtn
            // 
            this.loadQueueBtn.Location = new System.Drawing.Point(196, 270);
            this.loadQueueBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loadQueueBtn.Name = "loadQueueBtn";
            this.loadQueueBtn.Size = new System.Drawing.Size(125, 46);
            this.loadQueueBtn.TabIndex = 0;
            this.loadQueueBtn.Text = "Load Queue";
            this.loadQueueBtn.UseVisualStyleBackColor = true;
            this.loadQueueBtn.Click += new System.EventHandler(this.loadQueueBtn_Click);
            // 
            // appendDataBtn
            // 
            this.appendDataBtn.Location = new System.Drawing.Point(196, 146);
            this.appendDataBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appendDataBtn.Name = "appendDataBtn";
            this.appendDataBtn.Size = new System.Drawing.Size(123, 35);
            this.appendDataBtn.TabIndex = 1;
            this.appendDataBtn.Text = "Append data to file";
            this.appendDataBtn.UseVisualStyleBackColor = true;
            this.appendDataBtn.Click += new System.EventHandler(this.appendDataBtn_Click);
            // 
            // randomDataBtn
            // 
            this.randomDataBtn.Location = new System.Drawing.Point(41, 144);
            this.randomDataBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.randomDataBtn.Name = "randomDataBtn";
            this.randomDataBtn.Size = new System.Drawing.Size(130, 36);
            this.randomDataBtn.TabIndex = 2;
            this.randomDataBtn.Text = "Generate random data";
            this.randomDataBtn.UseVisualStyleBackColor = true;
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(41, 45);
            this.fileSelectBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(123, 46);
            this.fileSelectBtn.TabIndex = 3;
            this.fileSelectBtn.Text = "Select file";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // startSysBtn
            // 
            this.startSysBtn.Location = new System.Drawing.Point(559, 60);
            this.startSysBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startSysBtn.Name = "startSysBtn";
            this.startSysBtn.Size = new System.Drawing.Size(101, 46);
            this.startSysBtn.TabIndex = 4;
            this.startSysBtn.Text = "Start System";
            this.startSysBtn.UseVisualStyleBackColor = true;
            this.startSysBtn.Click += new System.EventHandler(this.startSysBtn_Click);
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(41, 270);
            this.readFileBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(101, 46);
            this.readFileBtn.TabIndex = 5;
            this.readFileBtn.Text = "Read File";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcName,
            this.ServiceTime});
            this.dataGridView1.Location = new System.Drawing.Point(559, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(291, 170);
            this.dataGridView1.TabIndex = 6;
            // 
            // ProcName
            // 
            this.ProcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ProcName.HeaderText = "Process Name";
            this.ProcName.MinimumWidth = 6;
            this.ProcName.Name = "ProcName";
            this.ProcName.ReadOnly = true;
            this.ProcName.Width = 6;
            // 
            // ServiceTime
            // 
            this.ServiceTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ServiceTime.HeaderText = "Service Time";
            this.ServiceTime.MinimumWidth = 6;
            this.ServiceTime.Name = "ServiceTime";
            this.ServiceTime.ReadOnly = true;
            this.ServiceTime.Width = 6;
            // 
            // stopSysBtn
            // 
            this.stopSysBtn.Location = new System.Drawing.Point(723, 60);
            this.stopSysBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stopSysBtn.Name = "stopSysBtn";
            this.stopSysBtn.Size = new System.Drawing.Size(101, 46);
            this.stopSysBtn.TabIndex = 7;
            this.stopSysBtn.Text = "Pause System";
            this.stopSysBtn.UseVisualStyleBackColor = true;
            this.stopSysBtn.Click += new System.EventHandler(this.stopSysBtn_Click);
            // 
            // ThreadSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 547);
            this.Controls.Add(this.stopSysBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.startSysBtn);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.randomDataBtn);
            this.Controls.Add(this.appendDataBtn);
            this.Controls.Add(this.loadQueueBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ThreadSwitcher";
            this.Text = "Process Execution Sim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadQueueBtn;
        private System.Windows.Forms.Button appendDataBtn;
        private System.Windows.Forms.Button randomDataBtn;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Button startSysBtn;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.Button stopSysBtn;
    }
}

