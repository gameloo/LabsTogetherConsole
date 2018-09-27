using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab8
    {
        public static void RunTask1()
        {
            var a = HelperClass.Input<double>("a: ");
            var b = HelperClass.Input<double>("b: ");
            var u = Min(a, b - a);
            Console.WriteLine("u = min({0}, {1} - {0}) = {2}", a, b, u);
            var v = Min(a * b, a + b);
            Console.WriteLine("v = min({0} * {1}, {0} + {1}) = {2}", a, b, v);
            var k = Min(u + v*2, 3.14);
            Console.WriteLine("k = min({0} + {1} * 2, 3,14) = {2}", u, v, k);
            HelperClass.PressAnyKey();
        }


        private static double Min(double x, double y)
        {
            if (x < y) return x;
            else return y;
        }
    }

}
