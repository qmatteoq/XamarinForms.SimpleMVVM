using System;
using SimpleMVVM.Core.Services;
using SimpleMVVM.Core.ViewModels;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Infrastructure
{
    public interface IPageLocator
    {
        NavigationPage ResolveNavigationPageAndViewModel(Type viewModelType, object args = null);
        NavigationPage ResolveNavigationPage(IViewModel viewModel);

        Page ResolvePageAndViewModel(Type viewModelType, object args, INavigationService navigationService);

        Page ResolvePage(IViewModel viewModel);
    }
}
