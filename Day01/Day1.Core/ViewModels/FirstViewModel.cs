using Day1.Core.Services;
using MvvmCross.Core.ViewModels;

namespace Day1.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        private double _subTotal;
        private double _total;
        private double _generosity;
        private double _tip;

        public FirstViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
            _generosity = 20;
            _subTotal = 100;
            Recalc();
        }

        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                SetProperty(ref _subTotal, value); 
                Recalc();
            }
        }

        public double Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        public double Generosity
        {
            get { return _generosity; }
            set
            {
                SetProperty(ref _generosity, value);
                Recalc();
            }
        }

        public double Tip
        {
            get { return _tip; }
            set { SetProperty(ref _tip, value); }
        }

        private void Recalc()
        {
            Tip = _calculationService.Tip(SubTotal, Generosity);
            Total = SubTotal + Tip;
        }
    }
}
