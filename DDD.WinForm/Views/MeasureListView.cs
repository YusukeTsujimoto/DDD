using Ddd.WinForm.ViewModels;
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
    public partial class MeasureListView : BaseForm
    {
        public MeasureListView()
        {
            InitializeComponent();

            var viewModel = new MeasureListViewModel();
            MeasureDataGrid.DataBindings.Add(new Binding("DataSource", viewModel, nameof(viewModel.Measures)));
        }
    }
}
