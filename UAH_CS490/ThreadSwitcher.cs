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
        string startFile = Path.Combine(homeDir, "TestData.csv");
        public ThreadSwitcher()
        {
            //var filePath = ".";
            //string parent = Directory.GetParent(filePath).Parent.Parent.FullName;
            //string target = Path.Combine(parent, "TestData.csv");
            bool exists = File.Exists(startFile);
            Console.WriteLine(exists);
            //var files = Directory.GetFiles(parent);
            //foreach (string fileName in files)
            //    Console.WriteLine(fileName);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void babyFarts_Click(object sender, EventArgs e)
        {

        }

        private void appendDataBtn_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("example.txt"))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dataGridView1.Columns.Count - 1)
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
