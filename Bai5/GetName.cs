using NUnit.Framework;
using System;

namespace Bai5
{
    internal class GetName
    {
        static void Main(string[] args)
        {
        }

        public class HoSo
        {
            public string Ten { get; set; }
        }

        public class DichVu
        {
            public string GetName(HoSo profile)
            {
                if (profile == null)
                {
                    throw new NullReferenceException("Hồ sơ không tồn tại.");
                }
                return profile.Ten;
            }
        }

        [TestFixture]
        public class DichVuTests
        {
            private DichVu _dichVuService;

            [SetUp]
            public void Setup()
            {
                _dichVuService = new DichVu();
            }

            [Test]
            public void GetName_Test1()
            {
                HoSo profile = null;
                Assert.Throws<NullReferenceException>(() => _dichVuService.GetName(profile), "Hồ sơ không tồn tại.");
            }

            [TestCase("Phan Xuân Trường", "Phan Xuân Trường")]
            [TestCase("", "")]
            [TestCase(" ", " ")]
            [TestCase(null, null)] 
            public void GetName_Test2(string name, string expected)
            {
                var profile = new HoSo { Ten = name };
                var result = _dichVuService.GetName(profile);
                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void GetName_Test3()
            {
                var longName = new string('a', 1000); 
                var profile = new HoSo { Ten = longName };
                var result = _dichVuService.GetName(profile);
                Assert.That(result, Is.EqualTo(longName));
            }

            [Test]
            public void GetName_Test4()
            {
                var specialName = "@#$%^&*()!";
                var profile = new HoSo { Ten = specialName };
                var result = _dichVuService.GetName(profile);
                Assert.That(result, Is.EqualTo(specialName));
            }
        }
    }
}
