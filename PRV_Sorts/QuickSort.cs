using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Sorts
{
    public class QuickSort
    {
        private static QuickSort instance;

        private QuickSort() { }

        public static QuickSort GetInstance()
        {
            if (instance == null) instance = new QuickSort();

            return instance;
        }

        public void Sort(int[] inputArray)
        {

        }
    }
}
