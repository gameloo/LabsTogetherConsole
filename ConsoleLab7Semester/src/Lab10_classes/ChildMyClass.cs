using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src.Lab10_classes
{
    public class ChildMyClass : MyClass
    {
        private int newPrivateField;

        public ChildMyClass()
        {
            newPrivateField = 1;
        }

        public ChildMyClass(int i)
        {
            newPrivateField = i;
        }

        public override int PublicMethod()  // Переопределение
        {
            return newPrivateField;
        }

        public int PublicMethod(int i)      // Перегрузка
        {
            publicField = i;
            protectedField = ++i;
            internalField = i--;
            return i;
        }
    }
}
