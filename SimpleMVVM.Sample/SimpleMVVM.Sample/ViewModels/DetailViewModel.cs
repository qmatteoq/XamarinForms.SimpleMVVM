using GalaSoft.MvvmLight.Command;
using Mvvm.Core.Services;
using Mvvm.Core.ViewModels;
using PropertyChanged;

namespace SimpleMVVM.Sample.ViewModels
{
    [ImplementPropertyChanged]
    public class DetailViewModel : ViewModel
    {
        private readonly INavigationService _navigationService;

        public override void Init(object args)
        {
            MainText = args.ToString();
        }

        public DetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public string MainText { get; set; }

        private RelayCommand _goBackCommand;

        public RelayCommand GoBackCommand
        {
            get
            {
                if (_goBackCommand == null)
                {
                    _goBackCommand = new RelayCommand(async () =>
                    {
                        await _navigationService.GoBack();
                    });
                }

                return _goBackCommand;
            }
        }

    }
}
