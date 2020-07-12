using System;
using System.Globalization;
using System.Numerics;

namespace c_practic.Extensions
{
    public static class ComplexExtension
    {
        private static NumberFormatInfo DefaultNumberFormatInfo => new NumberFormatInfo() { NumberDecimalSeparator = "." };
        /// <summary>
        /// Получение корней n-ой степени комплексного числа
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <param name="n">Степень корня</param>
        /// <returns></returns>
        public static Complex[] CalcNthRoots(this Complex complex, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            Complex[] nthRoots = new Complex[n];
            // Модуль комплексного числа
            // Можно получить из св-ва класса комплексного числа complex.Magnitude
            double magnitude = Math.Sqrt(Math.Pow(complex.Real, 2) + Math.Pow(complex.Imaginary, 2));
            // аргумент комплексного числа
            // Можно получить из св-ва класса комплексного числа complex.Phase
            double phase = Math.Atan2(complex.Imaginary, complex.Real);

            var nthRootOfMagnitude = Math.Pow(magnitude, 1d / n);

            for (int k = 0; k < n; k++)
            {
                double angleRadians = (phase + 2 * Math.PI * k) / n;
                // Вычисляем корень
                // Можно использовать метод создания комплексного числа из полярных координат точки
                // nthRoots[k] = Complex.FromPolarCoordinates(nthRootOfMagnitude, angleRadians);
                nthRoots[k] = new Complex(nthRootOfMagnitude * Math.Cos(angleRadians), nthRootOfMagnitude * Math.Sin(angleRadians));
            }

            return nthRoots;
        }

        /// <summary>
        /// Конвертирование комплексного числа в строку формата x + yi,
        /// где x - действительная часть числа, y - мнимая часть числа
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <param name="decimals">Кол-во символов после запятой</param>
        /// <param name="numberFormatInfo">Формат числа (по умолчанию разделитель десятичной части '.')</param>
        /// <returns></returns>
        public static string ToString(this Complex complex, int decimals, NumberFormatInfo numberFormatInfo = null)
        {
            return $"{Math.Round(complex.Real, decimals).ToString(numberFormatInfo ?? DefaultNumberFormatInfo)} " +
                $"{(complex.Imaginary >= 0 ? "+" : "-")} " +
                $"{Math.Round(Math.Abs(complex.Imaginary), decimals).ToString(numberFormatInfo ?? DefaultNumberFormatInfo)}i";
        }
    }
}
