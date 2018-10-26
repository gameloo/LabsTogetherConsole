using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab7
    {
        public static void RunTask1()
        {
            var str = HelperClass.Input<string>("Строковая переменная: ");
            var a = HelperClass.Input<string>("Первая буква: ", (x) => x.Length == 1);
            var b = HelperClass.Input<string>("Вторая буква: ", (x) => x.Length == 1);
            int aCount = new Regex(a).Matches(str).Count;
            int bCount = new Regex(b).Matches(str).Count;
            Console.WriteLine("Суммароное число букв {0} и {1}: {2}", a, b, (aCount + bCount));
            if (aCount > bCount) Console.WriteLine("{0} > {1}", a, b);
            else if (aCount < bCount) Console.WriteLine("{0} < {1}", a, b);
            else Console.WriteLine("{0} = {1}", a, b);
            HelperClass.PressAnyKey();
        }

        public static void RunTask2()
        {
            var str = HelperClass.Input<string>("Строковая переменная: ");
            string input = HelperClass.Input<string>("Подстрока: ");
            var regex = new Regex(@"\b+" + input + @"\b+|^" + input + @"\b+|" + @"\b+" + input +@"$");
            str = regex.Replace(str, " ");
            Console.WriteLine(new Regex(@"\s\s+").Replace(str, " "));
            HelperClass.PressAnyKey();
        }

        public static void RunTask3()
        {

        }
    }
}
