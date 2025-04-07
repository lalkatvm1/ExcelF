using Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;
using System.Text.RegularExpressions;

namespace ExcelF
{
    public partial class Form1 : Form
    {
        //public FileData fd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusLabel.ForeColor = Color.YellowGreen;
            StatusLabel.Text = "Converting";
            if (FileData.IsXML == true) 
            {
                LogicHandler.ReadXml();
                FileData.Converter.ConvertToNewCSVFormat();
            }
            LogicHandler.readExcel();
            StatusLabel.ForeColor = Color.Green;
            StatusLabel.Text = "Ready for saving";

        }

        /*private void readExcel(string Path)
        {
            string filePath = "C:\\Users\\lesko\\Desktop\\Лист Microsoft Excel (2).xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Range cell = ws.Cells[3, 2];
            string cellValue = cell.Value;


            MessageBox.Show(cellValue);

        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            //openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt,*.csv,*tsv)|*.txt;*.csv;*tsv|Excel File (*.xlsx,*.xls)|*.xlsx;*.xls|XML(*.xml)|*.xml";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                textBox1.Text = openFileDialog1.FileName;
                StatusLabel.ForeColor = Color.SandyBrown;
                Regex rg = new Regex(@"(?<=\\)[^\\]*$");
                MatchCollection matches = rg.Matches(openFileDialog1.FileName);
                if (matches.Count == 1)
                {
                    StatusLabel.Text = $"working with \"{matches[0].Value}\"";
                    FileData.SetFileName(matches[0].Value);
                }
                else
                {
                    StatusLabel.Text = "File has been chosen";
                }

                FileData.SetPath(openFileDialog1.FileName);
            }
            else
            { textBox1.Text = "You didn't select the file!"; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveToButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderBrowserDialog = new FolderBrowserDialog();
            openFolderBrowserDialog.Description = "Select folder for saving";
            //openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFolderBrowserDialog.ShowDialog();
            if (openFolderBrowserDialog.SelectedPath != "")
            {
                SaveToTB.Text = openFolderBrowserDialog.SelectedPath;
                StatusLabel.ForeColor = Color.Green;
                FileData.SetSavingPath(openFolderBrowserDialog.SelectedPath);
            }
            else
            { SaveToTB.Text = "You didn't select the file!"; }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StatusLabel.ForeColor = Color.YellowGreen;
            StatusLabel.Text = "Saving file";
            LogicHandler.SaveFile(LogicHandler.DataPreparation(FileData.IsXML));
            StatusLabel.ForeColor = Color.Green;
            StatusLabel.Text = $"File is saved to {FileData.NewFilePath}";
        }
    }
}
