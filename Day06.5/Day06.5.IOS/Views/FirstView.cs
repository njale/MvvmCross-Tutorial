using System.Drawing;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace Day065.IOS.Views
{
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView() { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

            var header = new UILabel(new RectangleF(10, 60, 300, 40)) { Text = "Header" };
            Add(header);

            var textField = new UITextField(new RectangleF(10, 100, 300, 40));
            Add(textField);

            var tableView = new UITableView(new RectangleF(0, 140, 320, 500), UITableViewStyle.Plain) {RowHeight = 88};
            var source = new MvxSimpleTableViewSource(tableView, BookCell.Key, BookCell.Key);
            tableView.Source = source;
            Add(tableView);

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(textField).To(vm => vm.SearchTerm);
            set.Bind(source).To(vm => vm.Results);
            set.Apply();

            tableView.ReloadData();
        }
    }
}
