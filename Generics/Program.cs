using Generics.Assignment_01;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region ArrayUtils Method
            int[] arr = { 1, 2, 3, 5, 3, 6, 9, 8 };

            ArrayUtils.ReverseArray(arr);

            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);

            #endregion





        }
    }
}
