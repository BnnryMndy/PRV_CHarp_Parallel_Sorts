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
        public delegate void Progress(int x);
        public Progress progress;

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
            progress(0);
            int step = inputArray.Length / 100;
            int currStep = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                currStep++;
                if (inputArray[i] > inputArray[i + 1])
                {
                    int tmp = inputArray[i + 1];
                    inputArray[i + 1] = inputArray[i];
                    inputArray[i] = tmp;
                }
                if (currStep > step)
                {
                    progress(i * 100 / inputArray.Length);
                    currStep = 0;
                } 

            }
            progress(100);

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
