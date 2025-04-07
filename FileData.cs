using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace ExcelF
{
    internal static class FileData
    {
        public static bool IsXML { get => isXML; }
        public static string OldFilePath { get => oldFilePath; }
        public static string NewFilePath { get => newFilePath; }
        public static List<string[]> FileRows { get => fileRows; }
        public static string FileName { get => fileName; }
        public static string[] FileRow24 { get; }

        



        private static string oldFilePath;
        private static string newFilePath;
        private static string fileName;
        private static bool isXML = false;

        private static string[] fileRow24;
        static List<string[]> fileRows;
        static OldStandartFields[] oldStyleFileFields;
        static NewStandartFields[] newStyleFileFields;

        public static bool IsConverted { get; }
        

        private static bool isConverted = false;

        internal static StXML StXML { get => stXML; }
        private static StXML stXML;

        internal static Converter Converter { get => converter; }
        private static Converter converter;

        public static void ConverterInit(StXML stXML)
        {
            converter = new Converter (stXML);
        }

        public static void SetStXML(StXML XML) 
        {
            stXML = XML;
        }

        public static void SetFileName(string FileName)
        {
            Regex rg = new Regex(@"\.\w+$");
            MatchCollection matches = rg.Matches(FileName);
            string fileType = matches[0].Value;
            fileName = FileName.Replace(fileType, "");
            if (fileType == ".xml") 
            {
                isXML = true;
            }

        }

        public static void SetOldStandartFields(OldStandartFields[] fields)
        {
            if (fields != null && fields.Length == 24)
            {
                oldStyleFileFields = fields;
            }
        }

        public static void SetNewStandartFields(NewStandartFields[] fields)
        {
            if (fields != null && fields.Length == 00)
            {
                newStyleFileFields = fields;
            }
        }


        public static void SetFields(string[] fields)
        {
            if (fields.Length == 24)
            {
                fileRow24 = fields;
            }
            else
            {
                fileRow24 = new string[24];
            }
        }

        public static void AddRow()
        {
            if(fileRows != null)
            fileRows.Add(fileRow24);
            else 
            {
                fileRows = new List<string[]>();
                fileRows.Add(fileRow24);
            }
        }




        public static void SetSavingPath(string filePath)
        {
            if (filePath == null || filePath.Length == 0)
            {
                newFilePath = "";
            }
            else
            {
                newFilePath = filePath;
            }
        }
        public static void SetPath(string filePath)
        {
            if (filePath == null || filePath.Length == 0)
            {
                oldFilePath = "";
            }
            else
            {
                oldFilePath = filePath;
            }
        }


        //public string OldFilePath { get => oldFilePath; }
        //public string NewFilePath { get => newFilePath; }

        //private string oldFilePath;
        //private string newFilePath;


        //public string[] fileRow24;
        //public List<string[]> FileRows { get => fileRows; }

        //private List<string[]> fileRows = new List<string[]>();


        //public string FileName { get => fileName; }      
        //private string fileName;




        ////OldStandartFields[] oldStyleFileFields;
        ////NewStandartFields[] newStyleFileFields;

        //public void SetFileName(string FileName)
        //{
        //    Regex rg = new Regex(@"\.\w+$");
        //    MatchCollection matches = rg.Matches(FileName);
        //    string fileType = matches[0].Value;
        //    fileName = FileName.Replace(fileType, "");
        //    //int ftLength = fileType.Length;
        //    //int[] indexes = new int[ftLength];
        //    //for (int i = 0; i < ftLength; i++)
        //    //{
        //    //    indexes[i] = FileName.IndexOf(fileType[i]);
        //    //}

        //}

        ////public void SetOldStandartFields(OldStandartFields[] fields)
        ////{
        ////    if (fields != null && fields.Length == 24)
        ////    {
        ////        oldStyleFileFields = fields;
        ////    }
        ////}

        ////public void SetNewStandartFields(NewStandartFields[] fields)
        ////{
        ////    if (fields != null && fields.Length == 00)
        ////    {
        ////        newStyleFileFields = fields;
        ////    }
        ////}

        //public void SetFields(string[] fields)
        //{
        //    if (fields.Length == 24)
        //    {
        //        fileRow24 = fields;
        //    }
        //    else
        //    {
        //        fileRow24 = new string[24];
        //    }
        //}

        //public void AddRow()
        //{
        //    fileRows.Add(fileRow24);
        //}


        //public void SetSavingPath(string filePath)
        //{
        //    if (filePath == null || filePath.Length == 0)
        //    {
        //        newFilePath = "";
        //    }
        //    else
        //    {
        //        newFilePath = filePath;
        //    }
        //}
        //public void SetPath(string filePath)
        //{
        //    if (filePath == null || filePath.Length == 0)
        //    {
        //        oldFilePath = "";
        //    }
        //    else
        //    {
        //        oldFilePath = filePath;
        //    }
        //}

    }
}
