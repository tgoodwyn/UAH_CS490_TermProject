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
        static string homeDir = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
        string startFilePath = Path.Combine(homeDir, "TestData.csv");
        string currentlySelectedFilePath;

        List<ProcessFromFile> proccessesFromFile = new List<ProcessFromFile>();
        public ThreadSwitcher()
        {
            currentlySelectedFilePath = startFilePath;


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filedata = proccessesFromFile;
            dataGridView1.DataSource = filedata;
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
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void readFileBtn_click(object sender, EventArgs e)
        {
            readCSV();
        }

        private void appendDataBtn_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("example.txt"))
            {

                tw.Write(",");

                tw.WriteLine();

            }
        }

        private void readCSV()
        {
            string path = currentlySelectedFilePath;

            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] data = new string[4];
                string[] columns = line.Split(',');

                for (int i = 0; i < 4; i++)
                {
                    data[i] = columns[i].Trim(' ');
                    Console.WriteLine(data[i]);
                }

                proccessesFromFile.Add(new ProcessFromFile
                {
                    arrivalTime = int.Parse(data[0]),
                    procName = data[1],
                    serviceTime = int.Parse(data[2]),
                    priority = int.Parse(data[3])
                });
            }
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