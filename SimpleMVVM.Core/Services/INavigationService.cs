using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Services
{
    public interface INavigationService
    {
        Task NavigateTo<T>(object param = null);

        Task GoBack();

        INavigation Navigation { get; set; }
    }
}
