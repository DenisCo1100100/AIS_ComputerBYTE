using System;

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
        private double _trustLvl;
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

        public void AddClient(int profit)
        {
            string request = $"UPDATE Statistics SET Statistics.[Новых покупателей] = [Новых покупателей]+1, [Сумма плановых сделок] = [Сумма плановых сделок] + '{profit}' WHERE Месяц = '{_months[_numberMonthPurch - 1]}'; ";
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

        private double ColculateTrustLVl(int toPay)
        {
            string request = $"SELECT COUNT(Уровень_доверия) FROM Employees";
            string[] count = _tableMenager.SelectInDB(request);

            request = $"SELECT Уровень_доверия FROM Employees";
            string[] trustEmployees = _tableMenager.SelectInDB(request, int.Parse(count[0]));

            double meanTrust = 0;
            foreach (var trust in trustEmployees)
            {
                meanTrust += double.Parse(trust);
            }
            meanTrust += (toPay * 2 / 100);

            return meanTrust / (trustEmployees.Length + 1.0);
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

        public double ColculateForecastProfit(int monthNumber)
        {
            string request = $"SELECT COUNT(Фамилия) FROM Clients WHERE [Предпологаемый месяц] = '{_months[monthNumber]}'";
            string[] countClients = _tableMenager.SelectInDB(request);

            request = $"SELECT [Средняя зарплата] FROM Clients WHERE [Предпологаемый месяц] = '{_months[monthNumber]}'";
            string[] wagesClients = _tableMenager.SelectInDB(request, int.Parse(countClients[0]));

            double sumWages = 0;
            foreach (string wage in wagesClients)
            {
                if (wage != null)
                {
                    sumWages += double.Parse(wage) / 3;
                }
            }

            return sumWages * ColculateForecastSeling(monthNumber);
        }

        public double ColculateForecastSeling(int monthNumber)
        {
            string request = $"SELECT COUNT(Фамилия) FROM Clients WHERE [Предпологаемый месяц] = '{_months[monthNumber]}'";
            string[] clients = _tableMenager.SelectInDB(request);

            request = $"SELECT [Средний уровень доверия], [Проданный товар], [Сумма плановых сделок], [Полученая прибыль] FROM Statistics WHERE Месяц = '{_months[_numberMonthPurch - 1]}'";
            string[] statistic = _tableMenager.SelectInDB(request);
            double resulColculate = double.Parse(statistic[0]) * double.Parse(clients[0]) / 100.0;
            resulColculate = resulColculate * double.Parse(statistic[1]) / 100.0;

            resulColculate = double.Parse(statistic[3]) * 100 / double.Parse(statistic[2]) * resulColculate;

            return resulColculate;
        }
    }
}