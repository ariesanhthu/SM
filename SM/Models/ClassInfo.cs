using System.Collections.ObjectModel;
namespace SM.Models
{
    public class ClassInfo
    {
        public string GvName { get; set; }
        public string ClassName { get; set; }
        public string ClassLesson { get; set; }
        public string ClassRoom { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
    }
    public class ClassInfoGroup : ObservableCollection<ClassInfo>
    {
        public string ClassDateStudy { get; private set; }
        public ClassInfoGroup(string classDateStudy, ObservableCollection<ClassInfo> classinfos) : base(classinfos)
        {
            ClassDateStudy = classDateStudy;
        }
        public override string ToString()
        {
            return ClassDateStudy;
        }
    }
    public class ManageClass
    {
        public string ClassName { get; set; }
        public int SumAbsent { get; set; } //số lượt vắng
        public int SumAbsentTrue { get; set; } //có phép
        public int SumAbsentFalse { get; set; } //không phép
        public int SumVP { get; set; } // số lượt vi phạm
        public string RankImg { get; set; } //image rank
        public int Sumlesson { get; set; } // số tiết trong tuần 
        public int SumGoodLesson { get; set; } // số tiết học tốt
        public int SumA { get; set; } // số tiết A
        public int SumB { get; set; } //số tiết B
        public int SumC { get; set; } // số tiết C
        public int SumD { get; set; } //số tiết D
    }
}
