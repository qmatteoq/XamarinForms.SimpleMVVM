using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace SimpleMVVM.Sample.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new Sample.App());
        }
    }
}
