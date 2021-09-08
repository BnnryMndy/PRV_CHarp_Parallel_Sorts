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
        private int[] inputArray;
        public bool isFinished = false;

        private QuickSort() { }

        public static QuickSort GetInstance()
        {
            if (instance == null) instance = new QuickSort();

            return instance;
        }

        public void SetArray(int[] inputArray)
        {
            this.inputArray = new int[inputArray.Length];
            inputArray.CopyTo(this.inputArray, 0);
        }

        public void Sort()
        {
            isFinished = false;
            quickSort(inputArray, 0, inputArray.Length-1);
            isFinished = true;
        }

        private void quickSort(int[] inputArray, int low, int high)
        {
            if (low < high)
            {
                int pivot = partition(inputArray, low, high);

                if (pivot > 1)
                {
                    quickSort(inputArray, low, pivot - 1);
                }
                if (pivot + 1 < high)
                {
                    quickSort(inputArray, pivot + 1, high);
                }
            }
        }

        private int partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            //int pav = arr[(left + right) / 2];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
