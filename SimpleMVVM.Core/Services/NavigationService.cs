using System.Threading.Tasks;
using SimpleMVVM.Core.Infrastructure;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Services
{
    public class NavigationService: INavigationService
    {
        public async Task GoBackAsync()
        {
            await Navigation.PopAsync();
        }

        public INavigation Navigation { get; set; }

        public async Task NavigateToAsync<T>(object param = null)
        {
            IPageLocator pageLocator = new PageLocator();
            Page page = pageLocator.ResolvePageAndViewModel(typeof (T), param, this);
            await Navigation.PushAsync(page);
        }

      
        public async Task NavigateToPageAsync(Page page)
        {
            await Navigation.PushAsync(page);
        }
    }
}
