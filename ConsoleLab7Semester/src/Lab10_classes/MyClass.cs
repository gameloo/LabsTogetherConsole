using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src.Lab10_classes
{
    public class MyClass
    {
        private int privateField;
        public int publicField;
        protected int protectedField;
        internal int internalField;

        private void PrivateMethod()
        {
            privateField = 1;
        }

        public virtual int PublicMethod()
        {
            return 1;
        } 

    }
}
