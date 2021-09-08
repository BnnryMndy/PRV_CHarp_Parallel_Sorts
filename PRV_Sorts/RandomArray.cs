using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Sorts
{
    public class RandomArray
    {
        private int[] array;
        private Random random = new Random();

        public RandomArray(int size)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-15000, 15000);
            }
        }

        public int[] getArray() { return array; }

        public int[] GenerateNewArray(int size)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-15000, 15000);
            }

            return array;
        }
    }
}
