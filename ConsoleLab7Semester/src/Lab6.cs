using ConsoleLab7Semester.src.Lab6_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab6
    {
        public static void RunTask1()
        {
            var array = new double[HelperClass.Input<int>("Кол-во элементов в массиве: ", (x) => x > 0)];
            for (int i = 0; i < array.Length; i++)
                array[i] = HelperClass.Input<double>("(" + i + " index): ");
            var min = array.Min();
            var max = array.Max();
            Console.WriteLine("Min: " + min + ", порядковый номер: " + (Array.IndexOf(array, min) + 1));
            Console.WriteLine("Max: " + max + ", порядковый номер: " + (Array.IndexOf(array, max) + 1));
            HelperClass.PressAnyKey();
        }

        public static void RunTask2()
        {
            var array = new MyArray<int>(HelperClass.Input<int>("Кол-во массивов в массиве: ", (x) => x > 0));
            for (int i = 0; i < array.GetSize(); i++)
                array.AddArray(HelperClass.Input<int>("Кол-во элементов в" + (i + 1) + " массиве: ", (x) => x > 0));

            Console.WriteLine("Список команд:\n" +
                "get i j - вывести значение array[i][j]\n" +
                "set i j value - array[i][j] = value\n" +
                "exit - выход");

            string pattern = "( )";
            while (true)
            {
                Console.Write(">");
                string[] substr = Regex.Split(Console.ReadLine(), pattern);
                switch (substr[0])
                {
                    case "get":
                        {
                            try
                            {
                                Console.WriteLine(array.Get(Convert.ToInt32(substr[2]), Convert.ToInt32(substr[4])));
                                continue;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                continue;
                            }
                        }
                    case "set":
                        {
                            try
                            {
                                array.SetValue(Convert.ToInt32(substr[2]), Convert.ToInt32(substr[4]), Convert.ToInt32(substr[6]));
                                continue;
                            }
                            catch (Exception e) {
                                Console.WriteLine(e.Message);
                                continue;
                            }
                        }
                    case "exit":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка. Комманды " + substr[0] + " не существует.");
                            continue;
                        }
                }
                break;
            }

            HelperClass.PressAnyKey();
        }
    }
}
