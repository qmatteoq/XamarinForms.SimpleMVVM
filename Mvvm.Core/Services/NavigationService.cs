using Mvvm.Core.Infrastructure;
using Xamarin.Forms;

namespace Mvvm.Core.Services
{
    public class NavigationService: INavigationService
    {
        public INavigation Navigation { get; set; }

        public void NavigateTo<T>(object param = null)
        {
            IPageLocator pageLocator = new PageLocator();
            Page page = pageLocator.ResolvePageAndViewModel(typeof (T), param);
            Navigation.PushAsync(page);
        }
    }
}
