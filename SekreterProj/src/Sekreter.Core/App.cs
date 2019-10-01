using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Sekreter.Core.ViewModels.Home;

namespace Sekreter.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
