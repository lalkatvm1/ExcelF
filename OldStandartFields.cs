using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelF
{
    internal class OldStandartFields
    {
        private string[] labelProperties;

        private string orderLine;
        private string item;
        private string number;
        private string producerNumber;
        private string barcode;
        private string brand;
        private string color;
        private string size;
        private string rU;
        private string cert_sign;
        private string gtin;
        private string serialNumber;
        private string dataMatrixCode;
        private string dataMatrix;
        private string tnwedCode;
        private string countryCode;
        private string tobMaterial;
        private string bottomMaterial;
        private string lineMaterial;
        private string consistance;
        private string gender;
        private string date;
        private string importer;
        private string producer;



        

        public OldStandartFields(string[] labelProperties)
        {
            if (labelProperties != null|| labelProperties.Length < 0)
            {
                if (labelProperties.Length > 0) 
                {
                    labelProperties[0] = OrderLine;
                    labelProperties[1] = Item;
                    labelProperties[2] = Number;
                    labelProperties[3] = ProducerNumber;
                    labelProperties[4] = Barcode;
                    labelProperties[5] = Brand;
                    labelProperties[6] = Color;
                    labelProperties[7] = Size;
                    labelProperties[8] = RU;
                    labelProperties[9] = Cert_sign;
                    labelProperties[10] = Gtin;
                    labelProperties[11] = SerialNumber;
                    labelProperties[12] = DataMatrixCode;
                    labelProperties[13] = DataMatrix;
                    labelProperties[14] = TnwedCode;
                    labelProperties[15] = CountryCode;
                    labelProperties[16] = TobMaterial;
                    labelProperties[17] = BottomMaterial;
                    labelProperties[18] = LineMaterial;
                    labelProperties[19] = Consistance;
                    labelProperties[20] = Gender;
                    labelProperties[21] = Date;
                    labelProperties[22] = Importer;
                    labelProperties[23] = Producer;
                }
            }
        }

        public OldStandartFields(string[] labelProperties, string orderLine, string item, string number, string producerNumber, string barcode, string brand, string color, string size, string rU, string cert_sign, string gtin, string serialNumber, string dataMatrixCode, string dataMatrix, string tnwedCode, string countryCode, string tobMaterial, string bottomMaterial, string lineMaterial, string consistance, string gender, string date, string importer, string producer)
        {
            this.LabelProperties = labelProperties;
            this.OrderLine = orderLine;
            this.Item = item;
            this.Number = number;
            this.ProducerNumber = producerNumber;
            this.Barcode = barcode;
            this.Brand = brand;
            this.Color = color;
            this.Size = size;
            this.RU = rU;
            this.Cert_sign = cert_sign;
            this.Gtin = gtin;
            this.SerialNumber = serialNumber;
            this.DataMatrixCode = dataMatrixCode;
            this.DataMatrix = dataMatrix;
            this.TnwedCode = tnwedCode;
            this.CountryCode = countryCode;
            this.TobMaterial = tobMaterial;
            this.BottomMaterial = bottomMaterial;
            this.LineMaterial = lineMaterial;
            this.Consistance = consistance;
            this.Gender = gender;
            this.Date = date;
            this.Importer = importer;
            this.Producer = producer;
        }

        public string Producer { get => producer; set => producer = value; }
        
        public string Date { get => date; set => date = value; }
        public string Importer { get => importer; set => importer = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Consistance { get => consistance; set => consistance = value; }
        public string LineMaterial { get => lineMaterial; set => lineMaterial = value; }
        public string BottomMaterial { get => bottomMaterial; set => bottomMaterial = value; }
        public string TobMaterial { get => tobMaterial; set => tobMaterial = value; }
        public string CountryCode { get => countryCode; set => countryCode = value; }
        public string TnwedCode { get => tnwedCode; set => tnwedCode = value; }
        public string DataMatrix { get => dataMatrix; set => dataMatrix = value; }
        public string DataMatrixCode { get => dataMatrixCode; set => dataMatrixCode = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Gtin { get => gtin; set => gtin = value; }
        public string Cert_sign { get => cert_sign; set => cert_sign = value; }
        public string RU { get => rU; set => rU = value; }
        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string ProducerNumber { get => producerNumber; set => producerNumber = value; }
        public string Number { get => number; set => number = value; }
        public string Item { get => item; set => item = value; }
        public string OrderLine { get => orderLine; set => orderLine = value; }
        public string[] LabelProperties { get => labelProperties; set => labelProperties = value; }
    }
}
