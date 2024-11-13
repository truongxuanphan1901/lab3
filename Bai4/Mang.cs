using NUnit.Framework;
using System;

namespace Bai4
{
    internal class Mang
    {
        static void Main(string[] args)
        {
        }

        public static int TinhMang(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Chỉ mục nằm ngoài phạm vi của mảng");
            }
            return array[index];
        }

        [Test]
        public void TinhMang_Test1()
        {
            var array = new int[] { 1, 2, 3 };
            Assert.Throws<IndexOutOfRangeException>(() => TinhMang(array, -1), "Chỉ mục nằm ngoài phạm vi của mảng");
            Assert.Throws<IndexOutOfRangeException>(() => TinhMang(array, 3), "Chỉ mục nằm ngoài phạm vi của mảng");
        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3 }, 1, 2)]
        [TestCase(new int[] { 1, 2, 3 }, 2, 3)]
        [TestCase(new int[] { 10, 20, 30, 40 }, 3, 40)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, -5)]
        [TestCase(new int[] { 5 }, 0, 5)]
        [TestCase(new int[] { 100, 200, 300, 400, 500 }, 2, 300)]
        [TestCase(new int[] { 9, 8, 7, 6, 5 }, 3, 6)]
        public void TinhMang_Test2(int[] array, int index, int expected)
        {
            var result = TinhMang(array, index);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2, 3 }, -1)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 10, 20, 30 }, 5)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 5 }, -2)]
        public void TinhMang_Test3(int[] array, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => TinhMang(array, index), "Chỉ mục nằm ngoài phạm vi của mảng");
        }
    }
}
