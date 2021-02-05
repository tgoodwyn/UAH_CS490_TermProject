
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
            this.babyFarts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 332);
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
            // babyFarts
            // 
            this.babyFarts.Location = new System.Drawing.Point(929, 74);
            this.babyFarts.Name = "babyFarts";
            this.babyFarts.Size = new System.Drawing.Size(134, 57);
            this.babyFarts.TabIndex = 5;
            this.babyFarts.Text = "Pause System";
            this.babyFarts.UseVisualStyleBackColor = true;
            this.babyFarts.Click += new System.EventHandler(this.babyFarts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ThreadSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.babyFarts);
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
        private System.Windows.Forms.Button babyFarts;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

