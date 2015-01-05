using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SimpleMVVM.Core.Infrastructure;
using SimpleMVVM.Sample.ViewModels;
using Xamarin.Forms;

namespace SimpleMVVM.Sample
{
    public class App : Application
    {
        public App()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<DetailViewModel>();

            PageLocator locator = new PageLocator();
            NavigationPage page = locator.ResolveNavigationPageAndViewModel(typeof (MainViewModel), null);

            this.MainPage = page;
        }
    }
}
