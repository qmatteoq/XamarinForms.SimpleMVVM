using SimpleMVVM.Core.Services;

namespace SimpleMVVM.Core.ViewModels
{
    public interface IViewModel
    {
        void OnInit(object args);
        
        void OnAppearing();
        
        void OnDisappearing();

        INavigationService NavigationService { get; set; }
    }
}
