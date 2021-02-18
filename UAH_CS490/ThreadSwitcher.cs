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
    public partial class ThreadSwitcher : Form
    {

        static readonly string homeDir = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName; //path to solution directory, also has our default data file
        static readonly string defaultFilePath = Path.Combine(homeDir, "TestData.csv"); // full path to default data file


        // variables
        string currentlySelectedFilePath; // this will hold the path to whatever data file the user selects

        // data structures
        List<ProcessFromFile> proccessesFromFile = new List<ProcessFromFile>(); // we will need a list for holding the process objects read in from the data file
        DataTable theData = new DataTable();

        public ThreadSwitcher()
        {
            currentlySelectedFilePath = defaultFilePath;
            InitializeComponent();
        }

        private void ThreadSwitcher_Load(object sender, EventArgs e)
        {
            currentPathLabel.Text = currentlySelectedFilePath;

        }

        private void loadQueueBtn_Click(object sender, EventArgs e)
        {
            createDT(currentlySelectedFilePath);
            //foreach (DataRow row in filedata.Rows)
            //{
            //    QueueBox.Rows.Add(row);
            //}
        }

        public void createDT(string filePath)
        {
            theData = new DataTable();

            theData.Columns.Add("Arrival time");
            theData.Columns.Add("Service time");
            theData.Columns.Add("Name");
            theData.Columns.Add("Priority");

            // Adding the rows
            File.ReadLines(filePath)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => theData.Rows.Add(line));

            QueueBox.DataSource = theData;
            return;
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
                    currentPathLabel.Text = currentlySelectedFilePath;

                    //MessageBox.Show("Fail", "", MessageBoxButtons.OK);
                }
            }

        }

        private void readFileBtn_click(object sender, EventArgs e)
        {
            readCSV();
        }

        private void appendDataBtn_Click(object sender, EventArgs e)
        {

        }

        private void startSysBtn_Click(object sender, EventArgs e)
        {
            string field = theData.Rows[0].Field<string>(0);
            fileInfo.Text = field;
        }

        private void stopSysBtn_Click(object sender, EventArgs e)
        {

        }


        // helper functions
        private void readCSV()
        {
            // selected by "File Select" button
            string path = currentlySelectedFilePath;

            // put all lines from CSV into lines[]
            string[] lines = System.IO.File.ReadAllLines(path);

            // iterate over lines[]
            // copy data from line -> columns[i] -> temp[i] -> new Process object
            foreach (string line in lines)
            {

                string[] temp = new string[4];
                string[] columns = line.Split(',');

                for (int i = 0; i < 4; i++)
                {
                    temp[i] = columns[i].Trim(' ');
                    Console.WriteLine(temp[i]);
                }

                proccessesFromFile.Add(new ProcessFromFile
                {
                    arrivalTime = int.Parse(temp[0]),
                    procName = temp[1],
                    serviceTime = int.Parse(temp[2]),
                    priority = int.Parse(temp[3])
                });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


//var filePath = ".";
//string parent = Directory.GetParent(filePath).Parent.Parent.FullName;
//string target = Path.Combine(parent, "TestData.csv");
//bool exists = File.Exists(startFilePath);
//Console.WriteLine(exists);
//var files = Directory.GetFiles(parent);
//foreach (string fileName in files)
//    Console.WriteLine(fileName);