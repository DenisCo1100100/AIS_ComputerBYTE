using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_ComputerBYTE
{
    class ColculateStatistick
    {
        #region MonthArray
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
        #endregion

        private int _wage;
        private int _trustLvl;
        private int _profit;
        private int _newDiscount;
        private int _numberMonthPurch;
        private int _pricePlanDeals;
        private string _login;

        private TableMenager _tableMenager = new TableMenager();

        public ColculateStatistick()
        {
            _login = MainMenuForm.mainMenu.Login;

            _numberMonthPurch = DateTime.Today.Month;
        }

        public void AddClient()
        {
            string request = $"UPDATE Statistics SET Statistics.[Новых покупателей] = [Новых покупателей]+1 WHERE Месяц = '{_months[_numberMonthPurch - 1]}'; ";
            _tableMenager.ExecuteRequest(request);

            request = $"UPDATE Employees SET Заработная_плата = Заработная_плата + 10 WHERE Логин = '{_login}';";
            _tableMenager.ExecuteRequest(request);
        }

        public void AddSoldItem(int toPay)
        {
            _wage = GetWage(toPay);
            _profit = ColculateProfit(toPay);
            _trustLvl = ColculateTrustLVl(toPay);
            _newDiscount = GetDiscount(int.Parse(SaleComputersForm.saleComputers.Pasport), toPay);
            _pricePlanDeals = GetPricePlanDeals(toPay);

            string request = $"UPDATE Statistics SET Statistics.[Проданный товар] = [Проданный товар]+1, Statistics.[Средний уровень доверия] = '{_trustLvl}', Statistics.[Сумма плановых сделок] = '{_pricePlanDeals}', Statistics.[Полученая прибыль] = '{_profit}' WHERE Месяц = '{_months[_numberMonthPurch - 1]}'; ";
            _tableMenager.ExecuteRequest(request);

            request = $"UPDATE Employees SET Полученная_прибыль = '{_profit}', Заработная_плата = '{_wage}', Уровень_доверия = '{(toPay * 2 / 100)}'  WHERE Логин = '{_login}';";
            _tableMenager.ExecuteRequest(request);

            request = $"UPDATE Clients SET [Предоставить скидку] = '{_newDiscount}' WHERE Паспорт = '{SaleComputersForm.saleComputers.Pasport}';";
            _tableMenager.ExecuteRequest(request);
        }

        private int ColculateTrustLVl(int toPay)
        {
            string request = $"SELECT Уровень_доверия FROM Employees";
            string[] trustEmployees = _tableMenager.SelectInDB(request);

            int meanTrust = 0;
            foreach (var trust in trustEmployees)
            {
                meanTrust += int.Parse(trust);
            }
            meanTrust += (toPay * 2 / 100);

            return meanTrust / (trustEmployees.Length + 1);
        }

        private int GetDiscount(int pasportNumber, int toPay)
        {
            string request = $"SELECT [Предоставить скидку] FROM Clients WHERE Паспорт = '{pasportNumber}'";

            return int.Parse(_tableMenager.SelectInDB(request)[0] + (toPay * 1 / 100));
        }

        private int GetWage(int toPay)
        {
            string request = $"SELECT Заработная_плата FROM Employees WHERE Логин = '{_login}'";

            return int.Parse(_tableMenager.SelectInDB(request)[0]) + (toPay * 10 / 100);
        }

        private int ColculateProfit(int toPay)
        {
            string request = $"SELECT [Полученая прибыль] FROM Statistics WHERE Месяц = '{_months[_numberMonthPurch]}'";

            return int.Parse(_tableMenager.SelectInDB(request)[0]) + toPay;
        }

        private int GetPricePlanDeals(int toPay)
        {
            string request = $"SELECT [Сумма плановых сделок] FROM Statistics WHERE Месяц = '{_months[_numberMonthPurch]}'";

            return int.Parse(_tableMenager.SelectInDB(request)[0]) - toPay;
        }
    }
}