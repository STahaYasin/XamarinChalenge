using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Taha : ContentPage
    {
        public Character ch;
        public Taha(Character _ch)
        {
            InitializeComponent();
            BindingContext = this.ch = _ch;
            Title = _ch.Name;
        }
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
