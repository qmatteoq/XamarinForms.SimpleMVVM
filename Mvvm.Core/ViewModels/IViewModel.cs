namespace Mvvm.Core.ViewModels
{
    public interface IViewModel
    {
        void Init(object args);
        void OnAppearing();
        void OnDisappearing();
    }
}
