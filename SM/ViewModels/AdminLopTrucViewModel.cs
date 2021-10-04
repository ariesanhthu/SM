using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using SM.Models;
namespace SM.ViewModels
{
    public class AdminLopTrucViewModel
    {
        public ObservableCollection<VPClassGroup> VPClasses { get; set; }
        public AdminLopTrucViewModel()
        {
            CreateVPClassCollection();
        }
        public void CreateVPClassCollection()
        {
            VPClasses = new ObservableCollection<VPClassGroup>
            {
                new VPClassGroup("10TT", new ObservableCollection<VPGroup>
                {
                    new VPGroup(new ViPham{ ViPhamName = "Đi trễ", DiemTru = -39 },
                                new ObservableCollection<VPHSName>
                                {
                                    new VPHSName{HSName = "Giang"},
                                    new VPHSName{HSName ="Đức"}
                                }),
                    new VPGroup( new ViPham{ViPhamName = "Không lau cửa lá nhôm", DiemTru = -200 },
                                new ObservableCollection<VPHSName>{}),
                }),
                new VPClassGroup("10L", new ObservableCollection<VPGroup>
                {
                    new VPGroup(new ViPham{ViPhamName = "Đi trễ", DiemTru = -39 },
                                new ObservableCollection<VPHSName>
                                {
                                    new VPHSName{HSName = "Giang"},
                                    new VPHSName{HSName ="Đức"}
                                }),
                    new VPGroup( new ViPham{ViPhamName = "Không lau cửa lá nhôm", DiemTru = -200 },
                                new ObservableCollection<VPHSName>
                                {}),
                }),
            };
        }
    }
}