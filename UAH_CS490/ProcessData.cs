using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{
    class ProcessData
    {
        public static DataTable dataFromFile = new DataTable();
        public static void createDT(string filePath)
        {
            dataFromFile = new DataTable();

            dataFromFile.Columns.Add("Arrival time");
            dataFromFile.Columns.Add("Name");
            dataFromFile.Columns.Add("Service time");
            dataFromFile.Columns.Add("Priority");

            // Adding the rows
            File.ReadLines(filePath)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => dataFromFile.Rows.Add(line));

            
            return;

        }

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
