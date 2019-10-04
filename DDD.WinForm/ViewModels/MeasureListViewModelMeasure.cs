using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class MeasureListViewModelMeasure
    {
        private MeasureEntity _entity;

        public MeasureListViewModelMeasure(MeasureEntity entity)
        {
            _entity = entity ?? throw new ArgumentNullException(nameof(entity));
        }

        public string MeasureDate => _entity.MeasureDate.DisplayValue;
        public string MeasureValue => _entity.MeasureValue.DisplayValue;
    }
}
