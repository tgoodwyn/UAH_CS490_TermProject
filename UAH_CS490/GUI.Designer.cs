
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentPathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QueueBox = new System.Windows.Forms.DataGridView();
            this.conversionRateField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpu1ProcNameLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpu1ProcTimeLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalTimeLab = new System.Windows.Forms.Label();
            this.completedLab = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.resultsView = new System.Windows.Forms.DataGridView();
            this.cpu2ProcTimeLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cpu2ProcNameLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(84, 427);
            this.saveFileBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(161, 47);
            this.saveFileBtn.TabIndex = 3;
            this.saveFileBtn.Text = "Save changes";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(345, 424);
            this.fileSelectBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(152, 53);
            this.fileSelectBtn.TabIndex = 1;
            this.fileSelectBtn.Text = "Select new file";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // startSysBtn
            // 
            this.startSysBtn.Location = new System.Drawing.Point(704, 201);
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
            this.stopSysBtn.Location = new System.Drawing.Point(704, 317);
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
            this.FileBox.Location = new System.Drawing.Point(35, 107);
            this.FileBox.Name = "FileBox";
            this.FileBox.RowHeadersWidth = 62;
            this.FileBox.RowTemplate.Height = 28;
            this.FileBox.Size = new System.Drawing.Size(562, 234);
            this.FileBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 813);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current File:";
            // 
            // currentPathLabel
            // 
            this.currentPathLabel.AutoSize = true;
            this.currentPathLabel.Location = new System.Drawing.Point(158, 813);
            this.currentPathLabel.Name = "currentPathLabel";
            this.currentPathLabel.Size = new System.Drawing.Size(87, 20);
            this.currentPathLabel.TabIndex = 11;
            this.currentPathLabel.Text = "<filename>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edit table to add/change data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 41);
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
            this.QueueBox.Location = new System.Drawing.Point(895, 96);
            this.QueueBox.Name = "QueueBox";
            this.QueueBox.ReadOnly = true;
            this.QueueBox.RowHeadersWidth = 62;
            this.QueueBox.RowTemplate.Height = 28;
            this.QueueBox.Size = new System.Drawing.Size(267, 320);
            this.QueueBox.TabIndex = 14;
            // 
            // conversionRateField
            // 
            this.conversionRateField.Location = new System.Drawing.Point(704, 141);
            this.conversionRateField.Name = "conversionRateField";
            this.conversionRateField.Size = new System.Drawing.Size(100, 26);
            this.conversionRateField.TabIndex = 15;
            this.conversionRateField.Text = "1000";
            this.conversionRateField.TextChanged += new System.EventHandler(this.conversionRateField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "1 time unit =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(810, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(981, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "CPU 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(981, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Current Process:";
            // 
            // cpu1ProcNameLbl
            // 
            this.cpu1ProcNameLbl.AutoSize = true;
            this.cpu1ProcNameLbl.Location = new System.Drawing.Point(1123, 494);
            this.cpu1ProcNameLbl.Name = "cpu1ProcNameLbl";
            this.cpu1ProcNameLbl.Size = new System.Drawing.Size(31, 20);
            this.cpu1ProcNameLbl.TabIndex = 20;
            this.cpu1ProcNameLbl.Text = "n/a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(981, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Time remaining:";
            // 
            // cpu1ProcTimeLbl
            // 
            this.cpu1ProcTimeLbl.AutoSize = true;
            this.cpu1ProcTimeLbl.Location = new System.Drawing.Point(1123, 532);
            this.cpu1ProcTimeLbl.Name = "cpu1ProcTimeLbl";
            this.cpu1ProcTimeLbl.Size = new System.Drawing.Size(18, 20);
            this.cpu1ProcTimeLbl.TabIndex = 22;
            this.cpu1ProcTimeLbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(943, 744);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Elapsed time:";
            // 
            // totalTimeLab
            // 
            this.totalTimeLab.AutoSize = true;
            this.totalTimeLab.Location = new System.Drawing.Point(1111, 743);
            this.totalTimeLab.Name = "totalTimeLab";
            this.totalTimeLab.Size = new System.Drawing.Size(18, 20);
            this.totalTimeLab.TabIndex = 24;
            this.totalTimeLab.Text = "0";
            // 
            // completedLab
            // 
            this.completedLab.AutoSize = true;
            this.completedLab.Location = new System.Drawing.Point(1253, 132);
            this.completedLab.Name = "completedLab";
            this.completedLab.Size = new System.Drawing.Size(168, 20);
            this.completedLab.TabIndex = 25;
            this.completedLab.Text = "Completed Processes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(928, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "Process Queue";
            // 
            // resultsView
            // 
            this.resultsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsView.Location = new System.Drawing.Point(51, 608);
            this.resultsView.Name = "resultsView";
            this.resultsView.RowHeadersWidth = 62;
            this.resultsView.RowTemplate.Height = 28;
            this.resultsView.Size = new System.Drawing.Size(830, 174);
            this.resultsView.TabIndex = 27;
            // 
            // cpu2ProcTimeLbl
            // 
            this.cpu2ProcTimeLbl.AutoSize = true;
            this.cpu2ProcTimeLbl.Location = new System.Drawing.Point(1123, 683);
            this.cpu2ProcTimeLbl.Name = "cpu2ProcTimeLbl";
            this.cpu2ProcTimeLbl.Size = new System.Drawing.Size(18, 20);
            this.cpu2ProcTimeLbl.TabIndex = 32;
            this.cpu2ProcTimeLbl.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(981, 683);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Time remaining:";
            // 
            // cpu2ProcNameLbl
            // 
            this.cpu2ProcNameLbl.AutoSize = true;
            this.cpu2ProcNameLbl.Location = new System.Drawing.Point(1123, 645);
            this.cpu2ProcNameLbl.Name = "cpu2ProcNameLbl";
            this.cpu2ProcNameLbl.Size = new System.Drawing.Size(31, 20);
            this.cpu2ProcNameLbl.TabIndex = 30;
            this.cpu2ProcNameLbl.Text = "n/a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(981, 645);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Current Process:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(981, 605);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "CPU 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(332, 556);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 29);
            this.label13.TabIndex = 33;
            this.label13.Text = "Completed Processes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(947, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 121);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(947, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 121);
            this.panel2.TabIndex = 35;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(704, 434);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(145, 60);
            this.resetBtn.TabIndex = 36;
            this.resetBtn.Text = "Reset System";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 842);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cpu2ProcTimeLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cpu2ProcNameLbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.resultsView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.completedLab);
            this.Controls.Add(this.totalTimeLab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cpu1ProcTimeLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cpu1ProcNameLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conversionRateField);
            this.Controls.Add(this.QueueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.stopSysBtn);
            this.Controls.Add(this.startSysBtn);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GUI";
            this.Text = "Process Execution Sim";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Button startSysBtn;
        private System.Windows.Forms.Button stopSysBtn;
        private System.Windows.Forms.DataGridView FileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView QueueBox;
        private System.Windows.Forms.TextBox conversionRateField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cpu1ProcNameLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cpu1ProcTimeLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalTimeLab;
        private System.Windows.Forms.Label completedLab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView resultsView;
        private System.Windows.Forms.Label cpu2ProcTimeLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cpu2ProcNameLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resetBtn;
    }
}

