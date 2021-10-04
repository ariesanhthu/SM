
using SM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RankingPage : ContentPage
    {
        public RankingPage()
        {
            InitializeComponent();
            BindingContext = new RakingViewModel();
        }
    }
}