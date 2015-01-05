using System.Globalization;

namespace SimpleMVVM.Core.Localization
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
