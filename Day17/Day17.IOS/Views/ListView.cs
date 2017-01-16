using Day17.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using ObjCRuntime;
using UIKit;

namespace Day17.IOS.Views
{
    public class ListView : MvxTableViewController
    {
        

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
                EdgesForExtendedLayout = UIRectEdge.None;

            var source = new MvxStandardTableViewSource(TableView, "TitleText Caption;ImageUrl ImagePath");
            TableView.Source = source;

            var set = this.CreateBindingSet<ListView, ListViewModel>();
            set.Bind(source).To(vm => vm.Items);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.ShowDetailCommand);
            set.Apply();

            TableView.ReloadData();
        }
    }
}