using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App04_CustomControl.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeuControlePersonalizado : ContentView
    {
        public event EventHandler Tocado;

        /**
         * PropertyName -> nome da propriedade que o bindable vai alterar
         * returnType -> qual o tipo de dado que vai retornar
         * declaringType -> Objeto que contém a bindable
         * defaultValue -> Valor padrão
         * defaultBindingMode -> Tipo de vínculo da propriedade
         
         */
        public static readonly BindableProperty TituloProperty =
            BindableProperty.Create
            (
                propertyName: nameof(Titulo),
                returnType: typeof(string),
                declaringType: typeof(MeuControlePersonalizado),
                defaultValue: "",
                defaultBindingMode : BindingMode.TwoWay,
                propertyChanged: TituloPropertyModificado
            );

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        private static void TituloPropertyModificado(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MeuControlePersonalizado meuControle) 
            {
                meuControle.titulo.Text = (string)newValue;
            }
        }


        public static readonly BindableProperty TituloCorProperty =
           BindableProperty.Create
           (
               propertyName: nameof(TituloCor),
               returnType: typeof(Color),
               declaringType: typeof(MeuControlePersonalizado),
               defaultValue: Color.Black,
               defaultBindingMode: BindingMode.TwoWay,
               propertyChanged: TituloCorModificado
           );

        public Color TituloCor
        {
            get { return (Color)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        private static void TituloCorModificado(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MeuControlePersonalizado meuControle)
            {
                meuControle.titulo.TextColor = (Color)newValue;
            }
        }

        public static readonly BindableProperty ImagemProperty =
          BindableProperty.Create
          (
              propertyName: nameof(Imagem),
              returnType: typeof(string),
              declaringType: typeof(MeuControlePersonalizado),
              defaultValue: "",
              defaultBindingMode: BindingMode.TwoWay,
              propertyChanged: ImagemModificado
          );

        public string Imagem
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        private static void ImagemModificado(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is MeuControlePersonalizado meuControle)
            {
                meuControle.imagem.Source = ImageSource.FromFile((string)newValue);
            }
        }



        public MeuControlePersonalizado()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Tocado != null) 
            {
                Tocado(sender, e);
            }
        }
    }
}