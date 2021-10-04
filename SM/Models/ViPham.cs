using System;
using System.Collections.ObjectModel;
using System.Text;

namespace SM.Models
{
    public class ViPham
    {
        public string ViPhamName { get; set; }
        public int DiemTru { get; set; }
    }
    public class VPHSName
    {
        public string HSName { get; set; }
    }
    public class VPGroup : ObservableCollection<VPHSName>
    {
        public ViPham Viphams { get; set; }
        public VPGroup(ViPham viphams, ObservableCollection<VPHSName> vphsnames) : base(vphsnames)
        {
            Viphams = viphams;
        }
    }
    public class VPClassGroup : ObservableCollection<VPGroup>
    {
        public string ClassName { get; set; }
        public VPClassGroup(string classname, ObservableCollection<VPGroup> vpgroups) : base(vpgroups)
        {
            ClassName = classname;
        }
    }
}

