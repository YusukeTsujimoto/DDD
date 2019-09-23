using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using DDD.WinForm.ViewModels;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace DDDTest.Tests
{
    public class MeasureListViewModelTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void 計測リスト_シナリオ()
        {
            var measureMock = new Mock<IMeasureRepository>();
            var measures = new List<MeasureEntity>
            {
                new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f),
                new MeasureEntity("guidB", "2017/01/01 12:00:00".ToDate(), 2.23456f),
            };
            measureMock.Setup(x => x.GetData()).Returns(measures);
            var viewModel = new MeasureListViewModel(measureMock.Object);
            Assert.AreEqual(2, viewModel.Measures.Count);
            Assert.AreEqual("2017/01/01 13:00:00", viewModel.Measures[0].MeasureDate);
            Assert.AreEqual("1.23m/s", viewModel.Measures[0].MeasureValue);
        }
    }
}