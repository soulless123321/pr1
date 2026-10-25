using System;

namespace Практическая_6_2
{
    // Паттерн Фасад
    public class MortgageFacade
    {
        // Ссылки на подсистемы
        private CreditHistory _history;
        private Bank _bank;
        private ClientBalance _client;

        public MortgageFacade()
        {
            _history = new CreditHistory();
            _bank = new Bank();
            _client = new ClientBalance();
        }

        // Единый метод для оформления ипотеки
        public void ApplyForMortgage(string name, decimal amount, decimal downPayment)
        {
            // Проверка на здравый смысл: взнос не может быть больше или равен сумме ипотеки
            if (downPayment >= amount)
            {
                throw new Exception("Первоначальный взнос не может быть больше или равен сумме ипотеки! Вам не нужен кредит.");
            }

            // Вызываем проверки по очереди
            _history.CheckHistory(name);
            _bank.CheckFunds(amount);
            _client.CheckBalance(downPayment);
        }
    }
}