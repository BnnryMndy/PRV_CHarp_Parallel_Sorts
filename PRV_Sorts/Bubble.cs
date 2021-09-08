using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Sorts
{
    public class Bubble
    {
        private static Bubble instance;
        private int[] inputArray;
        public bool isFinished = false;

        private Bubble() { }

        public static Bubble GetInstance()
        {
            if(instance == null)
            {
                instance = new Bubble();
            }

            return instance;
        }

        public void SetArray(int[] inputArray)
        {
            this.inputArray = new int[inputArray.Length];
            inputArray.CopyTo(this.inputArray, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public void Sort()
        {
            isFinished = false;
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (!swapped)
                        swapped = SwapIfGreater(ref inputArray[i], ref inputArray[i + 1]);
                    else
                        SwapIfGreater(ref inputArray[i], ref inputArray[i + 1]);

                }
            } while (swapped);

            isFinished = true;
        }


        /// <summary>
        /// Меняет местами значения, если first больше second
        /// </summary>
        /// <param name="first">Первый элемент</param>
        /// <param name="second">Второй элемент</param>
        /// <returns>вернёт true, если поменял элементы местами</returns>
        private bool SwapIfGreater(ref int first, ref int second)
        {
            if(first > second)
            {
                int temp = second;
                second = first;
                first = temp;
                return true;
            }
            return false;
        }
    }
}
