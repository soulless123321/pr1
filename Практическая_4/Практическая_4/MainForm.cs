using System;
using System.Windows.Forms;

namespace Практическая_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Сбрасываем старые ошибки
            errorProvider1.Clear();

            // Проверка на пустоту
            if (string.IsNullOrWhiteSpace(txtRows.Text) || string.IsNullOrWhiteSpace(txtCols.Text) ||
                string.IsNullOrWhiteSpace(txtMin.Text) || string.IsNullOrWhiteSpace(txtMax.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Парсим значения из текстовых полей
                int rows = Convert.ToInt32(txtRows.Text);
                int cols = Convert.ToInt32(txtCols.Text);
                int min = Convert.ToInt32(txtMin.Text);
                int max = Convert.ToInt32(txtMax.Text);

                // Создаем экземпляр шаблонного класса (T = int)
                MyMatrix<int> matrix = new MyMatrix<int>(rows, cols);

                // Заполняем случайными числами
                matrix.FillRandom(min, max);

                // Выводим матрицу на форму
                txtMatrix.Text = matrix.GetMatrixString();

                // Получаем результат проверки на нули и выводим на форму
                txtResult.Text = matrix.CheckZeros();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вводите только целые числа!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка параметров", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }
    }
}