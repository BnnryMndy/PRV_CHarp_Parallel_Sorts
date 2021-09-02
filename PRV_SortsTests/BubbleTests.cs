using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRV_Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Sorts.Tests
{
    [TestClass()]
    public class BubbleTests
    {
        //arrage
        int[] inputArray = new int[] { 1, 0, 2, 5, 4, 6, 7, 9, 8, 3};
        int[] trueArray = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        Bubble bubble = Bubble.GetInstance();

        //act
        [TestMethod()]
        public void GetInstanceTest()
        {
            //assert
            Assert.IsTrue(bubble != null);
        }

        [TestMethod()]
        public void SortTest()
        {
            int[] sortedArray = bubble.Sort(inputArray);
            //assert
            CollectionAssert.AreEqual(sortedArray, trueArray);
        }
    }
}