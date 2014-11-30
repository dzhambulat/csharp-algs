using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghoritms.Array
{
    public class ArrayOperations
    {
        public static void SwapElements<T>(T[] array,int i,int j)
        {
            T elem = array[i];
            array[i] = array[j];
            array[j] = elem;
        }
        public static void MergeSort<T>(T[] array) where T:IComparable
        {
            T[] tempArray = new T[array.Length];
            int l=0,r=0,i=0;

            int srcLen=array.Length;

            int h = (int)Math.Ceiling(Math.Log(srcLen, 2)) - 1;
            for(int subArrayLen=1;subArrayLen<=Math.Pow(2,3);subArrayLen*=2)
            {
                i = 0;
                for(int left=0;left<srcLen;left+=2*subArrayLen)
                {
                    l = left;
                    r = left+subArrayLen;
                    if (r >= srcLen) continue;
                    int rend = 0;
                    rend=r + subArrayLen;
                    if (rend > srcLen) rend = srcLen;
                    while (l<left+subArrayLen && r<rend)
                    {
                        if (array[l].CompareTo(array[r]) < 0)
                        {
                            tempArray[i] = array[l];
                            l++;
                        }
                        else
                        {
                            tempArray[i] = array[r];
                            r++;
                        }

                        i++;
                    }
                    int j=l-left==subArrayLen?r:l;

                    while (i < rend)
                    {
                        tempArray[i] = array[j];
                        j++;
                        i++;
                    }
                    
                    

                }

                for (int j = 0; j < srcLen; j++)
                {
                    array[j] = tempArray[j];
                }

                foreach (var s in array) Console.Write(s + " ");
                Console.WriteLine();
            }
        }
    }
}
