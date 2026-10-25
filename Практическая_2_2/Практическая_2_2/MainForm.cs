using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Практическая_2_2
{
    public partial class MainForm : Form
    {
        // Внешний словарь: Покупатель -> (Товар -> Количество)
        Dictionary<string, Dictionary<string, int>> purchases = new Dictionary<string, Dictionary<string, int>>();

        public MainForm()
        {
            InitializeComponent();
        }

        // Метод для разбора строки и добавления в словарь
        private void AddPurchase(string line)
        {
            // Разбиваем строку по пробелам, убирая лишние
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                throw new FormatException("Неверный формат строки! Нужно: Покупатель Товар Кол-во");
            }

            string customer = parts[0];
            string product = parts[1];
            int quantity;

            // Пытаемся перевести количество в число
            if (!int.TryParse(parts[2], out quantity) || quantity <= 0)
            {
                throw new FormatException("Количество должно быть положительным целым числом!");
            }

            // Если такого покупателя еще нет, создаем для него словарь
            if (!purchases.ContainsKey(customer))
            {
                purchases[customer] = new Dictionary<string, int>();
            }

            // Если товар уже есть, прибавляем количество
            if (purchases[customer].ContainsKey(product))
            {
                purchases[customer][product] += quantity;
            }
            else
            {
                purchases[customer][product] = quantity;
            }
        }

        // Кнопка "Обработать"
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Сбрасываем старые ошибки
            errorProvider1.SetError(txtCount, "");
            errorProvider1.SetError(txtInput, "");

            // Проверяем поле n
            if (string.IsNullOrWhiteSpace(txtCount.Text))
            {
                errorProvider1.SetError(txtCount, "Введите количество!");
                return;
            }

            int n;
            if (!int.TryParse(txtCount.Text, out n) || n <= 0)
            {
                errorProvider1.SetError(txtCount, "Нужно положительное число!");
                return;
            }

            // Получаем строки из текстового поля
            string[] lines = txtInput.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (lines.Length != n)
            {
                errorProvider1.SetError(txtInput, $"Вы указали {n} покупок, а ввели {lines.Length} строк!");
                return;
            }

            // Очищаем словарь и список перед новым расчетом
            purchases.Clear();
            lstOutput.Items.Clear();

            try
            {
                // Заполняем словарь через метод
                foreach (string line in lines)
                {
                    AddPurchase(line);
                }

                // Выводим результат на форму
                DisplayResult();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка: " + ex.Message, "Ошибка");
            }
        }

        // Метод для вывода словаря в ListBox
        private void DisplayResult()
        {
            foreach (var customerEntry in purchases)
            {
                // Выводим имя покупателя
                lstOutput.Items.Add(customerEntry.Key + ":");

                // Проходим по его товарам
                foreach (var productEntry in customerEntry.Value)
                {
                    lstOutput.Items.Add($"    {productEntry.Key} {productEntry.Value}");
                }
            }
        }
    }
}