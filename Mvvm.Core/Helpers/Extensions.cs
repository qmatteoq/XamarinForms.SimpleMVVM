using Mvvm.Core.ViewModels;
using Xamarin.Forms;

namespace Mvvm.Core.Helpers
{
    public static class Extensions
    {
        public static void BindViewModel(this Page page, IViewModel viewModel)
        {
            page.BindingContext = viewModel;

            page.Appearing += (sender, args1) => viewModel.OnAppearing();
            page.Disappearing += (sender, args1) => viewModel.OnDisappearing();
        }
    }
}
