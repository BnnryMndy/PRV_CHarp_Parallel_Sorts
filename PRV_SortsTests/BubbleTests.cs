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
        int[] sortedArray = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        //act
        [TestMethod()]
        public void GetInstanceTest()
        {
            Bubble bubble = Bubble.GetInstance();
            
            //assert
            Assert.IsTrue(bubble != null);
        }

        [TestMethod()]
        public void SortTest()
        {
            //assert
            Assert.Fail();
        }

        [TestMethod()]
        public void OptimizedSortTest()
        {
            //assert
            Assert.Fail();
        }
    }
}