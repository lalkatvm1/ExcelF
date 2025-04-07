using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExcelF
{
    internal class StItem
    {
        private string rUSname;
        private string barcode;
        private string gtin;
        private string brand;
        private string number;
        private string producer_number;
        private string size;
        private string color;
        private string cert_sign;
        private List<DataMatrix> dataMatrixes;

        public string RUSname { get => rUSname; set => rUSname = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Gtin { get => gtin; set => gtin = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Number { get => number; set => number = value; }
        public string Producer_number { get => producer_number; set => producer_number = value; }
        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Cert_sign { get => cert_sign; set => cert_sign = value; }
        internal List<DataMatrix> DataMatrixes { get => dataMatrixes; set => dataMatrixes = value; }

        public void AddMatrix(DataMatrix matrix) 
        {
            dataMatrixes.Add(matrix);
        }

        public StItem(string RUSname, string barcode, string gtin, string brand, string number, string producer_number, string size, string color, string cert_sign, List<DataMatrix> dataMatrixes )
        {
            this.RUSname = RUSname;
            this.barcode = barcode;
            this.gtin = gtin;
            this.brand = brand;
            this.number = number;
            this.producer_number = producer_number;
            this.size = size;
            this.color = color;
            this.cert_sign = cert_sign;
            this.dataMatrixes = dataMatrixes;
        }

        public StItem(string RUSname, string barcode, string gtin, string brand, string number, string producer_number, string size, string color, string cert_sign)
        {
            this.RUSname = RUSname;
            this.barcode = barcode;
            this.gtin = gtin;
            this.brand = brand;
            this.number = number;
            this.producer_number = producer_number;
            this.size = size;
            this.color = color;
            this.cert_sign = cert_sign;
            this.dataMatrixes = new List<DataMatrix>();
        }
    }
}
