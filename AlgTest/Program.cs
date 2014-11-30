using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alghoritms.Array;

namespace AlgTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 2, 6, 4, 2, 5, 1, 0, 5, -4, -2, 5, 0, 3 };

            ArrayOperations.MergeSort(array);

           // foreach (var i in array) Console.Write(i + " ");
        }
    }
}
