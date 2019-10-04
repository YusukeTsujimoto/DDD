using DDD.Domain.Repositories;
using DDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class MeasureListViewModel : ViewModelBase
    {
        private readonly IMeasureRepository _measureRepository;

        public MeasureListViewModel() : this(Factories.CreateMeasureRepository())
        {
        }

        public MeasureListViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository ?? throw new ArgumentNullException(nameof(measureRepository));

            foreach (var entity in _measureRepository.GetData())
            {
                Measures.Add(new MeasureListViewModelMeasure(entity));
            }
        }

        public BindingList<MeasureListViewModelMeasure> Measures { get; set; }
            = new BindingList<MeasureListViewModelMeasure>();
    }
}
