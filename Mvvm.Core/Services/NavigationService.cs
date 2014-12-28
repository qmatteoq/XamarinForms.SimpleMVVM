using System.Threading.Tasks;
using Mvvm.Core.Infrastructure;
using Xamarin.Forms;

namespace Mvvm.Core.Services
{
    public class NavigationService: INavigationService
    {
        public async Task GoBack()
        {
            await Navigation.PopAsync();
        }

        public INavigation Navigation { get; set; }

        public async Task NavigateTo<T>(object param = null)
        {
            IPageLocator pageLocator = new PageLocator();
            Page page = pageLocator.ResolvePageAndViewModel(typeof (T), param);
            await Navigation.PushAsync(page);
        }
    }
}
