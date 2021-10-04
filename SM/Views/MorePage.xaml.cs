using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MorePage : ContentPage
    {
        public MorePage()
        {
            InitializeComponent();
        }

        //Trang bảng xếp hạng
        private async void Button_BXH_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(RankingPage)}");
        }

        //Trang thông tin -> Sổ đầu bài, Thông tin GV, HS, Lớp
        private async void Button_Info_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(SoDauBaiPage)}");
        }

        //Trang cài đặt thông tin
        private async void Button_Setting_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(SettingPage)}");
        }

        private async void Button_LopTruc_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"/{nameof(AdminLopTrucPage)}");
        }
    }
}