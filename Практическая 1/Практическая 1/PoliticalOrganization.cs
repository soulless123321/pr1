using System;
using System.Windows.Forms;

namespace Практическая_1
{
    // Базовый класс по заданию
    public class PoliticalOrganization
    {
        // Поля скрыты, чтобы к ним не лезли напрямую (инкапсуляция)
        protected string name;
        protected string ideology;
        protected int rating;

        // Свойства для доступа
        public string Name
        {
            get { return name; }
            set { if (value != "") name = value; }
        }
        public string Ideology
        {
            get { return ideology; }
            set { if (value != "") ideology = value; }
        }

        public int Rating
        {
            get { return rating; }
            // Рейтинг меняем только внутри класса, чтобы не сломать логику
            protected set
            {
                if (value < 0) rating = 0;
                else if (value > 100) rating = 100;
                else rating = value;
            }
        }

        // Конструктор
        public PoliticalOrganization(string name, string ideology)
        {
            this.Name = name;
            this.Ideology = ideology;
            this.rating = 50; // по умолчанию даем 50
        }

        // Виртуальный метод для наследников (полиморфизм)
        public virtual void DoActivity()
        {
            Random rnd = new Random();
            int chance = rnd.Next(3);
            string msg = "";

            switch (chance)
            {
                case 0:
                    msg = "Прошла удачная пресс-конференция.";
                    Rating += 10;
                    break;
                case 1:
                    msg = "В СМИ вышла статья с критикой.";
                    Rating -= 15;
                    break;
                default:
                    msg = "Тихий день, ничего не произошло.";
                    break;
            }

            MessageBox.Show($"Событие организации:\n{msg}\nТекущий рейтинг: {Rating}", "Инфо");
        }
    }
}