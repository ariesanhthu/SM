using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SM.ViewModels;
namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminLopTrucPage : ContentPage
    {
        public AdminLopTrucPage()
        {
            InitializeComponent();
            BindingContext = new AdminLopTrucViewModel();
        }

        private async void BtnAccept_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}