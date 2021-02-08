using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AIS_ComputerBYTE
{
    public partial class StatisticksForm : Form
    {
        private string[] _dataToExcel;
        private TableMenager _tableMenager;
        private string[] _months = new string[] 
        {   
            "Январь",
            "Февраль",
            "Март", 
            "Апрель", 
            "Май", 
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        };

        public StatisticksForm()
        {
            InitializeComponent();

            _tableMenager = new TableMenager();
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string request = $"SELECT * FROM Statistics WHERE месяц = '{monthComboBox.SelectedItem}'";
            string[] statistick =  _tableMenager.SelectInDB(request);
            _dataToExcel = statistick;

            ClearChart(monthChart);
            PrintStatistick(statistick, monthChart, monthComboBox.SelectedItem.ToString());
        }

        private void PrintStatistick(string[] statistick, Chart chart, string month)
        {
            for (int i = 3, j = 0; i < statistick.Length; i++, j++)
            {
                chart.Series[j].Points.AddXY(month + "\n" + statistick[2], statistick[i]);
            }
        }

        private void ClearChart(Chart chart)
        {
            foreach (var item in chart.Series)
            {
                item.Points.Clear();
            }
        }

        private void firstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Name == "firstRadioButton")
            {
                PrintHalfYear(0, 6);
            }
            else
            {
                PrintHalfYear(6, 12);
            }
        }

        private void PrintHalfYear(int startMonthNumb, int stopMonthNumber)
        {
            ClearChart(fullChart);

            for (int i = startMonthNumb; i < stopMonthNumber; i++)
            {
                string request = $"SELECT * FROM Statistics WHERE месяц = '{_months[i]}'";
                string[] statistick = _tableMenager.SelectInDB(request);
                _dataToExcel = statistick;


                PrintStatistick(statistick, fullChart, _months[i]);
            }
        }

        private void outputToExcelButton_Click(object sender, EventArgs e)
        {
            if(_dataToExcel != null) 
            { 
                new OutputToExcel().PrintStatistick(_dataToExcel, monthComboBox.SelectedItem.ToString());
                
                _dataToExcel = null;
            }
            else
            {
                MessageBox.Show("Данные не выбраны!", "Внимание!");
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 2)
            {
                ClearChart(yearStatsChart);

                string request = $"SELECT * FROM Statistics WHERE месяц = '{_months[0]}'";
                string[] statistick = _tableMenager.SelectInDB(request);

                for (int i = 1; i < 12; i++)
                {
                    request = $"SELECT * FROM Statistics WHERE месяц = '{_months[i]}'";
                    ColculateSummStats(statistick, _tableMenager.SelectInDB(request));
                }

                PrintStatistick(statistick, yearStatsChart, "Сумма за год");

                _dataToExcel = statistick;
            }
        }

        private string[] ColculateSummStats(string[] stats, string[] selectString)
        {
            for (int i = 3; i < stats.Length; i++)
            {
                stats[i] = (Convert.ToInt32(stats[i]) + Convert.ToInt32(selectString[i])).ToString();
            }

            return stats;
        }

        private void outputSummButton_Click(object sender, EventArgs e)
        {
            if (_dataToExcel != null)
            {
                new OutputToExcel().PrintStatistick(_dataToExcel, "Полный год");

                _dataToExcel = null;
            }
            else
            {
                MessageBox.Show("Данные не выбраны!", "Внимание!");
            }
        }
    }
}