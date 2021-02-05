
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
            this.button1 = new System.Windows.Forms.Button();
            this.appendDataBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Queue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // appendDataBtn
            // 
            this.appendDataBtn.Location = new System.Drawing.Point(261, 179);
            this.appendDataBtn.Name = "appendDataBtn";
            this.appendDataBtn.Size = new System.Drawing.Size(164, 43);
            this.appendDataBtn.TabIndex = 1;
            this.appendDataBtn.Text = "Append data to file";
            this.appendDataBtn.UseVisualStyleBackColor = true;
            this.appendDataBtn.Click += new System.EventHandler(this.appendDataBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Generate random data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(55, 56);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(164, 57);
            this.fileSelectBtn.TabIndex = 3;
            this.fileSelectBtn.Text = "Select file";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(745, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Start System";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(55, 332);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(134, 57);
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
            this.dataGridView1.Location = new System.Drawing.Point(745, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 210);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(964, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pause System";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ThreadSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.appendDataBtn);
            this.Controls.Add(this.button1);
            this.Name = "ThreadSwitcher";
            this.Text = "Process Execution Sim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button appendDataBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.Button button2;
    }
}

