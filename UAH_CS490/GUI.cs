using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using UAH_CS490.Utils;

namespace UAH_CS490
{
    public partial class GUI : Form
    {

        public static readonly string homeDir = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName; //path to solution directory, also has our default data file
        public static readonly string defaultFilePath = Path.Combine(homeDir, "TestData.csv"); // full path to default data file


        // variables
        public static string currentlySelectedFilePath; // this will hold the path to whatever data file the user selects

        private OS os;
        private bool loaded = false;

        public GUI()
        {
            currentlySelectedFilePath = defaultFilePath;
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            os = new OS(this);
            totalTimeLab.Text = os.TotalElapsedTime.ToString();
            formatResultsTable();
            formatWaitQueueTable();
            FileHandler.createDT(currentlySelectedFilePath);
            FileBox.DataSource = FileHandler.dataFromFile;


            currentPathLabel.Text = currentlySelectedFilePath;
            OS.clockUnit = int.Parse(conversionRateField.Text);

        }

        private void formatResultsTable()
        {
            resultsView.AutoGenerateColumns = false;
            resultsView.Columns.Clear();
            resultsView.ColumnCount = 6;
            resultsView.Columns[0].Name = "Name";
            resultsView.Columns[0].DataPropertyName = "Name";
            resultsView.Columns[1].Name = "Arrival Time";
            resultsView.Columns[1].DataPropertyName = "ArrivalTime";
            resultsView.Columns[2].Name = "Service Time";
            resultsView.Columns[2].DataPropertyName = "ServiceTime";
            resultsView.Columns[3].Name = "Finish Time";
            resultsView.Columns[3].DataPropertyName = "FinishTime";
            resultsView.Columns[4].Name = "Turnaround Time";
            resultsView.Columns[4].DataPropertyName = "TurnaroundTime";
            resultsView.Columns[5].Name = "Normalized TAT";
            resultsView.Columns[5].DataPropertyName = "NormalizedTAT";
            resultsView.Columns[5].DefaultCellStyle.Format = "N2";
            resultsView.DataSource = os.FinishedProcs;
        }

        private void formatWaitQueueTable()
        {
            QueueBox.AutoGenerateColumns = false;
            QueueBox.Columns.Clear();
            QueueBox.ColumnCount = 2;
            QueueBox.Columns[0].Name = "Process Name";
            QueueBox.Columns[0].DataPropertyName = "Name";
            QueueBox.Columns[1].Name = "Service Time";
            QueueBox.Columns[1].DataPropertyName = "ServiceTime";
            QueueBox.DataSource = os.DisplayQueue;
        }

        private void fileSelectBtn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.InitialDirectory = homeDir;
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    currentlySelectedFilePath = filePath;
                    currentPathLabel.Text = currentlySelectedFilePath;
                    FileHandler.createDT(currentlySelectedFilePath);
                    FileBox.DataSource = FileHandler.dataFromFile;
                }
            }

        }


        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            FileHandler.exportDTableToCSV();
        }

        private void startSysBtn_Click(object sender, EventArgs e)
        {
            if (!loaded)
            {
                os.loadFileData();
                loaded = true;
            }
            os.startOS();
        }

        private void stopSysBtn_Click(object sender, EventArgs e)
        {
            os.stopOS();
        }

        private void conversionRateField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OS.clockUnit = int.Parse(conversionRateField.Text);
            }
            catch
            {
                conversionRateField.Text = 1000.ToString();
                OS.clockUnit = int.Parse(conversionRateField.Text);
            }

        }



        // public functions, called from other classes

        public void setProcessLabels()
        {
            if (os.CPU1.CurrentProcess !=null)
            {
            cpu1ProcNameLbl.Text = os.CPU1.CurrentProcess.Name;
            cpu1ProcTimeLbl.Text = os.CPU1.CurrentProcess.TimeRemaining.ToString();

            } else
            {
                cpu1ProcNameLbl.Text = "idle";
                cpu1ProcTimeLbl.Text = "n/a";
            }
            if (os.CPU2.CurrentProcess != null)
            {
                cpu2ProcNameLbl.Text = os.CPU2.CurrentProcess.Name;
                cpu2ProcTimeLbl.Text = os.CPU2.CurrentProcess.TimeRemaining.ToString();

            }
            else
            {
                cpu2ProcNameLbl.Text = "idle";
                cpu2ProcTimeLbl.Text = "n/a";
            }
        }
        public void setQueueTable()
        {
            QueueBox.DataSource = os.DisplayQueue;
        }
        public void setTotalTimeLbl()
        {
            totalTimeLab.Text = os.TotalElapsedTime.ToString();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            loaded = false;
            os.resetOS();
        }
    }
}

