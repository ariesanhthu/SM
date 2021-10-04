using SM.Models;
using System.Collections.ObjectModel;
namespace SM.ViewModels
{
    public class GvMainViewModel
    {
        public ObservableCollection<ClassInfoGroup> ClassInfos { get; private set; }
        public GvMainViewModel()
        {
            CreateClassInfoCollection();
        }
        public void CreateClassInfoCollection()
        {
            ClassInfos = new ObservableCollection<ClassInfoGroup>
            {
                new ClassInfoGroup("Monday", new ObservableCollection<ClassInfo>
                {
                    new ClassInfo
                    {
                        GvName = "Phan Thành Tâm",
                        ClassName = "10TT",
                        ClassLesson = "Bài 1: Tìm Kiếm Và Sắp Xếp",
                        ClassRoom = "Phòng TH4",
                        TimeStart = "6:45",
                        TimeEnd = "7:30"
                    },
                    new ClassInfo
                    {
                        GvName = "Phan Thành Tâm",
                        ClassName = "10TT",
                        ClassLesson = "Luyện Tập",
                        ClassRoom = "Phòng TH4",
                        TimeStart = "7:35",
                        TimeEnd = "8:20"
                    },
                })
            };
        }
    }
}
