using Generics.Assignment_01;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region ArrayUtils Method  "ReverseArray"
            int[] arr = { 99, 43, 1, 2, 3,444, 5, 3, 55, 6, 8, 11, 77,100,233,654 };

            //  ArrayUtils.ReverseArray(arr);

            // for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);

            #endregion


            ArrayUtils.FindMax(arr);



        }
    }
}
