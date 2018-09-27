using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab3
    {
        public static void RunTask1()
        {
            int p = HelperClass.Input<int>("Введите число p: ");
            int q = HelperClass.Input<int>("Введите число q: ");
            if ((p % q == 0))
            {
                Console.WriteLine("Число " + p + " делится на число " + q + " без остатка");
            }
            else Console.WriteLine("Число " + p + " делится на число " + q + " с остатком");
            HelperClass.PressAnyKey();
        }

        public static void RunTask2()
        {
            double x = HelperClass.Input<double>("Введите x: ");
            if ((x > 1) && (x < 2)) Console.WriteLine("y: " + Math.Pow(Math.Cos(x), 2));
            else Console.WriteLine("y: " + (1 + Math.Pow(Math.Sin(x), 2)));
            HelperClass.PressAnyKey();
        }
    }
}
