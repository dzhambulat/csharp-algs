using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghoritms.DataStructures.Heaps
{
    public class AscendingHeap<T> where T:IComparable
    {
        List<T> _elements = null;

        private void SwapElements(int i,int j)
        {
            var c = _elements[i];
            _elements[i] = _elements[j];
            _elements[j] = c;
        }

        public AscendingHeap(List<T> array)
        {
            _elements = array.ToList(); // copy array elements


            int len = _elements.Count;
            for (int l=len/2-1;l>=0;l--)
            {
                MinHeapify(l);
            }
        }

        private void MinHeapify(int index)
        {

            int lchild = (index + 1) * 2-1;
            int rchild = (index + 1) * 2;
            int len = _elements.Count;
            int pI = index;
            while (lchild < len)
            {

                int minI = lchild;
                if (rchild < len)
                {
                    if (_elements[lchild].CompareTo(_elements[rchild]) > 0)
                        minI = rchild;
                }

                if (_elements[pI].CompareTo(_elements[minI]) > 0)
                    SwapElements(pI, minI);
                else break;


                pI = minI;
                lchild = (pI + 1) * 2 - 1;
                rchild = (pI + 1) * 2; // +1 -1


            }
        }
        public T GetMin()
        {
            T res = _elements[0];

            int lastIndex = _elements.Count - 1;
            _elements[0] = _elements[lastIndex];
            _elements.RemoveAt(lastIndex);

            int lchild = 1;
            int rchild = 2;
            int len=_elements.Count;
            int pI=0;
            while (lchild<len)
            {

                int minI = lchild;
                if (rchild < len)
                {
                    if (_elements[lchild].CompareTo(_elements[rchild]) > 0)
                        minI = rchild;
                }

                if (_elements[pI].CompareTo(_elements[minI]) > 0)
                    SwapElements(pI, minI);
                else break;

                lchild = (pI + 1) * 2-1; 
                rchild = (pI + 1) * 2; // +1 -1

                pI = minI;

            }

            return res;
        }
    }
}
