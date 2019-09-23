using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using DDD.WinForm.ViewModels;
using Moq;
using NUnit.Framework;

namespace DDDTest.Tests
{
    public class MeasureViewModelTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void 計測_シナリオ()
        {
            var sensorMock = new Mock<ISensorRepository>();
            var viewModel = new MeasureViewModel(sensorMock.Object);
            Assert.AreEqual("--", viewModel.MeasureValue);

            sensorMock.Setup(x => x.GetData()).Returns(new MeasureValue(1.23456f));
            viewModel.Measure();
            Assert.AreEqual("1.23m/s", viewModel.MeasureValue);

            sensorMock.Setup(x => x.GetData()).Returns(new MeasureValue(2.2f));
            viewModel.Measure();
            Assert.AreEqual("2.2m/s", viewModel.MeasureValue);
        }
    }
}