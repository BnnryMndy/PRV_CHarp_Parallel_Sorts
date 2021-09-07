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
        private Gnome() { }

        public static Gnome GetInstance()
        {
            if (instance == null) instance = new Gnome();
            return instance;
        }

        public void Sort(int[] inputArray)
        {
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
        }

        private void swap(ref int first, ref int second)
        {
            int temp = second;
            second = first;
            first = temp;
        }
    }
}
