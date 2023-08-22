using App12_FrameworkPrism.ViewModels;
using App12_FrameworkPrism.Views;
using App12_FrameworkPrism_2.Database;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12_FrameworkPrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer inicializador = null) : base(inicializador) 
        {

        }

        protected override void OnInitialized()
        {
            //Qual a primeira página
            InitializeComponent();

            MassaDados.CriarMassaDados();

            NavigationService.NavigateAsync($"NavigationPage/{nameof(ListaProfissionais)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //Registrar todas  as views
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ListaProfissionais, ListaProfissionaisViewModel>();
        }
    }
}
