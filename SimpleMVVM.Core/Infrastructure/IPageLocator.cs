using System;
using SimpleMVVM.Core.ViewModels;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Infrastructure
{
    public interface IPageLocator
    {
        Page ResolvePageAndViewModel(Type viewModelType, object args = null);
        Page ResolvePage(IViewModel viewModel);
    }
}
