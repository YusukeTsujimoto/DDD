using Ddd.Domain.ValueObjects;
using NUnit.Framework;

namespace DDDTest.Tests
{
    class MeasureValueTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void イコールテスト()
        {
            var vo1 = new MeasureValue(1.23456f);
            var vo2 = new MeasureValue(1.23456f);

            Assert.IsTrue(vo1.Equals(vo2));
        }

        [Test]
        public void イコールイコールテスト()
        {
            var vo1 = new MeasureValue(1.23456f);
            var vo2 = new MeasureValue(1.23456f);

            Assert.IsTrue(vo1 == vo2);
        }
    }
}
