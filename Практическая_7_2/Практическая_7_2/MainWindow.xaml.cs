using System;
using System.Windows;
using System.Numerics; // Подключаем библиотеку для больших чисел (BigInteger)

namespace Практическая_7_2
{
    public partial class MainWindow : Window
    {
        // Переменные для хранения данных из окна ввода
        private int _num1;
        private int _num2;
        private bool _calcComp;
        private bool _calcPower;
        private bool _calcDiv;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Команда Input - открывает окно ввода
        private void menuInput_Click(object sender, RoutedEventArgs e)
        {
            InputWindow inputWin = new InputWindow();
            inputWin.Owner = this; // Делаем главное окно "родителем"

            // Если в окне нажали "ОК" (DialogResult == true)
            if (inputWin.ShowDialog() == true)
            {
                // Забираем данные
                _num1 = inputWin.Number1;
                _num2 = inputWin.Number2;
                _calcComp = inputWin.CalcComposition;
                _calcPower = inputWin.CalcPower;
                _calcDiv = inputWin.CalcMaxDivisor;

                // Активируем команду Calc
                menuCalc.IsEnabled = true;
                MessageBox.Show("Данные успешно сохранены. Теперь можно выбрать Calc.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Команда Calc - показывает результаты
        private void menuCalc_Click(object sender, RoutedEventArgs e)
        {
            string resultText = $"Число 1: {_num1}\nЧисло 2: {_num2}\n\n";

            if (_calcComp)
            {
                resultText += $"Произведение: {_num1 * _num2}\n";
            }

            if (_calcPower)
            {
                // Используем BigInteger для точного вычисления огромных чисел без буквы E
                BigInteger powerResult = BigInteger.Pow(new BigInteger(_num1), _num2);
                resultText += $"Возведение в степень: {powerResult}\n";
            }

            if (_calcDiv)
            {
                resultText += $"Наибольший общий делитель (НОД): {GetGCD(_num1, _num2)}\n";
            }

            MessageBox.Show(resultText, "Результаты вычислений", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Команда Quit - закрывает приложение
        private void menuQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Команда About - справка
        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа для выполнения вычислений.\n\nРазработчик: Шемонаев Илья Александрович\nГруппа: 4ИСП",
                            "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Вспомогательный метод для поиска НОД (алгоритм Евклида)
        private int GetGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}