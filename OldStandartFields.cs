using Microsoft.Office.Interop.Excel;
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



        public string Producer { get => producer; }
        public string Importer { get => importer; }
        public string Date { get => date; }
        public string Gender { get => gender; }
        public string Consistance { get => consistance; }
        public string LineMaterial { get => lineMaterial; }
        public string BottomMaterial { get => bottomMaterial; }
        public string TobMaterial { get => tobMaterial; }
        public string CountryCode { get => countryCode; }
        public string TnwedCode { get => tnwedCode; }
        public string DataMatrix { get => dataMatrix; }
        public string DataMatrixCode { get => dataMatrixCode; }
        public string SerialNumber { get => serialNumber; }
        public string Gtin { get => gtin; }
        public string Cert_sign { get => cert_sign; }
        public string RU { get => rU;  }
        public string Size { get => size;  }
        public string Color { get => color;  }
        public string Brand { get => brand;  }
        public string Barcode { get => barcode;  }
        public string ProducerNumber { get => producerNumber; }
        public string Number { get => number; }
        public string Item { get => item; }
        public string OrderLine { get => orderLine; }

        public OldStandartFields(string[] labelProperties)
        {
            if (labelProperties != null|| labelProperties.Length < 0)
            {
                if (labelProperties.Length > 0) 
                {
                    labelProperties[0] = orderLine;
                    labelProperties[1] = item;
                    labelProperties[2] = number;
                    labelProperties[3] = producerNumber;
                    labelProperties[4] = barcode;
                    labelProperties[5] = brand;
                    labelProperties[6] = color;
                    labelProperties[7] = size;
                    labelProperties[8] = rU;
                    labelProperties[9] = cert_sign;
                    labelProperties[10] = gtin;
                    labelProperties[11] = serialNumber;
                    labelProperties[12] = dataMatrixCode;
                    labelProperties[13] = dataMatrix;
                    labelProperties[14] = tnwedCode;
                    labelProperties[15] = countryCode;
                    labelProperties[16] = tobMaterial;
                    labelProperties[17] = bottomMaterial;
                    labelProperties[18] = lineMaterial;
                    labelProperties[19] = consistance;
                    labelProperties[20] = gender;
                    labelProperties[21] = date;
                    labelProperties[22] = importer;
                    labelProperties[23] = producer;
                }
            }
        }

        public OldStandartFields(string[] labelProperties, string orderLine, string item, string number, string producerNumber, string barcode, string brand, string color, string size, string rU, string cert_sign, string gtin, string serialNumber, string dataMatrixCode, string dataMatrix, string tnwedCode, string countryCode, string tobMaterial, string bottomMaterial, string lineMaterial, string consistance, string gender, string date, string importer, string producer)
        {
            this.labelProperties = labelProperties;
            this.orderLine = orderLine;
            this.item = item;
            this.number = number;
            this.producerNumber = producerNumber;
            this.barcode = barcode;
            this.brand = brand;
            this.color = color;
            this.size = size;
            this.rU = rU;
            this.cert_sign = cert_sign;
            this.gtin = gtin;
            this.serialNumber = serialNumber;
            this.dataMatrixCode = dataMatrixCode;
            this.dataMatrix = dataMatrix;
            this.tnwedCode = tnwedCode;
            this.countryCode = countryCode;
            this.tobMaterial = tobMaterial;
            this.bottomMaterial = bottomMaterial;
            this.lineMaterial = lineMaterial;
            this.consistance = consistance;
            this.gender = gender;
            this.date = date;
            this.importer = importer;
            this.producer = producer;
        }
    }
}
