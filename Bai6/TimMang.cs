using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class TimMang
    {
        static void Main(string[] args)
        {
            
        }

        public static int FindMin(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Mảng không có phần tử nào.");
            }

            int min = array[0]; 
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        
        [TestCase(new int[] { 3, 5, 7, 2, 8, -1, 4 }, ExpectedResult = -1)]
        public int Test1(int[] array)
        {
            return FindMin(array);
        }

        
        [Test]
        public void Test2()
        {
            Assert.Throws<ArgumentException>(() => FindMin(new int[] { }), "Mảng không có phần tử nào.");
        }

        
        [TestCase(new int[] { 5 }, ExpectedResult = 5)]
        public int Test3(int[] array)
        {
            return FindMin(array);
        }

        
        [TestCase(new int[] { -3, -5, -7, -2, -8, -1, -4 }, ExpectedResult = -8)]
        public int Test4(int[] array)
        {
            return FindMin(array);
        }
    }
}
