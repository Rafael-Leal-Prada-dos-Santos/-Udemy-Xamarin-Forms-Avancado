﻿using Prism.Ioc;
using Prism;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App14_LoginSocialOAuth.Views;
using App14_LoginSocialOAuth.ViewModels;

namespace App14_LoginSocialOAuth
{
    public partial class App : PrismApplication
    {
        public static void NavegarParaInicial(params string[] parametros) 
        {
            App.Current.MainPage = new PaginaInicio(parametros);
        }

        public App(IPlatformInitializer inicializador = null) : base(inicializador)
        {

        }

        protected override void OnInitialized()
        {
            //Qual a primeira página
            InitializeComponent();

            NavigationService.NavigateAsync($"{nameof(PaginaInicial)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //Registrar todas  as views
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<PaginaInicial, PaginaInicialViewModel>();
            containerRegistry.RegisterForNavigation<PaginaInicio, PaginaInicioViewModel>();
        }


    }
}
