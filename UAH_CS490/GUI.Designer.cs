
namespace UAH_CS490
{
    partial class GUI
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
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.startSysBtn = new System.Windows.Forms.Button();
            this.stopSysBtn = new System.Windows.Forms.Button();
            this.FileBox = new System.Windows.Forms.DataGridView();
            this.fileInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QueueBox = new System.Windows.Forms.DataGridView();
            this.conversionRateField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(363, 550);
            this.saveFileBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(234, 80);
            this.saveFileBtn.TabIndex = 3;
            this.saveFileBtn.Text = "Save changes to current file";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(62, 92);
            this.fileSelectBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(152, 36);
            this.fileSelectBtn.TabIndex = 1;
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
            // FileBox
            // 
            this.FileBox.AllowUserToDeleteRows = false;
            this.FileBox.AllowUserToResizeColumns = false;
            this.FileBox.AllowUserToResizeRows = false;
            this.FileBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileBox.Location = new System.Drawing.Point(35, 222);
            this.FileBox.Name = "FileBox";
            this.FileBox.RowHeadersWidth = 62;
            this.FileBox.RowTemplate.Height = 28;
            this.FileBox.Size = new System.Drawing.Size(562, 320);
            this.FileBox.TabIndex = 8;
            // 
            // fileInfo
            // 
            this.fileInfo.AutoSize = true;
            this.fileInfo.Location = new System.Drawing.Point(1009, 176);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edit table to add/change data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data from Selected File";
            // 
            // QueueBox
            // 
            this.QueueBox.AllowUserToAddRows = false;
            this.QueueBox.AllowUserToDeleteRows = false;
            this.QueueBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QueueBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueBox.Location = new System.Drawing.Point(895, 222);
            this.QueueBox.Name = "QueueBox";
            this.QueueBox.ReadOnly = true;
            this.QueueBox.RowHeadersWidth = 62;
            this.QueueBox.RowTemplate.Height = 28;
            this.QueueBox.Size = new System.Drawing.Size(267, 320);
            this.QueueBox.TabIndex = 14;
            // 
            // conversionRateField
            // 
            this.conversionRateField.Location = new System.Drawing.Point(731, 249);
            this.conversionRateField.Name = "conversionRateField";
            this.conversionRateField.Size = new System.Drawing.Size(100, 26);
            this.conversionRateField.TabIndex = 15;
            this.conversionRateField.Text = "1000";
            this.conversionRateField.TextChanged += new System.EventHandler(this.conversionRateField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "1 time unit =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "ms";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 842);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conversionRateField);
            this.Controls.Add(this.QueueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileInfo);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.stopSysBtn);
            this.Controls.Add(this.startSysBtn);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GUI";
            this.Text = "Process Execution Sim";
            this.Load += new System.EventHandler(this.ThreadSwitcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Button startSysBtn;
        private System.Windows.Forms.Button stopSysBtn;
        private System.Windows.Forms.DataGridView FileBox;
        private System.Windows.Forms.Label fileInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView QueueBox;
        private System.Windows.Forms.TextBox conversionRateField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

