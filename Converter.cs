﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    for(int matrix  = 0; matrix < stXML.Items[item].DataMatrixes.Count; matrix++) 
                    {
                        var NewStF = new NewStandartFields();
                        NewStF.DataMatrix = stXML.Items[item].DataMatrixes[matrix].DataMatrixGS1.Replace("&#232;", "\u001d");
                        NewStF.DataMatrixCode = stXML.Items[item].DataMatrixes[matrix].DataMatrixCode;
                        NewStF.Barcode = stXML.Items[item].Barcode;
                        NewStF.ProducedDate = "";
                        NewStF.Gtin = stXML.Items[item].Gtin;
                        
                        //Что является артикулом, а что артикулом поставщика?
                        NewStF.Article = "Артикул: "+stXML.Items[item].Number;
                        NewStF.Importer = "Импортер: "+stXML.Importer;
                        //NewStF.Producer = "Артикул поставщика: " + stXML.
                        NewStF.Brand = "Бренд: "+stXML.Items[item].Brand;
                        NewStF.Cert_sign = stXML.Items[item].Cert_sign;
                        NewStF.DescriptiveCharacteristic1 = stXML.Items[item].RUSname;
                        NewStF.DescriptiveCharacteristic2 = "Р-р: " + stXML.Items[item].Size;
                        NewStF.DescriptiveCharacteristic3 = "Цвет: " + stXML.Items[item].Color;
                        NewStF.DescriptiveCharacteristic4 = "Артикул пост.: "+ stXML.Items[item].Producer_number;
                        NewStF.DescriptiveCharacteristic5 = "";
                        NewStyleFileFields.Add(NewStF);
                    }
                }
            }
        }

    }
}
