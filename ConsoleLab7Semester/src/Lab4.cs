using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab4
    {
        public static void RunTask1()
        {
            Console.WriteLine("Вычисление площадей различных геометрических фи-гур:\n" +
                "1. Прямоугольник\n" +
                "2. Прямоугольный треугольник\n" +
                "3. Трапеция\n" +
                "4. Круг");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        double a = HelperClass.Input<double>("Высота: ", (x) => x > 0);
                        double b = HelperClass.Input<double>("Ширина: ", (x) => x > 0);
                        Console.WriteLine("S= " + a * b);
                        HelperClass.PressAnyKey();
                        break;
                    }
                case "2":
                    {
                        double a = HelperClass.Input<double>("Гипотенуза: ", (x) => x > 0);
                        double h = HelperClass.Input<double>("Высота: ", (x) => x > 0);
                        Console.WriteLine("S= " + a * h / 2);
                        HelperClass.PressAnyKey();
                        break;
                    }
                case "3":
                    {
                        double a = HelperClass.Input<double>("Сторона а: ", (x) => x > 0);
                        double b = HelperClass.Input<double>("Сторона b, паралельная стороне а: ", (x) => x > 0);
                        double l = HelperClass.Input<double>("Расстояние между a и b : ", (x) => x > 0);
                        Console.WriteLine("S= " + (a + b) * l / 2);
                        HelperClass.PressAnyKey();
                        break;
                    }
                case "4":
                    {
                        double r = HelperClass.Input<double>("Радиус: ", (x) => x > 0);
                        Console.WriteLine("S= " + Math.PI * Math.Pow(r, 2));
                        HelperClass.PressAnyKey();
                        break;
                    }
                default: break;
            }
        }
    }
}
