using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class HelperClass
    {

        public static T Input<T>()
        {
            while (true)
            {
                try
                {
                    return ConvertStringTo<T>(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка формата ввода");
                }
            }
        }

        public static T Input<T>(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                try
                {
                    return ConvertStringTo<T>(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка формата ввода");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public delegate bool InDefining<T>(T x);
        public static T Input<T>(string msg, InDefining<T> inDefining)
        {
            while (true)
            {
                Console.Write(msg);
                try
                {
                    var x = ConvertStringTo<T>(Console.ReadLine());
                    if (inDefining(x)) return x;
                    else { Console.WriteLine("Значение недопустимо"); continue; };
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка формата ввода");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static T ConvertStringTo<T>(string str)
        {
            try
            {
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    return (T)converter.ConvertFrom(str);
                }
            }
            catch (NotSupportedException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
            return default(T);
        }

        public static void PressAnyKey()
        {
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
