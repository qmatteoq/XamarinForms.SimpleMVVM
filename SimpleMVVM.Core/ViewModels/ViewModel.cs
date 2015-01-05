using GalaSoft.MvvmLight;
using SimpleMVVM.Core.Services;

namespace SimpleMVVM.Core.ViewModels
{
    public abstract class ViewModel : ViewModelBase, IViewModel
    {
        public virtual void OnInit(object args)
        {
            
        }

        public virtual void OnAppearing()
        {

        }

        public virtual void OnDisappearing()
        {
            
        }

        public INavigationService NavigationService { get; set; }
    }
}
