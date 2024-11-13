using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class ChiaSN
    {
        static void Main(string[] args)
        {
        }
        public static int TinhChia(object a, object b)
        {

            if (!(a is int) || !(b is int))
            {
                throw new ArgumentException("Cả 2 số phải là số nguyên");
            }
            int Inta = (int)a;
            int Intb = (int)b;
            if (Intb == 0)
                throw new DivideByZeroException("Không thể chia cho 0");

            return Inta / Intb;
        }
        [Test]
        [TestCase("abc", 1)]
        [TestCase(1.5, 1)]
        [TestCase(1, "xyz")]
        public void TinhChia_Test1(object a, object b)
        {
            Assert.Throws<ArgumentException>(() => TinhChia(a, b), "Cả hai số phải là số nguyên.");
        }

        [Test]
        [TestCase(1, 0)]
        public void TinhChia_Test2(object a, object b)
        {
            Assert.Throws<DivideByZeroException>(() => TinhChia(a, b), "Không thể chia cho 0");
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(-10, 2, -5)]
        [TestCase(9, 3, 3)]
        [TestCase(9, 9, 1)]
        [TestCase(90, 3, 30)]
        [TestCase(0, 1, 0)]
        public void TinhChia_Test3(int a, int b, int expected)
        {
            var result = TinhChia(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
