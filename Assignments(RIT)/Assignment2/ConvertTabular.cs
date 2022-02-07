using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigns
{
    class ConvertTabular
    {
        static void Main(string[] args)
        {
            CsvToDataTable asv = new CsvToDataTable();
            DataTable dt = asv.ConvertCsvToDataTable(@"C:\Users\Sathisha K\source\repos\Assigns\Assigns\EmpData1.csv");
            asv.ShowData(dt);
        }

        class CsvToDataTable
        {
            public DataTable ConvertCsvToDataTable(string File)
            {
                
                string[] rows = System.IO.File.ReadAllLines(File);

                DataTable dt = new DataTable();
                string[] rowValues = null;
                DataRow dr = dt.NewRow();

                
                if (rows.Length > 0)
                {
                    foreach (string columnName in rows[0].Split(','))
                        dt.Columns.Add(columnName);
                }

                
                for (int row = 1; row < rows.Length; row++)
                {
                    rowValues = rows[row].Split(',');
                    dr = dt.NewRow();
                    dr.ItemArray = rowValues;
                    dt.Rows.Add(dr);
                }

                return dt;
            }

            public void ShowData(DataTable dt)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(dc.ColumnName + " ");
                    }
                    Console.WriteLine("\n___________________");

                    foreach (DataRow draw in dt.Rows)
                    {
                        foreach (var item in draw.ItemArray)
                        {
                            Console.Write(item.ToString() + "      ");
                        }
                        Console.Write("\n");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}

