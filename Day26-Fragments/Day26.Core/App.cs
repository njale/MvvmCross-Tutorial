using Day26.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace Day26.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<HomeViewModel>();
        }

        protected override IMvxViewModelLocator CreateDefaultViewModelLocator()
        {
            return new SingletonViewModelLocator();
        }
    }
}
