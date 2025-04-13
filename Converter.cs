namespace ExcelF
{
    internal class Converter
    {
        public List<OldStandartFields> OldStyleFileFields { get; }
        public List<NewStandartFields> NewStyleFileFields { get; }
        public StXML stXML { get; }

        public Converter(StXML XML)
        {
            if (XML != null)
            {
                stXML = XML;
            }
            NewStyleFileFields = new List<NewStandartFields>();
            OldStyleFileFields = new List<OldStandartFields>();
        }

        public void ConvertToNewCSVFormat() 
        {
            if (stXML != null) 
            {
                for (int item = 0; item < stXML.Items.Count; item++) 
                {
                    if (stXML.Items[item].DataMatrixes.Count > 0)
                    {
                        for (int matrix = 0; matrix < stXML.Items[item].DataMatrixes.Count; matrix++)
                        {
                            var NewStF = new NewStandartFields();
                            NewStF.DataMatrix = stXML.Items[item].DataMatrixes[matrix].DataMatrixGS1/*.Replace("&#232;", "\u001d")*/;
                            NewStF.DataMatrixCode = stXML.Items[item].DataMatrixes[matrix].DataMatrixCode;
                            NewStF.Barcode = stXML.Items[item].Barcode;
                            NewStF.ProducedDate = "";
                            NewStF.Gtin = stXML.Items[item].Gtin;

                            //Что является артикулом, а что артикулом поставщика?
                            NewStF.Article = stXML.Items[item].Number;
                            NewStF.Importer = stXML.Importer;
                            //NewStF.Producer = "Артикул поставщика: " + stXML.
                            NewStF.Brand = stXML.Items[item].Brand;
                            NewStF.Cert_sign = stXML.Items[item].Cert_sign;
                            NewStF.DescriptiveCharacteristic1 = stXML.Items[item].RUSname;
                            NewStF.DescriptiveCharacteristic2 = "Р-р: " + stXML.Items[item].Size;
                            NewStF.DescriptiveCharacteristic3 = "Цвет: " + stXML.Items[item].Color;
                            NewStF.DescriptiveCharacteristic4 = "Артикул пост.: " + stXML.Items[item].Producer_number;
                            NewStF.DescriptiveCharacteristic5 = "OrderNumber: " + stXML.Order_number + "\tOrderDate: " + stXML.Order_date;
                            NewStyleFileFields.Add(NewStF);
                        }
                    }
                    else
                    {
                        for (int matrix = 0; matrix < stXML.Items[item].DataMatrixes.Count; matrix++)
                        {
                            var NewStF = new NewStandartFields();
                            NewStF.Barcode = stXML.Items[item].Barcode;
                            NewStF.ProducedDate = "";
                            NewStF.Gtin = stXML.Items[item].Gtin;

                            //Что является артикулом, а что артикулом поставщика?
                            NewStF.Article = stXML.Items[item].Number;
                            NewStF.Importer = stXML.Importer;
                            //NewStF.Producer = "Артикул поставщика: " + stXML.
                            NewStF.Brand = stXML.Items[item].Brand;
                            NewStF.Cert_sign = stXML.Items[item].Cert_sign;
                            NewStF.DescriptiveCharacteristic1 = stXML.Items[item].RUSname;
                            NewStF.DescriptiveCharacteristic2 = "Р-р: " + stXML.Items[item].Size;
                            NewStF.DescriptiveCharacteristic3 = "Цвет: " + stXML.Items[item].Color;
                            NewStF.DescriptiveCharacteristic4 = "Артикул пост.: " + stXML.Items[item].Producer_number;
                            NewStF.DescriptiveCharacteristic5 = "OrderNumber: " + stXML.Order_number + "\tOrderDate: " + stXML.Order_date;
                            NewStyleFileFields.Add(NewStF);
                        }
                    }
                }
            }
        }

    }
}
