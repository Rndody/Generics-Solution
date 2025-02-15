using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Assignment_01
{
    static class ArrayUtils
    {
        /* Generic method ReverseArray<T>(T[] array) that reverses the order of elements in an array.
          * Generic method FindMax<T>(T[] array)that finds the maximum element in an array.            */


        public static void ReverseArray<T>(T[] array)
        {
            T[] reversedArray = new T[array.Length];
                int index = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[index] = array[i];
                index++;
            }
            reversedArray.CopyTo(array, 0);
        }
        public static void FindMax<T>(T[] array)
        {

        }
    }
}
