using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Практическая_2_1
{
    public partial class MainForm : Form
    {
        // Объявляем списки
        List<int> originalList = new List<int>();
        List<int> processedList = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        // Метод для генерации списка
        private List<int> GenerateList(int count)
        {
            List<int> result = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                // Генерируем числа от -50 до 50
                result.Add(rnd.Next(-50, 51));
            }
            return result;
        }

        // Метод для удаления каждого второго элемента
        private List<int> RemoveEverySecond(List<int> list)
        {
            // Создаем копию, чтобы не менять исходный список
            List<int> result = new List<int>(list);

            // Идем с конца, чтобы при удалении не сбились индексы
            for (int i = result.Count - 1; i >= 0; i--)
            {
                // Если индекс нечетный (1, 3, 5...) - это и есть каждый второй
                if (i % 2 != 0)
                {
                    result.RemoveAt(i);
                }
            }
            return result;
        }

        // Кнопка "Сгенерировать"
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCount, ""); // Сбрасываем старые ошибки

            if (string.IsNullOrWhiteSpace(txtCount.Text))
            {
                errorProvider1.SetError(txtCount, "Введите количество!");
                return;
            }

            try
            {
                int count = Convert.ToInt32(txtCount.Text);

                if (count <= 0)
                {
                    MessageBox.Show("Число элементов должно быть больше нуля!", "Ошибка");
                    return;
                }

                // Вызываем метод генерации
                originalList = GenerateList(count);

                // Выводим результат на форму
                lstOriginal.Items.Clear();
                foreach (int item in originalList)
                {
                    lstOriginal.Items.Add(item);
                }

                // Очищаем второй список, так как данные изменились
                lstProcessed.Items.Clear();
                processedList.Clear();
            }
            catch (FormatException)
            {
                errorProvider1.SetError(txtCount, "Нужно ввести целое число!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
        }

        // Кнопка "Удалить каждый второй"
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (originalList.Count == 0)
            {
                MessageBox.Show("Сначала сгенерируйте список!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вызываем метод удаления
            processedList = RemoveEverySecond(originalList);

            // Выводим результат на форму
            lstProcessed.Items.Clear();
            foreach (int item in processedList)
            {
                lstProcessed.Items.Add(item);
            }
        }
    }
}