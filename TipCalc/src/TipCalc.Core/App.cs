using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;
using TipCalc.Core.ViewModels.Home;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            Mvx.IoCProvider.RegisterType<ICalculationService,CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
