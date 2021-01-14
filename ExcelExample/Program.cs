using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ExcelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //fff();
            WriteExcel();
        }

        static void WriteExcel()
        {
            List<UserDetails> persons = new List<UserDetails>()
            {
                new UserDetails() {ID="1001", Name="ABCD", City ="City1", Country="USA"},
                new UserDetails() {ID="1002", Name="PQRS", City ="City2", Country="INDIA"},
                new UserDetails() {ID="1003", Name="XYZZ", City ="City3", Country="CHINA"},
                new UserDetails() {ID="1004", Name="LMNO", City ="City4", Country="UK"},
           };

            // Lets converts our object data to Datatable for a simplified logic.
            // Datatable is most easy way to deal with complex datatypes for easy reading and formatting.

            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(persons), (typeof(DataTable)));
            var memoryStream = new MemoryStream();

            using (var fs = new FileStream(@"E:\_ПО\_MetrologistAW\Замеры Высочино готовые отчёты 12 декабря\coeffs2.xlsx", FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Sheet1");

                List<String> columns = new List<string>();
                IRow row = excelSheet.CreateRow(0);
                int columnIndex = 0;

                foreach (System.Data.DataColumn column in table.Columns)
                {
                    columns.Add(column.ColumnName);
                    row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                    columnIndex++;
                }

                int rowIndex = 1;
                foreach (DataRow dsrow in table.Rows)
                {
                    row = excelSheet.CreateRow(rowIndex);
                    int cellIndex = 0;
                    foreach (String col in columns)
                    {
                        row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());
                        cellIndex++;
                    }

                    rowIndex++;
                }
                workbook.Write(fs);
            }

        }

        private static void fff()
        {
            string filePath = @"E:\_ПО\_MetrologistAW\Замеры Высочино готовые отчёты 12 декабря\coeffs.xlsx";
            try
            {
                IWorkbook workbook = null;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
                if(filePath.IndexOf(".xlsx") > 0)
                {
                    workbook = new XSSFWorkbook(fs);
                }
                else if (filePath.IndexOf(".xls") > 0)
                {
                    workbook = new HSSFWorkbook(fs);
                }
                ISheet sheet = workbook.GetSheetAt(0);

                if(sheet != null)
                {
                    int rowCount = sheet.LastRowNum;

                    for (int i = 0; i <= sheet.LastRowNum; i++)
                    {
                        IRow curRow = sheet.GetRow(i);
                        //string[] text = new string[10];
                        for (var j = 0; j < 10; ++j)
                            //text[j] = curRow.GetCell(j).StringCellValue.Trim();
                            curRow.GetCell(j).SetCellValue("ggg");
                    }
                }

                //workbook.Write(fs);
                StreamWriter sw = new StreamWriter(@"E:\_ПО\_MetrologistAW\Замеры Высочино готовые отчёты 12 декабря\coeffs2.xlsx");
                //workbook.Write(sw);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class UserDetails
    {
        public string ID ="1001";
        public string Name = "ABCD";
        public string City = "City1";
        public string Country = "USA";
    }
}
