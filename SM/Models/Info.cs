using System.Collections.ObjectModel;

namespace SM.Models
{
    public class Info
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
    public class InfoGroup : ObservableCollection<Info>
    {
        public string TypeName { get; private set; }

        public InfoGroup(string typeName, ObservableCollection<Info> infos) : base(infos)
        {
            TypeName = typeName;
        }
    }

}
