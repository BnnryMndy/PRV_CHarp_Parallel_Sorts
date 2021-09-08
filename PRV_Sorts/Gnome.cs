using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Sorts
{
    public class Gnome
    {
        private static Gnome instance;
        private int[] inputArray;
        public bool isFinished = false;

        private Gnome() { }


        public static Gnome GetInstance()
        {
            if (instance == null) instance = new Gnome();
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
            int i = 1;
            int j = 2;

            while (i< inputArray.Length)
            {
                if (inputArray[i] > inputArray[i - 1])
                {
                    i = j;
                    j++;
                }
                else
                {
                    swap(ref inputArray[i - 1], ref inputArray[i]);
                    i--;
                    if(i == 0)
                    {
                        i = j;
                        j++;
                    }

                }
            }

            isFinished = true;
        }

        private void swap(ref int first, ref int second)
        {
            int temp = second;
            second = first;
            first = temp;
        }
    }
}
