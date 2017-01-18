using System.Collections.Generic;
using Day19.Core.Model;
using MvvmCross.Core.ViewModels;

namespace Day19.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private Shape _shape;
        private List<Shape> _list = new List<Shape> {Shape.Circle, Shape.Square, Shape.Triangle};

        public Shape Shape
        {
            get { return _shape; }
            set { SetProperty(ref _shape, value); }
        }

        public List<Shape> List
        {
            get { return _list; }
            set { SetProperty(ref _list, value); }
        }
    }

    
}
