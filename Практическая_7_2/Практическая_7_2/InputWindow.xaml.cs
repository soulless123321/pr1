using System;
using System.Windows;

namespace Практическая_7_2
{
    public partial class InputWindow : Window
    {
        // Публичные свойства, чтобы главное окно могло забрать данные
        public int Number1 { get; private set; }
        public int Number2 { get; private set; }

        public bool CalcComposition { get; private set; }
        public bool CalcPower { get; private set; }
        public bool CalcMaxDivisor { get; private set; }

        public InputWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на корректный ввод чисел
            if (!int.TryParse(txtNum1.Text, out int num1) || !int.TryParse(txtNum2.Text, out int num2))
            {
                MessageBox.Show("Введите корректные целые числа!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Проверка, что выбран хотя бы один режим
            if (!(chkComposition.IsChecked == true) && !(chkPower.IsChecked == true) && !(chkMaxDivisor.IsChecked == true))
            {
                MessageBox.Show("Выберите хотя бы один режим вычислений (поставьте галочку)!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Сохраняем данные в свойства
            Number1 = num1;
            Number2 = num2;
            CalcComposition = chkComposition.IsChecked == true;
            CalcPower = chkPower.IsChecked == true;
            CalcMaxDivisor = chkMaxDivisor.IsChecked == true;

            // Закрываем окно с результатом true (успех)
            this.DialogResult = true;
        }
    }
}