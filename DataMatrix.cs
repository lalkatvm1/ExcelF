using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelF
{
    internal class DataMatrix
    {
        private string dataMatrixCode;
        private string dataMatrixGS1;

        public string DataMatrixCode { get => dataMatrixCode; }
        public string DataMatrixGS1 { get => dataMatrixGS1; }

        public DataMatrix(string dataMatrixCode, string dataMatrixGS1) 
        {
            this.dataMatrixCode = dataMatrixCode;
            this.dataMatrixGS1 = dataMatrixGS1;
        }
    }
}
