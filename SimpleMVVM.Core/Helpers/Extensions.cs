using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleMVVM.Core.ViewModels;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Helpers
{
    public static class Extensions
    {
        public static void BindViewModel(this Page page, IViewModel viewModel)
        {
            page.BindingContext = viewModel;

            page.Appearing += (sender, args1) => viewModel.OnAppearing();
            page.Disappearing += (sender, args1) => viewModel.OnDisappearing();
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list)
        {
            ObservableCollection<T> collection = new ObservableCollection<T>(list);
            return collection;
        }
    }
}
