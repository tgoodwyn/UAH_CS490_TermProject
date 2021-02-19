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
        public static DataTable theData = new DataTable();
        public static void createDT(string filePath)
        {
            theData = new DataTable();

            theData.Columns.Add("Arrival time");
            theData.Columns.Add("Name");
            theData.Columns.Add("Service time");
            theData.Columns.Add("Priority");

            // Adding the rows
            File.ReadLines(filePath)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => theData.Rows.Add(line));

            
            return;

        }

        public static void exportDTableToCSV()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in theData.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

            string exportFP = Path.Combine(GUI.homeDir, GUI.currentlySelectedFilePath);

            File.WriteAllText(exportFP, sb.ToString());
        }



    }
}
