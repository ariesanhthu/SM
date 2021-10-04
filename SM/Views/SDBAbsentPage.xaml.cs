using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SDBAbsentPage : ContentPage
    {
        public SDBAbsentPage()
        {
            InitializeComponent();
        }

        private async void BtnAccept_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}