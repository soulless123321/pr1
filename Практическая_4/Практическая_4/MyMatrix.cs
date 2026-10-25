using System;

namespace Практическая_4
{
    // Шаблонный класс матрицы (T - тип данных)
    public class MyMatrix<T> where T : IComparable
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public T[,] Data { get; private set; }

        // Конструктор
        public MyMatrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Размеры матрицы должны быть больше нуля!");

            Rows = rows;
            Cols = cols;
            Data = new T[rows, cols];
        }

        // Заполнение случайными числами
        public void FillRandom(int min, int max)
        {
            if (min >= max)
                throw new ArgumentException("Минимум должен быть меньше максимума!");

            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    int randomValue = rnd.Next(min, max + 1);
                    // Конвертируем int в нужный тип T
                    Data[i, j] = (T)Convert.ChangeType(randomValue, typeof(T));
                }
            }
        }

        // Метод проверки нулей в строках (возвращает текст для вывода)
        public string CheckZeros()
        {
            string result = "";
            for (int i = 0; i < Rows; i++)
            {
                bool hasZero = false;
                for (int j = 0; j < Cols; j++)
                {
                    // Сравниваем элемент с нулем
                    if (Data[i, j].CompareTo(0) == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }
                result += $"Строка {i + 1}: {(hasZero ? "Есть нули" : "Нулей нет")}\r\n";
            }
            return result;
        }

        // Метод для вывода матрицы в виде текста
        public string GetMatrixString()
        {
            string res = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    res += Data[i, j].ToString() + "\t";
                }
                res += "\r\n";
            }
            return res;
        }
    }
}