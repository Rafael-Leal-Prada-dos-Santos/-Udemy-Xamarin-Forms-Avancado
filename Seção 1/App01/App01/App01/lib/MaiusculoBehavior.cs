using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App01.lib
{
    public class MaiusculoBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += ColocarEmMaiusculo;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= ColocarEmMaiusculo;
        }

        private void ColocarEmMaiusculo(object sender, TextChangedEventArgs e)
        {
            Entry entry = (Entry)sender;

            if (!string.IsNullOrEmpty(e.NewTextValue)) 
            {
                entry.Text = e.NewTextValue.ToUpper();
            }
        }
    }
}
