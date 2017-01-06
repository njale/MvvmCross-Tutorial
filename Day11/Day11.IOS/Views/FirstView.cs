using System.Drawing;
using Day11.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace Day11.IOS.Views
{
    public class FirstView : MvxCollectionViewController
    {
        private readonly bool _isInitialized;

        public FirstView() : base (new UICollectionViewFlowLayout
        {
            ItemSize = new SizeF(240,400),
            ScrollDirection = UICollectionViewScrollDirection.Horizontal
        })
        {
            _isInitialized = true;
            ViewDidLoad();
        }

        public sealed override void ViewDidLoad()
        {
            if (_isInitialized == false)
                return;

            base.ViewDidLoad();

            CollectionView.RegisterNibForCell(KittenCollectionCell.Nib, KittenCollectionCell.Key);

            var source = new MvxCollectionViewSource(CollectionView, KittenCollectionCell.Key);
            
            CollectionView.Source = source;
            
            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(source).To(vm => vm.Kittens);
            set.Apply();

            CollectionView.ReloadData();
        }
    }
}