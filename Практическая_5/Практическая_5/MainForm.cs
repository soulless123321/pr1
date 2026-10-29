using System;
using System.Windows.Forms;

namespace Практическая_5
{
    public partial class MainForm : Form
    {
        // 1. ОБЪЯВЛЕНИЕ ДЕЛЕГАТА (по методичке)
        // Он принимает double (радиус) и возвращает double (результат)
        public delegate double CalcFigure(double r);

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Проверка на пустоту
            if (string.IsNullOrWhiteSpace(txtR.Text))
            {
                errorProvider1.SetError(txtR, "Введите радиус!");
                return;
            }

            try
            {
                // Парсим радиус
                double radius = Convert.ToDouble(txtR.Text);
                if (radius <= 0)
                {
                    MessageBox.Show("Радиус должен быть больше нуля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создаем экземпляр класса с формулами
                Figures fig = new Figures();

                // 2. СОЗДАНИЕ ДЕЛЕГАТОВ (как в Листинге 3)
                // Связываем делегат с конкретными методами класса Figures
                CalcFigure cfLength = new CalcFigure(fig.Get_Length);
                CalcFigure cfArea = new CalcFigure(fig.Get_Area);
                CalcFigure cfVolume = new CalcFigure(fig.Get_Volume);

                // 3. ВЫЗОВ МЕТОДОВ ЧЕРЕЗ ДЕЛЕГАТЫ
                double length = cfLength(radius);
                double area = cfArea(radius);
                double volume = cfVolume(radius);

                // 4. ВЫВОД НА ФОРМУ
                lblLength.Text = "Длина окружности = " + length.ToString();
                lblArea.Text = "Площадь круга = " + area.ToString();
                lblVolume.Text = "Объем шара = " + volume.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
        }
    }
}