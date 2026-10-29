using System;

namespace Практическая_5
{
    // Класс с математическими формулами (как в Листинге 5)
    public class Figures
    {
        // 1. Длина окружности (C = 2 * pi * R)
        public double Get_Length(double r)
        {
            return Math.Round(2 * Math.PI * r, 3);
        }

        // 2. Площадь круга (S = pi * R^2)
        public double Get_Area(double r)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2), 3);
        }

        // 3. Объем шара (V = (4/3) * pi * R^3)
        public double Get_Volume(double r)
        {
            return Math.Round(Math.PI * Math.Pow(r, 3) * 4 / 3, 3);
        }
    }
}