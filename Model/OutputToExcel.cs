using System;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    class OutputToExcel
    {
        private string _dockName;
        private static int _dockNumber;
        private string _nameExcelPattern;

        public OutputToExcel(string nameExcelPattern)
        {
            _nameExcelPattern = nameExcelPattern;
        }

        public void PrintStatistick(string[] dataPrint, string dockName)
        {
            _dockName = dockName;

            Workbook xlWB = CreateAndGetWorkSheet(out Microsoft.Office.Interop.Excel.Application xlApp);
            Worksheet xlSht = xlWB.ActiveSheet;

            xlSht.Cells[1, "A"] = dockName;
            xlSht.Cells[2, "A"] = "Средняя сумма сделки:";
            xlSht.Cells[2, "B"] = dataPrint[3];
            xlSht.Cells[3, "A"] = "Проданный товар:";
            xlSht.Cells[3, "B"] = dataPrint[4];
            xlSht.Cells[4, "A"] = "Колличество новых покупателей:";
            xlSht.Cells[4, "B"] = dataPrint[5];
            xlSht.Cells[5, "A"] = "Средний уровень доверия:";
            xlSht.Cells[5, "B"] = dataPrint[6];
            xlSht.Cells[6, "A"] = "Сумма плановых сделок:";
            xlSht.Cells[6, "B"] = dataPrint[7];
            xlSht.Cells[7, "A"] = "Полученная прибыль:";
            xlSht.Cells[7, "B"] = dataPrint[8];

            xlWB.Close(true);
            xlApp.Quit();   
        }

        public void PrintCheck(SaleComputersForm saleComputers)
        {
            _dockName = $"Чек! {saleComputers.FIO}";

            Workbook xlWB = CreateAndGetWorkSheet(out Microsoft.Office.Interop.Excel.Application xlApp);
            Worksheet xlSht = xlWB.ActiveSheet;

            xlSht.Cells[2, "B"] = saleComputers.Monufacterer;
            xlSht.Cells[3, "B"] = saleComputers.Motherboard;
            xlSht.Cells[4, "B"] = saleComputers.PowerSupply;
            xlSht.Cells[5, "B"] = saleComputers.VideoCard;
            xlSht.Cells[6, "B"] = saleComputers.CPU;
            xlSht.Cells[7, "B"] = saleComputers.OZU;
            xlSht.Cells[8, "B"] = saleComputers.PZU;
            xlSht.Cells[9, "B"] = saleComputers.Price;
            xlSht.Cells[10, "B"] = saleComputers.Guarante;
            xlSht.Cells[11, "B"] = saleComputers.ToPay;

            xlSht.Cells[2, "E"] = saleComputers.FIO;
            xlSht.Cells[3, "E"] = saleComputers.Pasport;
            xlSht.Cells[4, "E"] = saleComputers.PhoneNumber;
            xlSht.Cells[5, "E"] = saleComputers.Discount;

            xlWB.Close(true);
            xlApp.Quit();
        }

        private Workbook CreateAndGetWorkSheet(out Microsoft.Office.Interop.Excel.Application xlApp)
        {
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWB;
            Workbook xlWB2;
            Worksheet xlSht;

            xlWB = xlApp.Workbooks.Open($@"{System.Windows.Forms.Application.StartupPath}/{_nameExcelPattern}.xlsx");
            xlWB2 = xlApp.Workbooks.Add(System.Reflection.Missing.Value);
            xlSht = xlWB.Worksheets["Лист1"];

            xlSht.Copy(After: xlWB2.Worksheets[xlWB2.Worksheets.Count]);

            FileInfo nakl = new FileInfo($@"{_dockName}.xlsx");
            while (nakl.Exists)
            {
                nakl = new FileInfo($"{_dockName}{_dockNumber++}.xlsx");
            }
            xlWB2.SaveAs($"{Environment.CurrentDirectory}/{nakl.Name}");
            xlWB.Close();

            MessageBox.Show("Данные выведены в Excel!", "Готово!");

            return xlWB2;
        }
    }
}
