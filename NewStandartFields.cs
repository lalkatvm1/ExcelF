﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelF
{
    internal class NewStandartFields
    {
        private string[] labelProperties;

        private string dataMatrixCode;
        private string dataMatrix;
        private string barcode;
        private string producedDate;
        private string gtin;
        private string article;
        private string importer;
        private string producer;
        private string brand;
        private string cert_sign;
        private string descriptiveCharacteristic1;
        private string descriptiveCharacteristic2;
        private string descriptiveCharacteristic3;            
        private string descriptiveCharacteristic4;
        private string descriptiveCharacteristic5;

        public string DescriptiveCharacteristic5 { get => descriptiveCharacteristic5; set => descriptiveCharacteristic5 = value; }
        public string DescriptiveCharacteristic4 { get => descriptiveCharacteristic4; set => descriptiveCharacteristic4 = value; }
        public string DescriptiveCharacteristic3 { get => descriptiveCharacteristic3; set => descriptiveCharacteristic3 = value; }
        public string DescriptiveCharacteristic2 { get => descriptiveCharacteristic2; set => descriptiveCharacteristic2 = value; }
        public string DescriptiveCharacteristic1 { get => descriptiveCharacteristic1; set => descriptiveCharacteristic1 = value; }
        public string Cert_sign { get => cert_sign; set => cert_sign = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Producer { get => producer; set => producer = value; }
        public string Importer { get => importer; set => importer = value; }
        public string Article { get => article; set => article = value; }
        public string Gtin { get => gtin; set => gtin = value; }
        public string ProducedDate { get => producedDate; set => producedDate = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string DataMatrix { get => dataMatrix; set => dataMatrix = value; }
        public string DataMatrixCode { get => dataMatrixCode; set => dataMatrixCode = value; }
        public string[] LabelProperties { get => labelProperties; set => labelProperties = value; }
    }
}
