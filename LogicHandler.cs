using Microsoft.Office.Interop.Excel;
using System.Text;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace ExcelF
{

    public static class LogicHandler
    {
        public static Form1 f;

        //считывание данных из excel и запись их в переменную
        public static void readExcel()
        {
            if (FileData.OldFilePath != null && FileData.OldFilePath.Length != 0)
            {
                if (FileData.IsConverted != true)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb;
                    Worksheet ws;

                    wb = excel.Workbooks.Open(FileData.OldFilePath);
                    ws = wb.Worksheets[1];

                    Range range;
                    string[] row = new string[24];
                    bool running = true;
                    for (int j = 0; running == true; j++)
                    {
                        range = ws.Range[$"A{j + 1}:X{j + 1}"];
                        int nullCounter = 0;
                        for (int i = 0; i < range.Cells.Count; i++)
                        {
                            if (i == 23)
                            {
                                int x = 2 + 2;
                            }

                            row[i] = Convert.ToString(range.Cells[i + 1].Value);
                            if (row[i] == null)
                            {
                                nullCounter++;
                            }
                            if (nullCounter == 24)
                            {
                                running = false;
                            }
                        }
                        if (running == true)
                        {
                            FileData.SetFields(row);
                            FileData.AddRow();
                            row = new string[24];
                        }
                        else
                        {
                            MessageBox.Show("ОПА");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Миша, всё хуйня! Давай по новой.");
                }
            }
        }

        public static async void SaveFile()
        {
            string str = DataPreparation();
            using (StreamWriter writer = new StreamWriter($"{FileData.NewFilePath}\\{FileData.FileName}.csv", false))
            {
                str = DataPreparation();

                writer.Write(str);
            }
            //FileStream FS = File.Create($"{FileData.NewFilePath}\\{FileData.FileName}.csv");
            //string str = DataPreparation();
            //byte[] buffer = Encoding.Unicode.GetBytes(str);
            //await FS.WriteAsync(buffer, 0, buffer.Length);
            //await FS.FlushAsync();
            //FS.Close();
        }


        //формирование строки для записи в файл
        private static string DataPreparation() 
        {
            StringBuilder result = new StringBuilder();

            //for (int property = 0; property < FileData.FileRow24.Length; property++)
            //    {
            //    result.Append($"{FileData.FileRow24[property]}\t");
            //    if (property == 24)
            //    {
            //        result.Append("\n");
            //    }

            //}

            for (int rows = 0; rows < FileData.FileRows.Count; rows++)
            {
                for (int property = 0; property < FileData.FileRows[rows].Length; property++)
                {
                    result.Append($"{FileData.FileRows[rows][property]}\t");
                    if (property == 23)
                    {
                        result.Append("\n");
                    }
                }
                if (rows == FileData.FileRows.Count - 1) 
                {
                    MessageBox.Show("ОПА");
                }
            }

            return result.ToString();

        } 
    }
}
