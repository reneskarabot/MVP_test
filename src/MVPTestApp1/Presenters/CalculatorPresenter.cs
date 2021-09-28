using MVPTestApp1.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTestApp1.Presenters
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        public CalculatorPresenter(ICalculatorView view)
        {
            _view = view;

        }
    }
}
