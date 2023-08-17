using App08_MultiIdiomas.Traducao;
using App08_MultiIdiomas.UWP.Traducao;
using System;
using System.Globalization;
using Xamarin.Forms;


[assembly: Dependency(typeof(Locale_UWP))]
namespace App08_MultiIdiomas.UWP.Traducao
{
    public class Locale_UWP : ILocale
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            return new System.Globalization.CultureInfo(
                Windows.System.UserProfile.GlobalizationPreferences.Languages[0].ToString());
        }

        public void SetLocale(System.Globalization.CultureInfo ci)
        {
            // Do nothing
        }
    }
}
