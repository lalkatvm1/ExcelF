using System.Text;
//using Range = Microsoft.Office.Interop.Excel.Range;
using System.Xml.Linq;

namespace ExcelF
{

    public static class LogicHandler
    {
        public static Form1 f;

        //считывание данных из excel и запись их в переменную
        //public static async void readExcel()
        //{
        //    if (FileData.OldFilePath != null && FileData.OldFilePath.Length != 0)
        //    {
        //        if (FileData.IsConverted != true)
        //        {
        //            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //            Workbook wb;
        //            Worksheet ws;

        //            wb = excel.Workbooks.Open(FileData.OldFilePath);
        //            ws = wb.Worksheets[1];

        //            Range range;
        //            string[] row = new string[24];
        //            bool running = true;
        //            for (int j = 0; running == true; j++)
        //            {
        //                range = ws.Range[$"A{j + 1}:X{j + 1}"];
        //                int nullCounter = 0;
        //                for (int i = 0; i < range.Cells.Count; i++)
        //                {
        //                    if (i == 23)
        //                    {
        //                        int x = 2 + 2;
        //                    }

        //                    row[i] = Convert.ToString(range.Cells[i + 1].Value);
        //                    if (row[i] == null)
        //                    {
        //                        nullCounter++;
        //                    }
        //                    if (nullCounter == 24)
        //                    {
        //                        running = false;
        //                    }
        //                }
        //                if (running == true)
        //                {
        //                    FileData.SetFields(row);
        //                    FileData.AddRow();
        //                    row = new string[24];
        //                }
        //                else
        //                {
        //                    MessageBox.Show("ОПА");
        //                }
        //            }

        //        }
        //        else
        //        {
        //            MessageBox.Show("Миша, всё хуйня! Давай по новой.");
        //        }
        //    }
        //}

        public static async void ReadXml() 
        {
            
            
            StXML stXML = new StXML();

            XDocument doc = XDocument.Load(FileData.OldFilePath);
            XElement? rootElement = doc.Root;
            int counter = 0;
            if (rootElement != null) 
            {
                // сбор неизменных данных описывающих файл
                XElement? name = rootElement.Element("importer");
                XElement? ordNum = rootElement.Element("order_number");
                XElement? ordDate = rootElement.Element("order_date");
                if (name != null) {
                    stXML.SetImporter(name.Value);
                }
                if (ordNum != null)
                {
                    stXML.SetrderOrderNumber(ordNum.Value);
                }
                if (ordDate != null)
                {
                    stXML.SetOrder_date(ordDate.Value);
                }
                XElement? itemsCollection = rootElement.Element("items");
                foreach (XElement element in itemsCollection.Elements("item")) 
                {
                    string RUSname = element.Element("RUSname").Value;
                    string barcode = element.Element("barcode").Value;
                    string gtin = element.Element("gtin").Value;
                    string brand = element.Element("brand").Value;
                    string number = element.Element("number").Value;
                    string producer_number = element.Element("producer_number").Value;
                    string size = element.Element("size").Value;
                    string color = element.Element("color").Value;
                    string cert_sign = element.Element("cert_sign").Value;

                    var stItem = new StItem(RUSname, barcode, gtin, brand, number, producer_number, size, color, cert_sign);

                    foreach (XElement matrix in element.Elements("DataMatrixes").Elements("DataMatrix")) 
                    {
                        string s1 = matrix.Element("DataMatrixCode").Value;
                        string s2 = matrix.Element("DataMatrixGS1").Value;
                        stItem.AddMatrix(new DataMatrix(s1, s2));
                        counter++;
                        if (counter == 33)
                        {
                            var x = 2 + 2;
                        }
                    }
                    
                    stXML.AddItem(stItem);
                    
                }
            }
            
            FileData.SetStXML(stXML);
            FileData.ConverterInit(stXML);
        }

        
        public static void SaveFile(string strForSaving)
        {

            using (StreamWriter writer = new StreamWriter($"{FileData.NewFilePath}\\{FileData.FileName}.csv", false))
            {
                 writer.Write(strForSaving);
            }
            //FileStream FS = File.Create($"{FileData.NewFilePath}\\{FileData.FileName}.csv");
            //string str = DataPreparation();
            //byte[] buffer = Encoding.Unicode.GetBytes(str);
            //await FS.WriteAsync(buffer, 0, buffer.Length);
            //await FS.FlushAsync();
            //FS.Close();
        }


        //формирование строки для записи в файл
        internal static string DataPreparation(bool IsXML = false) 
        {
            StringBuilder result = new StringBuilder();

            if (IsXML)
            {
                result.Append("Datamatrix\tDataMatrixCode\tBarcode\tProducedDate\tGTIN\tArticle\tProdгcer\tImporter\tBrand\tCertSign\tDescriptiveCharacteristic1\tDescriptiveCharacteristic2\tDescriptiveCharacteristic3\tDescriptiveCharacteristic4\tDescriptiveCharacteristic5\n");
                for (int i = 0; i < FileData.Converter.NewStyleFileFields.Count; i++) 
                {
                    var s = FileData.Converter.NewStyleFileFields[i];
                    result.Append($"{s.DataMatrix}\t{s.DataMatrixCode}\t{s.Barcode}\t{s.ProducedDate}\t{s.Gtin}\t{s.Article}\t{s.Producer}\t{s.Importer}\t{s.Brand}\t{s.Cert_sign}\t{s.DescriptiveCharacteristic1}\t{s.DescriptiveCharacteristic2}\t{s.DescriptiveCharacteristic3}\t{s.DescriptiveCharacteristic4}\t{s.DescriptiveCharacteristic5}\n");
                }
            }
            else
            {
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
            }
            return result.ToString();

        } 
    }
}
