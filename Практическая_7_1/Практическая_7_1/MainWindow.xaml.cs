using System;
using System.Windows;

namespace Практическая_7_1
{
    public partial class MainWindow : Window
    {
        // Массив с пятью мифами о космосе
        private string[] myths = new string[]
        {
            "Миф 1: В космосе невесомость. На самом деле на МКС действует микрогравитация, но она почти незаметна.",
            "Миф 2: Солнце — это шар из огня. На самом деле это раскаленный шар из плазмы, где нет обычного горения.",
            "Миф 3: В космосе человек мгновенно взорвется. Нет, кожа достаточно прочна, чтобы удержать давление, но дышать будет нечем.",
            "Миф 4: Луна вращается вокруг Земли. Строго говоря, и Земля, и Луна вращаются вокруг общего центра масс.",
            "Миф 5: Черные дыры — это пылесосы, которые засасывают всё. На самом деле они притягивают только то, что подлетело слишком близко."
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку
        private void btnLaunch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // 1. Выводим сообщение об успешном полете
                MessageBox.Show("Полет прошел удачно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                // 2. Выбираем случайный миф
                Random rnd = new Random();
                int index = rnd.Next(myths.Length); // Получаем число от 0 до 4

                // 3. Выводим миф на экран (в наш TextBlock)
                txtMyth.Text = myths[index];
            }
            catch (Exception ex)
            {
                // Обработка ошибок (по методичке)
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}