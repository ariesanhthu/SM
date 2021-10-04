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
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private async void Button_SetInfo_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(SettingInfoPage)}");
        }
    }
}