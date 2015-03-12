using GalaSoft.MvvmLight.Command;
using SimpleMVVM.Core.ViewModels;

namespace SimpleMVVM.Sample.ViewModels
{
    public class DetailViewModel : ViewModel
    {
        public override void OnInit(object args)
        {
            MainText = args.ToString();
        }

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

        private RelayCommand _goBackCommand;

        public RelayCommand GoBackCommand
        {
            get
            {
                if (_goBackCommand == null)
                {
                    _goBackCommand = new RelayCommand(async () =>
                    {
                        await NavigationService.GoBackAsync();
                    });
                }

                return _goBackCommand;
            }
        }

    }
}
