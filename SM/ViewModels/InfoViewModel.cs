using SM.Models;
using System.Collections.ObjectModel;
namespace SM.ViewModels
{
    public class InfoViewModel
    {
        public ObservableCollection<InfoGroup> Infos { get; private set; }
        public InfoViewModel()
        {
            CreateInfoGroup();
        }
        public void CreateInfoGroup()
        {
            Infos = new ObservableCollection<InfoGroup>
            {
                new InfoGroup("Giáo Viên", new ObservableCollection<Info>
                {
                    new Info
                    {
                        Name = "Phan Thành Tâm",
                        PhoneNumber = "0919027778",
                        Email = "abc@gmail.com",
                        Address = null
                    },
                    new Info
                    {
                        Name = "Nguyễn Hoàng Trọng Lộc",
                        PhoneNumber = "0123456789",
                        Email = "abc123@gmail.com",
                        Address = null
                    },
                })
            };
        }
    }
}
