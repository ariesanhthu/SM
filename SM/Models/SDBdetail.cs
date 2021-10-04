using System.Collections.ObjectModel;

namespace SM.Models
{
    public class SDBdetail
    {
        public string Date { get; set; }
        public string LessonNumber { get; set; }
        public string Subject { get; set; }
        public int PPCT { get; set; }
        public string LessonName { get; set; }
        public int Point1 { get; set; }
        public int Point2 { get; set; }
        public int Point3 { get; set; }
        public int Absent { get; set; }
        public int AbsentTrue { get; set; }
        public int AbsentFalse { get; set; }
        public int VP { get; set; }
        public string Xeploai { get; set; }
        public string GvName { get; set; }
        public bool CheckDiemdanh { get; set; }
        public string Diemdanh { get; set; }
        public string IconStart { get; set; }
        public string Nhanxet { get; set; }
    }
    public class SDBgroup : ObservableCollection<SDBdetail>
    {
        public string Buoihoc { get; set; }
        public string ClassName { get; set; }
        public string Date { get; set; }
        public SDBgroup(string buoihoc, string classname, string date, ObservableCollection<SDBdetail> SdbDayDetails) : base(SdbDayDetails)
        {
            Buoihoc = buoihoc;
            ClassName = classname;
            Date = date;
        }
    }
}
