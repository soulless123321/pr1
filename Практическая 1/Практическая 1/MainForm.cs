using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Практическая_1
{
    public partial class MainForm : Form
    {
        // Переменная для нашей партии
        PoliticalParty party;

        public MainForm()
        {
            InitializeComponent();
            // Кнопка "Деятельность" не работает, пока не создана партия
            btnActivity.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Проверка пустых полей через ErrorProvider
            if (txtName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtName, "Введите название!");
                return;
            }
            errorProvider1.SetError(txtName, "");

            if (txtIdeology.Text.Trim() == "")
            {
                errorProvider1.SetError(txtIdeology, "Введите идеологию!");
                return;
            }
            errorProvider1.SetError(txtIdeology, "");

            // Обработка ошибок через try-catch
            try
            {
                // Пытаемся перевести текст в число
                int seats = Convert.ToInt32(txtSeats.Text);

                // Создаем объект класса-наследника
                party = new PoliticalParty(txtName.Text, txtIdeology.Text, seats);

                // Обновляем надпись и включаем кнопку
                UpdateLabel();
                btnActivity.Enabled = true;
                MessageBox.Show("Партия успешно создана!", "Успех");
            }
            catch (FormatException)
            {
                MessageBox.Show("Мест должно быть целым числом (без букв)!", "Ошибка ввода");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так: " + ex.Message, "Ошибка");
            }
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            if (party != null)
            {
                // Вызываем случайное событие
                party.DoActivity();

                // Обновляем текст на форме
                UpdateLabel();
            }
        }

        // Вспомогательный метод для вывода текста
        private void UpdateLabel()
        {
            if (party != null)
            {
                lblInfo.Text = $"Название: {party.Name}\n" +
                               $"Идеология: {party.Ideology}\n" +
                               $"Рейтинг: {party.Rating}\n" +
                               $"Мест в парламенте: {party.Seats}";
            }
        }
    }
}