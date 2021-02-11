using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AIS_ComputerBYTE
{
    public partial class SalesForecastsForm : Form
    {
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

        ColculateStatistick statistick = new ColculateStatistick();

        public SalesForecastsForm()
        {
            InitializeComponent();

            forecastsChart.Series[0].Points.AddXY("Январь", 100);

        }

        private void firstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Name == "firstRadioButton" || radioButton.Name == "firstRadioButton1")
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
            ClearChart(forecastProfitChart);
            ClearChart(forecastsChart);

            if (tabControl1.SelectedIndex == 0)
            {
                for (int i = startMonthNumb; i < stopMonthNumber; i++)
                {
                    forecastsChart.Series[0].Points.AddXY(_months[i], statistick.ColculateForecastSeling(i));
                }
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                for (int i = startMonthNumb; i < stopMonthNumber; i++)
                {
                    forecastProfitChart.Series[0].Points.AddXY(_months[i], statistick.ColculateForecastProfit(i));
                }
            }
        }

        private void ClearChart(Chart chart)
        {
            foreach (var item in chart.Series)
            {
                item.Points.Clear();
            }
        }
    }
}
