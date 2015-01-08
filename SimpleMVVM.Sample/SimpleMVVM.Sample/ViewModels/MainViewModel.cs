using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using SimpleMVVM.Core.ViewModels;

namespace SimpleMVVM.Sample.ViewModels
{
    [ImplementPropertyChanged]
    public class MainViewModel: ViewModel
    {
        public string MainText { get; set; }
        public override void OnAppearing()
        {
            MainText = "Hello world!";
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
                        await NavigationService.NavigateToViewModelAsync<DetailViewModel>("Parameter");
                    });
                }

                return _goToDetailPageCommand;
            }
        }
    }
}
