
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SDBViPhamPage : ContentPage
    {
        public SDBViPhamPage()
        {
            InitializeComponent();
        }

        private async void BtnAccept_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}