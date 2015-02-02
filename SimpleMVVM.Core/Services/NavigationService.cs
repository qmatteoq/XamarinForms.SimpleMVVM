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

        public async Task NavigateToViewModelAsync<T>(object param = null, bool isModal = false, bool isAnimated = true)
        {
            IPageLocator pageLocator = new PageLocator();
            Page page = pageLocator.ResolvePageAndViewModel(typeof (T), param, this);
            if (isModal)
            {
                await Navigation.PushModalAsync(page, isAnimated);
            }
            else
            {
                await Navigation.PushAsync(page, isAnimated);
            }
            
        }
      
        public async Task NavigateToPageAsync(Page page)
        {
            await Navigation.PushAsync(page);
        }
    }
}
