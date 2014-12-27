using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Mvvm.Core.Helpers;
using Mvvm.Core.Services;
using MvvmLight_Sample.ViewModels;
using MvvmLight_Sample.Views;
using Xamarin.Forms;

namespace MvvmLight_Sample
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
