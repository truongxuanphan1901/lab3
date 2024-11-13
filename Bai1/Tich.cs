using NUnit.Framework;
using System;

namespace Bai1
{
    internal class Tich
    {
        static void Main(string[] args)
        {
        }

        public static int TinhTich(object a, object b)
        {
            if (!(a is int) || !(b is int))
            {
                throw new ArgumentException("Cả 2 số phải là số nguyên");
            }
            int Inta = (int)a;
            int Intb = (int)b;

            return Inta * Intb;
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, -1, 1)]
        [TestCase(10, 5, 50)]
        [TestCase(-10, 5, -50)]
        [TestCase(50001, 1, 50001)]
        [TestCase(-50001, 1, -50001)]
        public void TinhTich_Test(object a, object b, int expected)
        {
            var result = TinhTich(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        [TestCase("xyz", 1)]
        [TestCase(1, "xyz")]
        [TestCase("xyz", "xyz")]
        public void TinhTich_Test2(object a, object b)
        {
            Assert.Throws<ArgumentException>(() => TinhTich(a, b), "Cả hai số phải là số nguyên.");
        }
    }
}
