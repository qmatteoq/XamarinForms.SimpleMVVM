using GalaSoft.MvvmLight.Command;
using SimpleMVVM.Core.ViewModels;

namespace SimpleMVVM.Sample.ViewModels
{
    public class MainViewModel: ViewModel
    {
        private string _mainText;

        public string MainText
        {
            get { return _mainText; }
            set
            {
                _mainText = value;
                RaisePropertyChanged();
            }
        }
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
