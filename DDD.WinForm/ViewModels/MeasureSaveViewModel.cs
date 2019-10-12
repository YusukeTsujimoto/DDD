using Ddd.Domain.Entities;
using Ddd.Domain.Repositories;
using Ddd.Infrastructure;
using Ddd.Domain.Helpers;
using System;

namespace Ddd.WinForm.ViewModels
{
    public class MeasureSaveViewModel : ViewModelBase
    {
        private readonly IMeasureRepository _measureRepository;
        private DateTime _measureDate;
        private string _measureValue = "";

        public MeasureSaveViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
            _measureDate = GetDateTime();
        }

        public MeasureSaveViewModel() : this(Factories.CreateMeasureRepository())
        {
        }

        public virtual DateTime MeasureDate
        {
            get => _measureDate;
            set => SetProperty(ref _measureDate, value);
        }

        public virtual DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public virtual string MeasureValue
        {
            get => _measureValue;
            set => SetProperty(ref _measureValue, value);
        }

        public void Save()
        {
            Guard.IsNullOrEmptyMessage(MeasureValue, "計測値を入力してください");

            var measureValue = Convert.ToSingle(MeasureValue);
            var entity = new MeasureEntity(
                Guid.NewGuid().ToString(),
                MeasureDate,
                measureValue);

            _measureRepository.Save(entity);
        }

        public string UnitLabel => Domain.ValueObjects.MeasureValue.UnitName;
    }
}
