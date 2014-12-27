using Xamarin.Forms;

namespace Mvvm.Core.Services
{
    public interface INavigationService
    {
        void NavigateTo<T>(object param = null);

        INavigation Navigation { get; set; }
    }
}
