using System;
using System.Windows.Forms;

namespace Практическая_6_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtResult.Text = "";

            // Валидация на пустые поля
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Введите ФИО!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "Введите сумму!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDownPayment.Text))
            {
                errorProvider1.SetError(txtDownPayment, "Введите взнос!");
                return;
            }

            try
            {
                // Парсим числа
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal downPayment = Convert.ToDecimal(txtDownPayment.Text);

                // Создаем Фасад
                MortgageFacade facade = new MortgageFacade();

                // Вызываем единый метод, который сам проверит всё внутри
                facade.ApplyForMortgage(txtName.Text, amount, downPayment);

                // Если ошибок не было, значит ипотека одобрена
                txtResult.Text = $"Клиент: {txtName.Text}\r\n" +
                                 $"Сумма: {amount} руб.\r\n" +
                                 $"Взнос: {downPayment} руб.\r\n" +
                                 $"Статус: ИПОТЕКА ОДОБРЕНА!";
                MessageBox.Show("Ипотека успешно одобрена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числа в поля суммы и взноса!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Сюда попадают наши "нештатные ситуации" (плохая история, нехватка денег)
                txtResult.Text = "СТАТУС: ОТКАЗАНО.\r\nПричина: " + ex.Message;
                MessageBox.Show(ex.Message, "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}