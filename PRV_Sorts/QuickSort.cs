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
        public delegate void Progress(int x);
        public Progress progress;

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
            progress(0);
            isFinished = false;
            quickSort(inputArray, 0, inputArray.Length-1);
            isFinished = true;
            progress(100);
        }

        private void quickSort(int[] inputArray, int low, int high)
        {
            //progress(Math.Abs(arr.Length - (left + right)) / 100);
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
            //progress((low + high) / inputArray.Length);
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
