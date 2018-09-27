using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab1
    {
        public static void RunTask1()
        {
            Console.WriteLine("Введите x, y, z");
            Console.WriteLine("Ответ: " + CalculateTask1(
                HelperClass.Input<double>("x: "),
                HelperClass.Input<double>("y: "),
                HelperClass.Input<double>("z: ")
                ));
            HelperClass.PressAnyKey();
        }

        public static void RunTask2()
        {
            Console.WriteLine("Поиск площади треугольника");
            Console.WriteLine("Выберите вид треугольника:\n" +
                "1. Произвольный треугольник\n" +
                "2. Равносторонний\n" +
                "3. Прямоугольный треугольник");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.WriteLine("Найти через:\n" +
                            "1. Сторону и высоту проведенную к ней\n" +
                            "2. Через две стороны и угол между ними\n" +
                            "3. Через 3 стороны\n" +
                            "4. Через полупериметр и радиус вписанной окружности\n" +
                            "5. Через произведение сторон и радиус описанной окружности");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    double a = HelperClass.Input<double>("Сторона: ", (x) => x > 0);
                                    double h = HelperClass.Input<double>("Высота: ", (x) => x > 0);
                                    Console.WriteLine("S = " + 0.5 * a * h);
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "2":
                                {
                                    double a = HelperClass.Input<double>("Сторона 1: ", (x) => x > 0);
                                    double b = HelperClass.Input<double>("Сторона 2: ", (x) => x > 0);
                                    double y = HelperClass.Input<double>("Угол между сторонами 1 и 2: ", (x) => x > 0);
                                    Console.WriteLine("S = " + 0.5 * a * b * Math.Sin(y * Math.PI / 180));
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "3":
                                {
                                    double a = HelperClass.Input<double>("Сторона 1: ", (x) => x > 0);
                                    double b = HelperClass.Input<double>("Сторона 2: ", (x) => x > 0);
                                    double c = HelperClass.Input<double>("Сторона 3: ", (x) => x > 0);
                                    double p = (a + b + c) / 2;
                                    Console.WriteLine("S = " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "4":
                                {
                                    double p = HelperClass.Input<double>("Полупериметр: ", (x) => x > 0);
                                    double r = HelperClass.Input<double>("Радиус вписанной окружности: ", (x) => x > 0);
                                    Console.WriteLine("S = " + p * r);
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "5":
                                {
                                    double a = HelperClass.Input<double>("Сторона 1: ", (x) => x > 0);
                                    double b = HelperClass.Input<double>("Сторона 2: ", (x) => x > 0);
                                    double c = HelperClass.Input<double>("Сторона 3: ", (x) => x > 0);
                                    double r = HelperClass.Input<double>("Радиус описанной окружности: ", (x) => x > 0);
                                    Console.WriteLine("S = " + (a * b * c) / (4 * r));
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            default: break;
                        }
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Найти через:\n" +
                            "1. Сторону\n" +
                            "2. Радиус вписанной окружности\n" +
                            "3. Радиус описанной окружности");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    double a = HelperClass.Input<double>("Сторона: ", (x) => x > 0);
                                    Console.WriteLine("S = " + (Math.Sqrt(3) * Math.Pow(a, 2)) / 4);
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "2":
                                {
                                    double r = HelperClass.Input<double>("Радиус вписанной окружности: ", (x) => x > 0);
                                    Console.WriteLine("S = " + 3 * Math.Sqrt(3) * Math.Pow(r, 2));
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "3":
                                {
                                    double r = HelperClass.Input<double>("Радиус описанной окружности: ", (x) => x > 0);
                                    Console.WriteLine("S = " + 3 * Math.Sqrt(3) * Math.Pow(r, 2) / 4
);
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                        }
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Найти через:\n" +
                            "1. Катеты\n" +
                            "2. Катет и острый угол\n" +
                            "3. Гипотенузу и любой из острых углов");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    double a = HelperClass.Input<double>("Катет 1: ", (x) => x > 0);
                                    double b = HelperClass.Input<double>("Катет 2: ", (x) => x > 0);
                                    Console.WriteLine("S = " + 0.5 * a * b);
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "2":
                                {
                                    double a = HelperClass.Input<double>("Катет: ", (x) => x > 0);
                                    double b = HelperClass.Input<double>("Острый угол: ", (x) => x > 0);
                                    Console.WriteLine("S = " + 0.5 * Math.Pow(a, 2) * Math.Tan(b * Math.PI / 180));
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                            case "3":
                                {
                                    double a = HelperClass.Input<double>("Гипотенуза: ", (x) => x > 0);
                                    double b = HelperClass.Input<double>("Острый угол: ", (x) => x > 0);
                                    Console.WriteLine("S = " + 0.25 * a * Math.Sin(2 * b * Math.PI / 180));
                                    HelperClass.PressAnyKey();
                                    break;
                                }
                        }
                        break;
                    }
            }

        }

        private static double CalculateTask1(double x, double y, double z)
        {
            return Math.Log10(
                (y - Math.Sqrt(Math.Abs(x))) *
                (x - y / (z + Math.Pow(x, 2) / 4))
                );
        }

    }
}
