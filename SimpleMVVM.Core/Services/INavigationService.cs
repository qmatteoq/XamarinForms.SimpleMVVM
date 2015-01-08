using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Services
{
    public interface INavigationService
    {
        Task NavigateToViewModelAsync<T>(object param = null);

        Task NavigateToPageAsync(Page page);

        Task GoBackAsync();

        INavigation Navigation { get; set; }
    }
}
