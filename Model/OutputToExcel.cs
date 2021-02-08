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

        private Workbook CreateAndGetWorkSheet(out Microsoft.Office.Interop.Excel.Application xlApp)
        {
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWB;
            Workbook xlWB2;
            Worksheet xlSht;

            xlWB = xlApp.Workbooks.Open($@"{System.Windows.Forms.Application.StartupPath}/ШаблонСтатистики.xlsx");
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
