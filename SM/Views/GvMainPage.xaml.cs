using SM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GvMainPage : ContentPage
    {
        public GvMainPage()
        {
            InitializeComponent();
            BindingContext = new GvMainViewModel();
        }
        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(RankingPage)}");
        }
    }
}