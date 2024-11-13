using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class TBC
    {
        static void Main(string[] args)
        {

        }
        public static double TinhTBC(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("Danh sách không được để trống");
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }
        [Test]
        public void TinhTBC_DanhSachRong()
        {
            var emptyList = new List<int>();
            Assert.Throws<ArithmeticException>(() => TBC.TinhTBC(emptyList), "Danh sách không được để trống");
        }

        [TestCase(new int[] { 10 }, ExpectedResult = 10.0)]
        [TestCase(new int[] { 4, 6 }, ExpectedResult = 5.0)]
        [TestCase(new int[] { -4, -6 }, ExpectedResult = -5.0)]
        [TestCase(new int[] { -5, 10, -3, 8 }, ExpectedResult = 2.5)]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = 0.0)]
        [TestCase(new int[] { 1000000, 2000000, 3000000 }, ExpectedResult = 2000000.0)]
        [TestCase(new int[] { 7, 7, 7, 7, 7 }, ExpectedResult = 7.0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 3.0)]
        [TestCase(new int[] { 2, 4, 6, 8 }, ExpectedResult = 5.0)]
        public double TinhTBC_Test(int[] numbers)
        {
            return TBC.TinhTBC(new List<int>(numbers));
        }
    }
}
