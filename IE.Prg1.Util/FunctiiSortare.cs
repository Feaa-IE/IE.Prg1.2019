using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.Util
{
    public class FunctiiSortare
    {
        public static void InsertionSort(string[] toSort, bool desc)
        {
            for (int i = 1; i < toSort.Length; i++)
            {
                int j = i - 1;
                string temp = toSort[i];
                bool conditie;
                if (desc)
                {
                    conditie = toSort[j].CompareTo(temp) < 0;
                }
                else
                {
                    conditie = toSort[j].CompareTo(temp) > 0;
                }
                while (j >= 0 && conditie)
                {
                    toSort[j + 1] = toSort[j];
                    j--;
                }
                if (j != i - 1)
                {
                    toSort[j + 1] = temp;
                }
            }
        }
    }
}
