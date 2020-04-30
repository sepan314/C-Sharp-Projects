using System;

using System.Data;
using System.Collections.Generic;
using ExcelDataReader;
using System.IO;

namespace ExcelConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/Users/sp/Desktop/C-Sharp-Projects/ExcelConsoleApp/sampledata.xlsx";
            //string excelConn = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'", filePath);
            DataSet data = new DataSet();



            //using (OleDbConnection excelOledbConn = new OleDbConnection(excelConn))
            //{
            //    using (OleDbCommand excelDbCommand = new OleDbCommand())
            //    {
            //        using (OleDbDataAdapter excelDataAdapter = new OleDbDataAdapter())
            //        {
            //            excelDbCommand.Connection = excelOledbConn;

            //            //Read Data from First Sheet.
            //            excelOledbConn.Open();
            //            excelDbCommand.CommandText = "SELECT Date, Open, Close From ['Sheet1']";
            //            excelDataAdapter.SelectCommand = excelDbCommand;
            //            //Fill datatable from adapter
            //            excelDataAdapter.Fill(dt);
            //            excelOledbConn.Close();
            //        }
            //    }
            //}
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    data = reader.AsDataSet();
                }
            }

            DataTable dt = data.Tables[0];
            using (var context = new StockContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    context.Stock.Add(new Stock
                    {
                        Date = Convert.ToDateTime(dt.Rows[i][0]),
                        Open = Convert.ToDouble(dt.Rows[i][1]),
                        Close = Convert.ToDouble(dt.Rows[i][2]),

                    }
                    );
                }
                context.SaveChanges();

            }

            Console.WriteLine("Program Completed");
            Console.ReadLine();

        }



    }


}
