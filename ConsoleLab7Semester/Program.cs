using ConsoleLab7Semester.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер лабораторной работы (1 - 8, 10; 0 - для выхода из приложения)");
                switch (Console.ReadLine())
                {
                    case "0":
                        {
                            Console.WriteLine("Завершить работу приложения? (y/n)");
                            while (true)
                            {
                                switch (Console.ReadLine())
                                {
                                    case "y":
                                        return;
                                    case "n":
                                        break;
                                    default: continue;
                                }
                                break;
                            }
                            break;
                        }
                    case "1":
                        {
                            Console.WriteLine("Лабораторная работа #1\n" +
                                "Выбор задания:\n" +
                                "1. Даны x, y, z . Вычислить a, если...\n" +
                                "2. Вычислить площадь треугольника по всем известным формулам");
                            switch (Console.ReadLine())
                            {
                                case "1": { Lab1.RunTask1(); break; }
                                case "2": { Lab1.RunTask2(); break; }
                                default: break;
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Лабораторная работа #2");
                            Lab2.RunTask1();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Лабораторная работа #3\n" +
                                "Выбор задания:\n" +
                                "1. Натуральное число p делится нацело на натуральное число q\n" +
                                "2. Составить программу для вычисления функции");
                            switch (Console.ReadLine())
                            {
                                case "1": { Lab3.RunTask1(); break; }
                                case "2": { Lab3.RunTask2(); break; }
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Лабораторная работа #4");
                            Lab4.RunTask1();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Лабораторная работа #5\n" +
                                "Выбор задания:\n" +
                                "1. Поиск минимального элемента из трех элементов\n" +
                                "2. Найти сумму ряда при заданном n\n" +
                                "3. Найти сумму бесконечного ряда при заданном eps\n" +
                                "4. Дано натуральное число. Определить сколько раз в нем встречается цифра а");
                            switch (Console.ReadLine())
                            {
                                case "1": { Lab5.RunTask1(); break; }
                                case "2": { Lab5.RunTask2(); break; }
                                case "3": { Lab5.RunTask3(); break; }
                                case "4": { Lab5.RunTask4(); break; }
                            }
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Лабораторная работа #6\n" +
                                "Выбор задания:\n" +
                                "1. Нахождение минимального и максимального элементов заданной последователь-ности чисел.\n" +
                                "Вывести на экран значения и порядковые номера искомых элементов\n" +
                                "2. Программа для ввода/вывода в массив данных с различной длинной записей");
                            switch (Console.ReadLine())
                            {
                                case "1": { Lab6.RunTask1(); break; }
                                case "2": { Lab6.RunTask2(); break; }
                            }
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("Лабораторная работа #7\n" +
                                "Выбор задания:\n" +
                                "1. Подсчет суммарного числа букв 'а' и букв 'b' в заданной строковой переменной. Вывести на экран каких букв больше\n" +
                                "2. Поиск подстроки в заданной строке. В случае нахождения заданной подстроки необходимо удалить ее.");
                            switch (Console.ReadLine())
                            {
                                case "1": { Lab7.RunTask1(); break; }
                                case "2": { Lab7.RunTask2(); break; }
                            }
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine("Лабораторная работа #8\n" +
                                "Даны действительные числа a, b. Получить u = min(a, b-a), y = min(ab, a+b), k = min(u + v2, 3.14)");
                            Lab8.RunTask1();
                            break;
                        }

                    case "10":
                        {
                            Console.WriteLine("Лабораторная работа #10");
                            Lab10.RunTask();
                            break;
                        }
                    default:
                        {
                            break;
                        }






                }

            }
        }
    }
}
