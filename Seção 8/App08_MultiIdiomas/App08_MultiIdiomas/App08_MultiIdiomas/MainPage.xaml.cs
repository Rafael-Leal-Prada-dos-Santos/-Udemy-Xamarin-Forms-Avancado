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

            Lang.AppLang.Culture = new System.Globalization.CultureInfo("pt-PT");
            LblMsg.Text = Lang.AppLang.MSG_01;
        }
    }
}
