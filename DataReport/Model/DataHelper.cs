using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace DataReport.Model
{
    class DataHelper
    {  
      private DataTable table;

        public DataTable Table
        {
            get => table;
        }

        public void refresh()
        {
            table.Clear();
        }

        public void organizateInformation(string filePath,string region)
        {

            string[] lines = System.IO.File.ReadAllLines(filePath);
 
            if (lines.Length > 1)
            {

                for (int i = 1; i < lines.Length; i++)
                {

                    //This will ignore commas between double quotes in the CSV file
                    string[] dataLine = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (dataLine.Length > 0)
                    {
                        if (dataLine[0].Equals(region))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < dataLine.Length; j++)
                            {
                                try
                                {
                                    row[j] = dataLine[j];
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("WARNING: The CSV is poorly formatted!");
                                }
                            }

                            table.Rows.Add(row);
                        }
                    }


                }

            }


        }

        public void CreateTable(string filePath)
        {

            table = new DataTable();

            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string firstLine = lines[0];

                //This will ignore commas between double quotes in the CSV file
                string[] labels = Regex.Split(firstLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                foreach (string header in labels)
                {
                    table.Columns.Add(new DataColumn(header));
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    
                    //This will ignore commas between double quotes in the CSV file
                    string[] dataLine = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    DataRow row = table.NewRow();
                    
                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        try
                        {

                            row[j] = dataLine[j];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("WARNING: The CSV is poorly formatted!");
                        }
                    }

                    table.Rows.Add(row);
                }

            }

        }

        public void FilterTable(string filePath)
        {

            table = new DataTable();

            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string firstLine = lines[0];

                string[] labels = firstLine.Split(',');

                foreach (string header in labels)
                {
                    table.Columns.Add(new DataColumn(header));
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    //This will ignore commas between double quotes in the CSV file
                    string[] dataLine = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    DataRow row = table.NewRow();

                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        try
                        {
                            row[j] = dataLine[j];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("WARNING: The CSV is poorly formatted!");
                        }
                    }

                    table.Rows.Add(row);
                }

            }

        }

    }
}
