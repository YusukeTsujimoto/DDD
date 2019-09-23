using DDD.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    public partial class MeasureView : BaseForm
    {
        public MeasureView()
        {
            InitializeComponent();

            var viewModel = new MeasureViewModel();
            MeasureValueLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
            MeasureButton.Click += (sender, e) => viewModel.Measure();
        }
    }
}
