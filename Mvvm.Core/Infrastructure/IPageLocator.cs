using System;
using Mvvm.Core.ViewModels;
using Xamarin.Forms;

namespace Mvvm.Core.Infrastructure
{
    public interface IPageLocator
    {
        Page ResolvePageAndViewModel(Type viewModelType, object args = null);
        Page ResolvePage(IViewModel viewModel);
    }
}
