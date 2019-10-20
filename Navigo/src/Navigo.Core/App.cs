using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Navigo.Core.ViewModels;
using Navigo.Core.ViewModels.Home;

namespace Navigo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
