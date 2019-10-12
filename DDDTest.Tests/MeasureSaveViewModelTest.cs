using Ddd.Domain.Entities;
using Ddd.Domain.Repositories;
using Ddd.WinForm.ViewModels;
using Ddd.Domain.Exceptions;
using Moq;
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
            var measureMock = new Mock<IMeasureRepository>();
            var viewModelMock = new Mock<MeasureSaveViewModel>(measureMock.Object);
            viewModelMock.Setup(x => x.GetDateTime()).Returns("2017/01/03 13:00:00".ToDate());
            var viewModel = viewModelMock.Object;
            viewModelMock.SetupProperty(x => x.MeasureDate, viewModel.GetDateTime());
            viewModelMock.SetupProperty(x => x.MeasureValue, "");
            Assert.AreEqual("2017/01/03 13:00:00".ToDate(), viewModel.MeasureDate);
            Assert.AreEqual("", viewModel.MeasureValue);
            Assert.AreEqual("m/s", viewModel.UnitLabel);

            viewModelMock.SetupProperty(x => x.MeasureDate, "2017/01/03 12:50:00".ToDate());
            viewModelMock.SetupProperty(x => x.MeasureValue, "1.23456");
            measureMock.Setup(x => x.Save(It.IsAny<MeasureEntity>()))
                .Callback<MeasureEntity>(saveValue =>
                {
                    // Assert.AreEqual("?", saveValue.MeasureId);
                    Assert.AreEqual("2017/01/03 12:50:00".ToDate(), saveValue.MeasureDate.Value);
                    Assert.AreEqual(1.23456f, saveValue.MeasureValue.Value);
                });
            viewModel.Save();
            measureMock.VerifyAll();
        }

        [Test]
        public void 計測登録_シナリオ_エラーチェック()
        {
            var measureMock = new Mock<IMeasureRepository>();
            var viewModelMock = new Mock<MeasureSaveViewModel>(measureMock.Object);
            viewModelMock.Setup(x => x.GetDateTime()).Returns("2017/01/03 3:00:00".ToDate());
            var viewModel = viewModelMock.Object;

            var ex = Assert.Throws<MessageException>(() => viewModel.Save());
            Assert.AreEqual("計測値を入力してください", ex.Message);
        }
    }
}
