using System;
using System.Windows.Forms;

namespace Практическая_1
{
    // Наследуемся от политической организации
    public class PoliticalParty : PoliticalOrganization
    {
        private int seats;

        public int Seats
        {
            get { return seats; }
            set
            {
                // Простая проверка на отрицательное число
                if (value < 0) throw new ArgumentException("Мест не может быть меньше нуля!");
                seats = value;
            }
        }

        // Передаем имя и идеологию в базовый класс через base
        public PoliticalParty(string name, string ideology, int seats) : base(name, ideology)
        {
            this.Seats = seats;
        }

        // Переопределяем метод (полиморфизм)
        public override void DoActivity()
        {
            Random rnd = new Random();
            int chance = rnd.Next(4);
            string msg = "";

            switch (chance)
            {
                case 0:
                    msg = "Партия выиграла выборы!";
                    Rating += 20;
                    Seats += 5;
                    break;
                case 1:
                    msg = "Скандал с бюджетом партии.";
                    Rating -= 25;
                    Seats -= 3;
                    break;
                case 2:
                    msg = "Провели хороший митинг.";
                    Rating += 10;
                    break;
                default:
                    msg = "Лидер партии ушел в отпуск.";
                    break;
            }

            // Защита, чтобы места не ушли в минус
            if (Seats < 0) Seats = 0;

            MessageBox.Show($"Событие партии:\n{msg}\nРейтинг: {Rating}\nМест в парламенте: {Seats}", "Инфо");
        }
    }
}