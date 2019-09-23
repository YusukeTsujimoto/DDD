using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Tests
{
    public class LatestViewModelTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void 直近値_シナリオ()
        {
            var measureMock = new Mock<IMeasureRepository>();
            var measure = new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f);
            measureMock.Setup(x => x.GetLatest()).Returns(measure);

            var viewModel = new LatestViewModel(measureMock.Object);
            Assert.AreEqual("2017/01/01 13:00:00", viewModel.MeasureDate);
            Assert.AreEqual("1.23m/s", viewModel.MeasureValue);
        }
    }
}
