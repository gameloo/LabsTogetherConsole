using ConsoleLab7Semester.src.Lab10_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src
{
    public class Lab10
    {
        public static void RunTask()
        {
            PrintType(new MyClass().GetType());
            PrintType(new ChildMyClass().GetType());
            HelperClass.PressAnyKey();

        }

        private static void PrintType(Type type)
        {
            Console.WriteLine("\nКласс: " + type.Name);

            Console.WriteLine("Методы:");
            foreach (MethodInfo method in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual ";
                Console.Write(modificator + method.ReturnType.Name + " " + method.Name + " (");
                //получаем все параметры
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }

            Console.WriteLine("Поля:");
            foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                Console.WriteLine("{0} {1}", field.FieldType, field.Name);
            }
        }


    }
}
