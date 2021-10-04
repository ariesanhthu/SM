using SM.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SDBEditPage : ContentPage
    {
        public SDBEditPage()
        {
            InitializeComponent();
            BindingContext = new SoDauBaiViewModel();
        }

        private async void Button_Absent_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(SDBAbsentPage)}");
        }
        private async void Button_VP_Clicked(object sender, EventArgs e)
        { 
            await Shell.Current.GoToAsync($"/{nameof(SDBViPhamPage)}");
        }

        private async void BtnAccept_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}