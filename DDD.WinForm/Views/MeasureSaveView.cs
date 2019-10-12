using Ddd.WinForm.ViewModels;
using Ddd.WinForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddd.WinForm.Views
{
    public partial class MeasureSaveView : BaseForm
    {
        public MeasureSaveView()
        {
            InitializeComponent();

            var viewModel = new MeasureSaveViewModel();
            MeasureDateTextBox.DataBindings.Add("Value", viewModel, nameof(viewModel.MeasureDate));
            MeasureValueTextBox.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
            UnitLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.UnitLabel));
            SaveButton.Click += (sender, e) => viewModel.Save();
        }
    }
}
