using App08_MultiIdiomas.Traducao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App08_MultiIdiomas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DependencyService.Get<ILocale>().GetCurrentCultureInfo();

            //Lang.AppLang.Culture = new System.Globalization.CultureInfo("pt-PT");
            Lang.AppLang.Culture = DependencyService.Get<ILocale>().GetCurrentCultureInfo();
            LblMsg.Text = Lang.AppLang.MSG_01;
        }
    }
}
