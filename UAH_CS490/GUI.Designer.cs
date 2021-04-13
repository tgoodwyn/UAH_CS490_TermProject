
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
            this.cpu1QueueBox = new System.Windows.Forms.DataGridView();
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
            this.label10 = new System.Windows.Forms.Label();
            this.cpu1ResultsBox = new System.Windows.Forms.DataGridView();
            this.cpu2ProcTimeLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cpu2ProcNameLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.cpu2QueueBox = new System.Windows.Forms.DataGridView();
            this.cpu2ResultsBox = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.timesliceField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1QueueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1ResultsBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpu2QueueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu2ResultsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(103, 512);
            this.saveFileBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(197, 56);
            this.saveFileBtn.TabIndex = 3;
            this.saveFileBtn.Text = "Save changes";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(422, 509);
            this.fileSelectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(186, 64);
            this.fileSelectBtn.TabIndex = 1;
            this.fileSelectBtn.Text = "Select new file";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // startSysBtn
            // 
            this.startSysBtn.Location = new System.Drawing.Point(215, 638);
            this.startSysBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startSysBtn.Name = "startSysBtn";
            this.startSysBtn.Size = new System.Drawing.Size(186, 85);
            this.startSysBtn.TabIndex = 4;
            this.startSysBtn.Text = "Start System";
            this.startSysBtn.UseVisualStyleBackColor = true;
            this.startSysBtn.Click += new System.EventHandler(this.startSysBtn_Click);
            // 
            // stopSysBtn
            // 
            this.stopSysBtn.Location = new System.Drawing.Point(215, 773);
            this.stopSysBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopSysBtn.Name = "stopSysBtn";
            this.stopSysBtn.Size = new System.Drawing.Size(186, 85);
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
            this.FileBox.Location = new System.Drawing.Point(43, 128);
            this.FileBox.Margin = new System.Windows.Forms.Padding(4);
            this.FileBox.Name = "FileBox";
            this.FileBox.RowHeadersWidth = 62;
            this.FileBox.RowTemplate.Height = 28;
            this.FileBox.Size = new System.Drawing.Size(687, 281);
            this.FileBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 976);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current File:";
            // 
            // currentPathLabel
            // 
            this.currentPathLabel.AutoSize = true;
            this.currentPathLabel.Location = new System.Drawing.Point(193, 976);
            this.currentPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPathLabel.Name = "currentPathLabel";
            this.currentPathLabel.Size = new System.Drawing.Size(109, 25);
            this.currentPathLabel.TabIndex = 11;
            this.currentPathLabel.Text = "<filename>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 450);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edit table to add/change data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data from Selected File";
            // 
            // cpu1QueueBox
            // 
            this.cpu1QueueBox.AllowUserToAddRows = false;
            this.cpu1QueueBox.AllowUserToDeleteRows = false;
            this.cpu1QueueBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cpu1QueueBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpu1QueueBox.Location = new System.Drawing.Point(1070, 141);
            this.cpu1QueueBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpu1QueueBox.Name = "cpu1QueueBox";
            this.cpu1QueueBox.ReadOnly = true;
            this.cpu1QueueBox.RowHeadersWidth = 62;
            this.cpu1QueueBox.RowTemplate.Height = 28;
            this.cpu1QueueBox.Size = new System.Drawing.Size(326, 384);
            this.cpu1QueueBox.TabIndex = 14;
            // 
            // conversionRateField
            // 
            this.conversionRateField.Location = new System.Drawing.Point(524, 679);
            this.conversionRateField.Margin = new System.Windows.Forms.Padding(4);
            this.conversionRateField.Name = "conversionRateField";
            this.conversionRateField.Size = new System.Drawing.Size(121, 29);
            this.conversionRateField.TabIndex = 15;
            this.conversionRateField.Text = "1000";
            this.conversionRateField.TextChanged += new System.EventHandler(this.conversionRateField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 638);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "1 time unit =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 679);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(881, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "CPU 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Current Process:";
            // 
            // cpu1ProcNameLbl
            // 
            this.cpu1ProcNameLbl.AutoSize = true;
            this.cpu1ProcNameLbl.BackColor = System.Drawing.SystemColors.Control;
            this.cpu1ProcNameLbl.Location = new System.Drawing.Point(236, 67);
            this.cpu1ProcNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu1ProcNameLbl.Name = "cpu1ProcNameLbl";
            this.cpu1ProcNameLbl.Size = new System.Drawing.Size(40, 25);
            this.cpu1ProcNameLbl.TabIndex = 20;
            this.cpu1ProcNameLbl.Text = "n/a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Time remaining:";
            // 
            // cpu1ProcTimeLbl
            // 
            this.cpu1ProcTimeLbl.AutoSize = true;
            this.cpu1ProcTimeLbl.BackColor = System.Drawing.SystemColors.Control;
            this.cpu1ProcTimeLbl.Location = new System.Drawing.Point(236, 112);
            this.cpu1ProcTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu1ProcTimeLbl.Name = "cpu1ProcTimeLbl";
            this.cpu1ProcTimeLbl.Size = new System.Drawing.Size(23, 25);
            this.cpu1ProcTimeLbl.TabIndex = 22;
            this.cpu1ProcTimeLbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 726);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Elapsed time:";
            // 
            // totalTimeLab
            // 
            this.totalTimeLab.AutoSize = true;
            this.totalTimeLab.Location = new System.Drawing.Point(715, 725);
            this.totalTimeLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTimeLab.Name = "totalTimeLab";
            this.totalTimeLab.Size = new System.Drawing.Size(23, 25);
            this.totalTimeLab.TabIndex = 24;
            this.totalTimeLab.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1111, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Process Queue";
            // 
            // cpu1ResultsBox
            // 
            this.cpu1ResultsBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cpu1ResultsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpu1ResultsBox.Location = new System.Drawing.Point(1443, 141);
            this.cpu1ResultsBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpu1ResultsBox.Name = "cpu1ResultsBox";
            this.cpu1ResultsBox.RowHeadersWidth = 62;
            this.cpu1ResultsBox.RowTemplate.Height = 28;
            this.cpu1ResultsBox.Size = new System.Drawing.Size(668, 209);
            this.cpu1ResultsBox.TabIndex = 27;
            // 
            // cpu2ProcTimeLbl
            // 
            this.cpu2ProcTimeLbl.AutoSize = true;
            this.cpu2ProcTimeLbl.Location = new System.Drawing.Point(1797, 916);
            this.cpu2ProcTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu2ProcTimeLbl.Name = "cpu2ProcTimeLbl";
            this.cpu2ProcTimeLbl.Size = new System.Drawing.Size(23, 25);
            this.cpu2ProcTimeLbl.TabIndex = 32;
            this.cpu2ProcTimeLbl.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1623, 916);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Time remaining:";
            // 
            // cpu2ProcNameLbl
            // 
            this.cpu2ProcNameLbl.AutoSize = true;
            this.cpu2ProcNameLbl.Location = new System.Drawing.Point(1797, 870);
            this.cpu2ProcNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu2ProcNameLbl.Name = "cpu2ProcNameLbl";
            this.cpu2ProcNameLbl.Size = new System.Drawing.Size(40, 25);
            this.cpu2ProcNameLbl.TabIndex = 30;
            this.cpu2ProcNameLbl.Text = "n/a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1623, 870);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Current Process:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(881, 709);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 31);
            this.label15.TabIndex = 28;
            this.label15.Text = "CPU 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1611, 53);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "Completed Processes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cpu1ProcNameLbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cpu1ProcTimeLbl);
            this.panel1.Location = new System.Drawing.Point(1581, 390);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 145);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(1581, 809);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 145);
            this.panel2.TabIndex = 35;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(515, 779);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(177, 72);
            this.resetBtn.TabIndex = 36;
            this.resetBtn.Text = "Reset System";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // cpu2QueueBox
            // 
            this.cpu2QueueBox.AllowUserToAddRows = false;
            this.cpu2QueueBox.AllowUserToDeleteRows = false;
            this.cpu2QueueBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cpu2QueueBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpu2QueueBox.Location = new System.Drawing.Point(1070, 570);
            this.cpu2QueueBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpu2QueueBox.Name = "cpu2QueueBox";
            this.cpu2QueueBox.ReadOnly = true;
            this.cpu2QueueBox.RowHeadersWidth = 62;
            this.cpu2QueueBox.RowTemplate.Height = 28;
            this.cpu2QueueBox.Size = new System.Drawing.Size(326, 384);
            this.cpu2QueueBox.TabIndex = 37;
            // 
            // cpu2ResultsBox
            // 
            this.cpu2ResultsBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cpu2ResultsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpu2ResultsBox.Location = new System.Drawing.Point(1443, 570);
            this.cpu2ResultsBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpu2ResultsBox.Name = "cpu2ResultsBox";
            this.cpu2ResultsBox.RowHeadersWidth = 62;
            this.cpu2ResultsBox.RowTemplate.Height = 28;
            this.cpu2ResultsBox.Size = new System.Drawing.Size(668, 209);
            this.cpu2ResultsBox.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(882, 346);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Time slice length";
            // 
            // timesliceField
            // 
            this.timesliceField.Location = new System.Drawing.Point(887, 390);
            this.timesliceField.Margin = new System.Windows.Forms.Padding(4);
            this.timesliceField.Name = "timesliceField";
            this.timesliceField.Size = new System.Drawing.Size(121, 29);
            this.timesliceField.TabIndex = 40;
            this.timesliceField.Text = "2";
            this.timesliceField.TextChanged += new System.EventHandler(this.timesliceField_TextChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1026);
            this.Controls.Add(this.timesliceField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cpu2ResultsBox);
            this.Controls.Add(this.cpu2QueueBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cpu2ProcTimeLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cpu2ProcNameLbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cpu1ResultsBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalTimeLab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conversionRateField);
            this.Controls.Add(this.cpu1QueueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.stopSysBtn);
            this.Controls.Add(this.startSysBtn);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "GUI";
            this.Text = "Process Execution Sim";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1QueueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1ResultsBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpu2QueueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu2ResultsBox)).EndInit();
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
        private System.Windows.Forms.DataGridView cpu1QueueBox;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView cpu1ResultsBox;
        private System.Windows.Forms.Label cpu2ProcTimeLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cpu2ProcNameLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView cpu2QueueBox;
        private System.Windows.Forms.DataGridView cpu2ResultsBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox timesliceField;
    }
}

