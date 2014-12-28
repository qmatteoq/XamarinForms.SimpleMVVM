using GalaSoft.MvvmLight;

namespace SimpleMVVM.Core.ViewModels
{
    public abstract class ViewModel : ViewModelBase, IViewModel
    {
        public virtual void Init(object args)
        {
            
        }

        public virtual void OnAppearing()
        {

        }

        public virtual void OnDisappearing()
        {
            
        }
    }
}
