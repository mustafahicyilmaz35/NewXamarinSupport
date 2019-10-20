using ContactCross.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using ContactCross.Core.ViewModels.Home;

namespace ContactCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ContactListViewModel>();
        }
    }
}
