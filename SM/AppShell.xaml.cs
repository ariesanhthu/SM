using SM.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace SM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MorePage), typeof(MorePage));
            Routing.RegisterRoute(nameof(RankingPage), typeof(RankingPage));
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
            Routing.RegisterRoute(nameof(GvMainPage), typeof(GvMainPage));
            
            /*ROUTE SỔ ĐẦU BÀI SoDauBaiPage tạm ở trang TabBar*/
            Routing.RegisterRoute(nameof(SDBEditPage), typeof(SDBEditPage));
            Routing.RegisterRoute(nameof(SDBViPhamPage), typeof(SDBViPhamPage));
            Routing.RegisterRoute(nameof(SDBAbsentPage), typeof(SDBAbsentPage));

            /*ROUTE SỔ ĐẦU BÀI Setting*/
            Routing.RegisterRoute(nameof(SettingPage), typeof(SettingPage));
            Routing.RegisterRoute(nameof(SettingInfoPage), typeof(SettingInfoPage));

            /*ROUTE AdminPage*/
            Routing.RegisterRoute(nameof(AdminLopTrucPage), typeof(AdminLopTrucPage));
        }
    }
}