using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Mvvm.Core.Helpers;
using Mvvm.Core.Services;
using SimpleMVVM.Sample.ViewModels;
using SimpleMVVM.Sample.Views;
using Xamarin.Forms;

namespace SimpleMVVM.Sample
{
    public class App : Application
    {
        public App()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<DetailViewModel>();

            NavigationPage page = new NavigationPage(new MainPage());    
            INavigationService navigationService = new NavigationService();
            navigationService.Navigation = page.Navigation;

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);

            MainPageViewModel mainPageViewModel = ServiceLocator.Current.GetInstance<MainPageViewModel>();
            page.BindViewModel(mainPageViewModel);
            this.MainPage = page;
        }
    }
}
