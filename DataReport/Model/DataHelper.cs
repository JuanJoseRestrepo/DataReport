using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataReport.Model
{
    class DataHelper
    {
        private DataTable table;

        public DataTable Table
        {
            get => table;
        }



        public void CreateTable(string filePath)
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
                    string[] dataLine = lines[i].Split(',');

                    DataRow row = table.NewRow();

                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        try
                        {
                            row[j] = dataLine[j];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("An error occurred while reading the data");
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
                    string[] dataLine = lines[i].Split(',');

                  //  if (dataLine[4])
                    
                    //{

                    //}

                    DataRow row = table.NewRow();

                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        try
                        {
                            row[j] = dataLine[j];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("An error occurred while reading the data");
                        }
                    }

                    table.Rows.Add(row);
                }

            }

        }

    }
}
