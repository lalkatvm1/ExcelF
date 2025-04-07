using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelF
{
    internal class StXML
    {
        private string importer;
        private string order_number;
        private string order_date;
        private List<StItem> items;

        public string Importer { get => importer;}
        public string Order_number { get => order_number;}
        public string Order_date { get => order_date; }
        internal List<StItem> Items { get => items; }

        public void SetImporter(string imporrter) 
        {
            this.importer = imporrter;
        }
        public void SetrderOrderNumber(string order_number)
        {
            this.order_number = order_number;
        }

        public void SetOrder_date(string order_date)
        {
            this.order_date = order_date;
        }

        public void SetItems(List<StItem> items)
        {
            this.items = items;
        }

        public void AddItem(StItem item) 
        {
            items.Add(item);
        }

        public StXML() 
        {
            items = new List<StItem>();
        }


    }
}
