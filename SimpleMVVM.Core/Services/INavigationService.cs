using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Services
{
    public interface INavigationService
    {
        Task NavigateToViewModelAsync<T>(object param = null, bool isModal = false, bool isAnimated = true);

        Task NavigateToPageAsync(Page page);

        Task GoBackAsync(bool isModal = false);

        INavigation Navigation { get; set; }
    }
}
