using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using SimpleMVVM.Core.ViewModels;

namespace SimpleMVVM.Sample.ViewModels
{
    [ImplementPropertyChanged]
    public class DetailViewModel : ViewModel
    {
        public override void OnInit(object args)
        {
            MainText = args.ToString();
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
                        await NavigationService.GoBackAsync();
                    });
                }

                return _goBackCommand;
            }
        }

    }
}
