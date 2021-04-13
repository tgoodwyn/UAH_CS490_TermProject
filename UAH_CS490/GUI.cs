using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using UAH_CS490.Utils;

namespace UAH_CS490
{
    public partial class GUI : Form
    {

        // static members related to selecting files
        public static readonly string homeDir = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName; //path to solution directory, also has our default data file
        public static readonly string defaultFilePath = Path.Combine(homeDir, "TestData.csv"); // full path to default data file


        // variable for keeping tracking of file that user has selected
        public static string currentlySelectedFilePath; // this will hold the path to whatever data file the user selects

        // the OS object, which grants the GUI access to all simulation functionality
        private OS os;
        // the start button can be hit any time to resume, but only the first time its clicked, or the first time
        // affter hitting reset should data from the file actually be loaded 
        // this variable tracks whether its been loaded yet or not
        private bool loaded = false;

        public GUI()
        {
            currentlySelectedFilePath = defaultFilePath;
            InitializeComponent();
        }

        // several things happen when the GUI first loads
        // first, a new OS object is created.  This object stores the bulk of the functionality 
        // for the simulation
        // Next - the two GUI elements that are DataGridView's need to be formatted to store 
        // their appropriate data
        // One is the Wait Queue, and the other is the Results table
        // The column headers are hard coded as strings
        // The actual data, however, comes from binding the datasource of each DGV to a data structure
        // in the os object
        // After those tables are formatted, next the currently selected file is turned into a DataTable object
        // stored in the FileHandler class.  This object is also bound to a DGV, which is the one for editing 
        // file data
        // Last the clockUnit variable is set based on the value in the corresponding field on the GUI
        private void GUI_Load(object sender, EventArgs e)
        {
            os = new OS(this);
            totalTimeLab.Text = os.TotalElapsedTime.ToString();
            formatResultsTables();
            formatWaitQueueTable();
            FileHandler.createDT(currentlySelectedFilePath);
            FileBox.DataSource = FileHandler.dataFromFile;


            currentPathLabel.Text = currentlySelectedFilePath;
            OS.clockUnit = int.Parse(conversionRateField.Text);

        }

        //making a table for data results from finished executions
        private void formatResultsTables()
        {

            // hard coding column headers
            cpu1ResultsBox.AutoGenerateColumns = false;
            cpu1ResultsBox.Columns.Clear();
            cpu1ResultsBox.ColumnCount = 6;
            cpu1ResultsBox.Columns[0].Name = "Name";
            cpu1ResultsBox.Columns[0].DataPropertyName = "Name";
            cpu1ResultsBox.Columns[1].Name = "Arrival Time";
            cpu1ResultsBox.Columns[1].DataPropertyName = "ArrivalTime";
            cpu1ResultsBox.Columns[2].Name = "Service Time";
            cpu1ResultsBox.Columns[2].DataPropertyName = "ServiceTime";
            cpu1ResultsBox.Columns[3].Name = "Finish Time";
            cpu1ResultsBox.Columns[3].DataPropertyName = "FinishTime";
            cpu1ResultsBox.Columns[4].Name = "Turnaround Time";
            cpu1ResultsBox.Columns[4].DataPropertyName = "TurnaroundTime";
            cpu1ResultsBox.Columns[5].Name = "Normalized TAT";
            cpu1ResultsBox.Columns[5].DataPropertyName = "NormalizedTAT";
            cpu1ResultsBox.Columns[5].DefaultCellStyle.Format = "N2";

            // binding the datasource of the DGV to the os list of finishedProcs
            cpu1ResultsBox.DataSource = os.CPU1.FinishedProcs;

            // hard coding column headers
            cpu2ResultsBox.AutoGenerateColumns = false;
            cpu2ResultsBox.Columns.Clear();
            cpu2ResultsBox.ColumnCount = 6;
            cpu2ResultsBox.Columns[0].Name = "Name";
            cpu2ResultsBox.Columns[0].DataPropertyName = "Name";
            cpu2ResultsBox.Columns[1].Name = "Arrival Time";
            cpu2ResultsBox.Columns[1].DataPropertyName = "ArrivalTime";
            cpu2ResultsBox.Columns[2].Name = "Service Time";
            cpu2ResultsBox.Columns[2].DataPropertyName = "ServiceTime";
            cpu2ResultsBox.Columns[3].Name = "Finish Time";
            cpu2ResultsBox.Columns[3].DataPropertyName = "FinishTime";
            cpu2ResultsBox.Columns[4].Name = "Turnaround Time";
            cpu2ResultsBox.Columns[4].DataPropertyName = "TurnaroundTime";
            cpu2ResultsBox.Columns[5].Name = "Normalized TAT";
            cpu2ResultsBox.Columns[5].DataPropertyName = "NormalizedTAT";
            cpu2ResultsBox.Columns[5].DefaultCellStyle.Format = "N2";

            // binding the datasource of the DGV to the os list of finishedProcs
            cpu2ResultsBox.DataSource = os.CPU2.FinishedProcs;
        }

        //making a table for the waiting queue
        private void formatWaitQueueTable()
        {
            // hard coding column headers
            cpu1QueueBox.AutoGenerateColumns = false;
            cpu1QueueBox.Columns.Clear();
            cpu1QueueBox.ColumnCount = 2;
            cpu1QueueBox.Columns[0].Name = "Process Name";
            cpu1QueueBox.Columns[0].DataPropertyName = "Name";
            cpu1QueueBox.Columns[1].Name = "Service Time";
            cpu1QueueBox.Columns[1].DataPropertyName = "ServiceTime";

            // binding the datasource of the DGV to the OS queue for waiting processes
            // the OS has an intermediary BindingList called DisplayQueue so that the binding can occur
            // as C# queues cannot be bound to DGV's
            cpu1QueueBox.DataSource = os.CPU1.DisplayQueue;

            // hard coding column headers
            cpu2QueueBox.AutoGenerateColumns = false;
            cpu2QueueBox.Columns.Clear();
            cpu2QueueBox.ColumnCount = 2;
            cpu2QueueBox.Columns[0].Name = "Process Name";
            cpu2QueueBox.Columns[0].DataPropertyName = "Name";
            cpu2QueueBox.Columns[1].Name = "Service Time";
            cpu2QueueBox.Columns[1].DataPropertyName = "ServiceTime";

            cpu2QueueBox.DataSource = os.CPU2.DisplayQueue;
        }

        //button for selecting a file to read from
        private void fileSelectBtn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = homeDir;
                // only csv's are allowed
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // if a valid file is selected, then the method in FileHandler
                // is called for creating a datatable and that DT is assigned to
                // be the source of the FileBox DGV
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

        //save button which writes to the selected file when clicked
        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            FileHandler.exportDTableToCSV();
        }

        //start button which starts or resumes the simulation when clicked
        private void startSysBtn_Click(object sender, EventArgs e)
        {
            if (!loaded)
            {
                // only load the data file after hitting the reset button, which resets the loaded variable
                // and the first time you click start
                os.loadFileData();
                loaded = true;
            }
            os.startOS();
        }

        //stop button which stops the simulation
        private void stopSysBtn_Click(object sender, EventArgs e)
        {
            os.stopOS();
        }


        // whenever conversionRateField gets changed, the corresponding property in the OS class needs to 
        // get set
        private void conversionRateField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // must be an integer
                OS.clockUnit = int.Parse(conversionRateField.Text);
            }
            catch
            {
                // if a non-integer is entered, set it to default value of 1000
                conversionRateField.Text = 1000.ToString();
                OS.clockUnit = int.Parse(conversionRateField.Text);
            }

        }


        //=================================================//
        // public functions, called from other classes
        //=================================================//


        // this is called during each GUI update, it updates the labels on the GUI to match
        // the current state of each CPU and their executing processes
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

        // This allows the data source for the Queue DGV to be updated every time the 
        // corresponding data structure changes
        public void setQueueTables()
        {
            cpu1QueueBox.DataSource = os.CPU1.DisplayQueue;
            cpu2QueueBox.DataSource = os.CPU2.DisplayQueue;
        }
        // called during each GUI update
        public void setTotalTimeLbl()
        {
            totalTimeLab.Text = os.TotalElapsedTime.ToString();
        }

        //reset button which resets the simulation back to the beginning
        private void resetBtn_Click(object sender, EventArgs e)
        {
            loaded = false;
            os.resetOS();
        }
    }
}

