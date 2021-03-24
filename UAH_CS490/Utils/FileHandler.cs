using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490.Utils
{
    class FileHandler
    {
        // static variable referenced by OS when loading in the new data
        public static DataTable dataFromFile = new DataTable();

        // This function creates the static variable as a datatble
        // It reads in the file at "filePath" to do so
        public static void createDT(string filePath)
        {
            dataFromFile = new DataTable();

            dataFromFile.Columns.Add("Arrival time");
            dataFromFile.Columns.Add("Name");
            dataFromFile.Columns.Add("Service time");
            dataFromFile.Columns.Add("Priority");

            // Adding the rows to the datatable
            File.ReadLines(filePath)
                // comma separated list becomes a list of datatable elements
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => dataFromFile.Rows.Add(line));
        }


        // this function is only called if the user wants to save the edited DataGridView
        // to disk.  It takes the data table, which is bound to the DGV, and turns it back into
        // text, which is then written to the "currentlySelectedFilePath"
        public static void exportDTableToCSV()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dataFromFile.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

            string exportFP = Path.Combine(GUI.homeDir, GUI.currentlySelectedFilePath);

            File.WriteAllText(exportFP, sb.ToString());
        }
    }
}
