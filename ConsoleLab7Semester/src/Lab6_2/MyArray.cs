using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7Semester.src.Lab6_2
{
    public class MyArray<T>
    {
        private T[][] array;

        public MyArray(int size)
        {
            array = new T[size][];
        }

        public void AddArray(int size)
        {
            for(int i = 0; i < GetSize(); i++)
            {
                if (array[i] == null) { array[i] = new T[size]; return; }
            }
            throw new IndexOutOfRangeException();
        }

        public T Get(int indexArray, int indexValue)
        {
            return array[indexArray][indexValue];
        }

        public void SetValue(int indexArray, int indexValue, T value)
        {
            array[indexArray][indexValue] = value;
        }

        public int GetSize()
        {
            return array.GetLength(0);
        }

        public int GetSize(int indexOfArray)
        {
            return array[indexOfArray].Length;
        }
    }
}
