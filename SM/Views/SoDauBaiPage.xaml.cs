using SM.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SoDauBaiPage : ContentPage
    {
        public SoDauBaiPage()
        {
            InitializeComponent();
            BindingContext = new SoDauBaiViewModel();
        }

        private async void Button_edit_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(SDBEditPage)}");
        }
    }
}