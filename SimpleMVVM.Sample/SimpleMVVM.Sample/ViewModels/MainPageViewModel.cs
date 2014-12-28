using GalaSoft.MvvmLight.Command;
using Mvvm.Core.Services;
using Mvvm.Core.ViewModels;
using PropertyChanged;

namespace SimpleMVVM.Sample.ViewModels
{
    [ImplementPropertyChanged]
    public class MainPageViewModel: ViewModel
    {
        private readonly INavigationService _navigationService;
        public string MainText { get; set; }
        public override void OnAppearing()
        {
            MainText = "Hello world!";
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        private RelayCommand _goToDetailPageCommand;
        public RelayCommand GoToDetailPageCommand
        {
            get
            {
                if (_goToDetailPageCommand == null)
                {
                    _goToDetailPageCommand = new RelayCommand(async () =>
                    {
                        await _navigationService.NavigateTo<DetailViewModel>("Parameter");
                    });
                }

                return _goToDetailPageCommand;
            }
        }
    }
}
