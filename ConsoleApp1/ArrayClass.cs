using System;

namespace ConsoleApp1
{
    class ArrayClass
    {
        public void Excercise1 ()
        {
            // Plain Array
            int[] array1 = new int[5];
            // 2 Dimensional Arrays
            int[,] array2 = new int[5, 2];
            int[] array3 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(array1.IsReadOnly);
        }
    }
}
