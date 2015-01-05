using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<T>(object param = null);

        Task NavigateToPageAsync(Page page);

        Task GoBackAsync();

        INavigation Navigation { get; set; }
    }
}
