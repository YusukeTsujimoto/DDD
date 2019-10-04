using DDD.WinForm.ViewModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Tests
{
    public class MeasureSaveViewModelTest
    {
        [Test]
        public void 計測登録_シナリオ()
        {
            var viewModel = new MeasureSaveViewModel();
            Assert.AreEqual("2017/01/03 13:00:00".ToDate(), viewModel.MeasureDate);
            Assert.AreEqual("", viewModel.MeasureValue);
            Assert.AreEqual("m/s", viewModel.UnitLabel);
        }
    }
}
