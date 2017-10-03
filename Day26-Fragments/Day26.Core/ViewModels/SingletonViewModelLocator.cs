using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Day26.Core.ViewModels
{
    public class SingletonViewModelLocator : MvxDefaultViewModelLocator
    {
        public SingletonViewModelLocator()
        {
            Mvx.LazyConstructAndRegisterSingleton(()=> (FirstViewModel)Mvx.IocConstruct(typeof(FirstViewModel)));
            Mvx.LazyConstructAndRegisterSingleton(()=> (SecondViewModel)Mvx.IocConstruct(typeof(SecondViewModel)));

        }

        public override IMvxViewModel Load(Type viewModelType, IMvxBundle parameterValues, IMvxBundle savedState)
        {
            if (Mvx.CanResolve(viewModelType))
            {
                return (IMvxViewModel)Mvx.Resolve(viewModelType);
            }

            return base.Load(viewModelType, parameterValues, savedState);
        }
    }
}
