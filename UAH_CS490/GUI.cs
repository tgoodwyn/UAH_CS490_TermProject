using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAH_CS490
{
    public partial class GUI : Form
    {

        public static readonly string homeDir = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName; //path to solution directory, also has our default data file
        public static readonly string defaultFilePath = Path.Combine(homeDir, "TestData.csv"); // full path to default data file


        // variables
        public static string currentlySelectedFilePath; // this will hold the path to whatever data file the user selects

        // data structures
        List<ProcessFromFile> proccessesFromFile = new List<ProcessFromFile>(); // we will need a list for holding the process objects read in from the data file


        public GUI()
        {
            currentlySelectedFilePath = defaultFilePath;
            InitializeComponent();
        }

        private void ThreadSwitcher_Load(object sender, EventArgs e)
        {
            currentPathLabel.Text = currentlySelectedFilePath;
            ProcessData.createDT(currentlySelectedFilePath);
            QueueBox.DataSource = ProcessData.theData;
            CPU.clockUnit = int.Parse(conversionRateField.Text);

        }


        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.InitialDirectory = homeDir;
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    currentlySelectedFilePath = filePath;
                    currentPathLabel.Text = currentlySelectedFilePath;
                    ProcessData.createDT(currentlySelectedFilePath);
                    QueueBox.DataSource = ProcessData.theData;
                }
            }

        }


        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            ProcessData.exportDTableToCSV();
        }

        private void startSysBtn_Click(object sender, EventArgs e)
        {
            string field = ProcessData.theData.Rows[0].Field<string>(0);
            fileInfo.Text = field;
        }

        private void stopSysBtn_Click(object sender, EventArgs e)
        {

        }

        private void conversionRateField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CPU.clockUnit = int.Parse(conversionRateField.Text);
            }
            catch
            {
                conversionRateField.Text = 1000.ToString();
                CPU.clockUnit = int.Parse(conversionRateField.Text);
            }

        }
    }
}

