using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab2
    {
        public static void RunTask1()
        {
            Console.WriteLine("Присвоить случайным образом значения числовым переменным а1, а2,..., а9. Вывести на экран значения этих переменных");
            int[] a = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rnd.Next(0, 99);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a" + (i + 1) + ": " + a[i] + " ");
                if ((i == 0) || (i == 2) || (i == 3) || (i == 5) || (i == 8)) Console.WriteLine();
            }
            HelperClass.PressAnyKey();
        }
    }
}
