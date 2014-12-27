using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace MvvmLight_Sample.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new MvvmLight_Sample.App());
        }
    }
}
