using System;

namespace Практическая_6_1
{
    // Паттерн Одиночка (Singleton)
    public sealed class GroceryBasket
    {
        // Статическая переменная для хранения единственного экземпляра
        private static GroceryBasket _instance;

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public bool IsPurchased { get; private set; }

        // Закрытый конструктор (чтобы нельзя было создать через new)
        private GroceryBasket()
        {
            Name = "Корзина 'Не съедобно, но очень дорого'";
            Price = 1000000; // Начальная цена - миллион
            IsPurchased = false;
        }

        // Статический метод для получения единственного экземпляра
        public static GroceryBasket GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GroceryBasket();
            }
            return _instance;
        }

        // Метод покупки корзины
        public void Buy()
        {
            if (IsPurchased)
            {
                throw new InvalidOperationException("Эта корзина уже куплена!");
            }
            IsPurchased = true;
        }

        // Метод случайных событий
        public string TriggerRandomEvent()
        {
            if (!IsPurchased)
            {
                throw new InvalidOperationException("Сначала нужно купить корзину!");
            }

            Random rnd = new Random();
            int chance = rnd.Next(4); // Генерируем число от 0 до 3

            switch (chance)
            {
                case 0:
                    Price += 50000;
                    return "В мире вырос спрос на блестящие упаковки! Цена выросла на 50 000 руб.";
                case 1:
                    Price -= 100000;
                    return "Мода на 'несъедобное' прошла. Коллекционеры распродают товары, цена упала на 100 000 руб.";
                case 2:
                    return "Покупатель пришел в восторг! Он просто смотрит на корзину и плачет от счастья. (Цена не изменилась)";
                case 3:
                    Price += 200000;
                    return "В корзину добавили редкий бриллиант. Цена выросла на 200 000 руб.";
                default:
                    return "Ничего не произошло.";
            }
        }

        // Получение информации о текущем состоянии
        public string GetInfo()
        {
            string status = IsPurchased ? "Куплена (в единственном экземпляре!)" : "Ждет покупателя";
            return $"Название: {Name}\r\nСтатус: {status}\r\nТекущая цена: {Price} руб.";
        }
    }
}