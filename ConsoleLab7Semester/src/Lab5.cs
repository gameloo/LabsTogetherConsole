using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab5
    {
        public static void RunTask1()
        {
            var array = new double[3];
            for (int i = 0; i < array.Length; i++)
                array[i] = HelperClass.Input<double>("Введите" + (i + 1) + "е число: ");
            Console.WriteLine("Максимальное число: " + array.Max());
            HelperClass.PressAnyKey();
        }

        public static void RunTask2()
        {
            var n = HelperClass.Input<int>("n: ", (x) => x > 0);
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += 1 / Math.Pow(i, 2);
            Console.WriteLine("Сумма ряда: " + sum);
            HelperClass.PressAnyKey();
        }

        public static void RunTask3()
        {
            double eps = HelperClass.Input<double>("eps: ", (x) => x > 0);
            Console.WriteLine("Сумма ряда: " + CalculateTask3(1, eps));
            HelperClass.PressAnyKey();
        }

        private static int Counter = 0;
        private static double CalculateTask3(double number, double eps)
        {
            Counter++;
            double tempNum = number * 1 / Math.Sqrt(Counter);
            if (tempNum >= eps)
                return tempNum + CalculateTask3(tempNum, eps);
            else
            {
                Counter = 0;
                return tempNum;
            }
        }

        public static void RunTask4()
        {
            string strNumber = HelperClass.Input<Int64>("Введите целочисленное число: ").ToString();
            int numeral = HelperClass.Input<int>("Введите цифру для поиска: ", (x) => ((x >= 0) && (x <= 9)));
            Console.WriteLine("Количество вхождений: " + new Regex(numeral.ToString()).Matches(strNumber).Count);
            HelperClass.PressAnyKey();
        }
    }
}
