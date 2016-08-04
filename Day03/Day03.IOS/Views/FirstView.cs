using Day02.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;

namespace Day03.IOS.Views
{
    public class FirstView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new MvxSimpleTableViewSource(TableView, KittenCell.Key, KittenCell.Key);
            TableView.RowHeight = 100;
            TableView.Source = source;

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(source).To(vm => vm.Kittens);
            set.Apply();

            TableView.ReloadData();
        }
    }
}