using System;

namespace Практическая_6_2
{
    // Подсистема 1: Кредитная история
    public class CreditHistory
    {
        public void CheckHistory(string clientName)
        {
            // Имитация проверки. Если в имени есть "Плохой", то история испорчена.
            if (clientName.ToLower().Contains("плохой") || clientName.ToLower().Contains("иванов"))
            {
                throw new Exception("Плохая кредитная история! В ипотеке отказано.");
            }
        }
    }

    // Подсистема 2: Банк
    public class Bank
    {
        public void CheckFunds(decimal amount)
        {
            // Банк выдает ипотеку только до 10 миллионов
            if (amount > 10000000)
            {
                throw new Exception("Банк не может выдать такую сумму (максимум 10 млн).");
            }
        }
    }

    // Подсистема 3: Баланс клиента
    public class ClientBalance
    {
        public void CheckBalance(decimal downPayment)
        {
            // Первоначальный взнос должен быть не меньше 500 000
            if (downPayment < 500000)
            {
                throw new Exception("Недостаточно средств для первоначального взноса (нужно от 500 000 руб.).");
            }
        }
    }
}