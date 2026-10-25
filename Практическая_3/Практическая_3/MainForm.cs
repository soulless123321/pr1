using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Практическая_3
{
    public partial class MainForm : Form
    {
        // Списки для разных типов данных (как в методичке)
        List<int> intList = null;
        List<double> doubleList = null;
        List<string> stringList = null;

        // Переменная для хранения типа текущего списка
        string listType = null;

        public MainForm()
        {
            InitializeComponent();
        }

        // Шаблонная функция для вычисления суммы отрицательных элементов
        public static dynamic SumNegative<T>(List<T> list) where T : IComparable
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));
            if (list.Count == 0)
                throw new InvalidOperationException("Список пуст");

            dynamic sum = 0;
            bool hasNegative = false;

            foreach (T item in list)
            {
                if (item == null) continue; // Пропускаем null

                // Проверяем, является ли элемент числом (чтобы избежать ошибки при строках)
                if (item is int || item is double || item is float || item is decimal)
                {
                    if (item.CompareTo(0) < 0) // Если элемент меньше нуля
                    {
                        sum += (dynamic)item;
                        hasNegative = true;
                    }
                }
                else
                {
                    throw new InvalidOperationException("Нельзя вычислить сумму для строк!");
                }
            }

            if (!hasNegative)
                return "Нет отрицательных чисел";

            return sum;
        }

        // Кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                errorProvider1.SetError(txtInput, "Введите значение!");
                return;
            }

            // Если тип еще не определен, определяем его по первому элементу
            if (listType == null)
            {
                int intVal;
                double doubleVal;

                if (int.TryParse(input, out intVal))
                {
                    intList = new List<int>();
                    intList.Add(intVal);
                    listType = "int";
                    lstOutput.Items.Add(intVal);
                }
                else if (double.TryParse(input, out doubleVal))
                {
                    doubleList = new List<double>();
                    doubleList.Add(doubleVal);
                    listType = "double";
                    lstOutput.Items.Add(doubleVal);
                }
                else
                {
                    stringList = new List<string>();
                    stringList.Add(input);
                    listType = "string";
                    lstOutput.Items.Add(input);
                }
                errorProvider1.Clear();
            }
            else
            {
                // Если тип уже задан, проверяем соответствие
                if (listType == "int")
                {
                    int val;
                    if (!int.TryParse(input, out val))
                    {
                        errorProvider1.SetError(txtInput, "Ожидается тип int!");
                        return;
                    }
                    intList.Add(val);
                    lstOutput.Items.Add(val);
                }
                else if (listType == "double")
                {
                    double val;
                    if (!double.TryParse(input, out val))
                    {
                        errorProvider1.SetError(txtInput, "Ожидается тип double!");
                        return;
                    }
                    doubleList.Add(val);
                    lstOutput.Items.Add(val);
                }
                else if (listType == "string")
                {
                    stringList.Add(input);
                    lstOutput.Items.Add(input);
                }
                errorProvider1.Clear();
            }
            txtInput.Clear();
            txtInput.Focus();
        }

        // Кнопка "Вычислить"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (listType == null)
            {
                errorProvider1.SetError(btnCalculate, "Список пуст!");
                return;
            }

            try
            {
                dynamic result = null;

                if (listType == "int")
                    result = SumNegative(intList);
                else if (listType == "double")
                    result = SumNegative(doubleList);
                else if (listType == "string")
                    result = SumNegative(stringList);

                MessageBox.Show($"Сумма отрицательных элементов: {result}", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}