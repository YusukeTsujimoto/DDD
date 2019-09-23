using DDD.Domain.Repositories;
using DDD.Infrastructure;
using System;

namespace DDD.WinForm.ViewModels
{
    public class MeasureViewModel : ViewModelBase
    {
        private readonly ISensorRepository _sensorRepository;
        private string measureValue = "--";

        public MeasureViewModel() : this(Factories.CreateSensorRepository())
        {
        }

        public MeasureViewModel(ISensorRepository sensorRepository)
        {
            _sensorRepository = sensorRepository ?? throw new ArgumentNullException(nameof(sensorRepository));
        }

        public string MeasureValue
        {
            get => measureValue;
            set => SetProperty(ref measureValue, value);
        }

        public void Measure()
        {
            var measureValue = _sensorRepository.GetData();
            MeasureValue = measureValue.DisplayValue;
        }
    }
}
