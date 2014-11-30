using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Alghoritms.Array;

namespace Alghoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 6,5, 3, 4 };

            ArrayOperations.MergeSort(a);

            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
