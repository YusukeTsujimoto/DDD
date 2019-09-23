using DDD.Domain.Repositories;
using DDD.Infrastructure;
using System;

namespace DDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        private readonly IMeasureRepository _measureRepository;
        private string measureValue = "";
        private string measureDate = "";

        public LatestViewModel() : this(Factories.CreateMeasureRepository())
        {
        }

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository ?? throw new ArgumentNullException(nameof(measureRepository));

            var entity = _measureRepository.GetLatest();
            MeasureDate = entity.MeasureDate.DisplayValue;
            MeasureValue = entity.MeasureValue.DisplayValue;
        }

        public string MeasureValue
        {
            get => measureValue;
            set => SetProperty(ref measureValue, value);
        }
        public string MeasureDate
        {
            get => measureDate;
            set => SetProperty(ref measureDate, value);
        }
    }
}
