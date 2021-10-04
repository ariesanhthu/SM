using SM.Models;
using System.Collections.ObjectModel;
namespace SM.ViewModels
{
    public class SoDauBaiViewModel
    {
        public ManageClass SDBinfo { get; set; }
        public SDBdetail SdbEdit { get; set; }
        public ObservableCollection<SDBgroup> SdbDetails { get; set; }
        public ObservableCollection<ViPham> Viphams { get; set; }
        public ObservableCollection<ViPham> Absents { get; set; }
        public SoDauBaiViewModel()
        {
            OncreateSDB();
            CreateSDBcollection();
            OncreateSdbEdit();
            CreateViPhamCollection();
            CreateAbsentCollection();
        }
        public void OncreateSDB()
        {
            SDBinfo = new ManageClass
            {
                ClassName = "10TT",
                SumAbsent = 2,
                SumAbsentTrue = 1,
                SumAbsentFalse = 1,
                SumA = 30,
                SumB = 5,
                SumC = 0,
                SumD = 0,
                SumVP = 2,
                Sumlesson = 35,
                SumGoodLesson = 20
            };
        }

        //Add data current
        public void OncreateSdbEdit()
        {
            SdbEdit = new SDBdetail
            {
                Date = "Thứ ba, 1/7/2021",
                Subject = "Tin Học",
                PPCT = 1,
                LessonName = "Bài 1: Độ phức tạp thuật toán",
                Point1 = 10,
                Point2 = 10,
                Point3 = 10,
                VP = 0,
                Absent = 2,
                AbsentTrue = 1,
                AbsentFalse = 1,
                CheckDiemdanh = true,
                Xeploai = "A",
                Nhanxet = "Nhận xét",
                IconStart = "ic_start.png",
                GvName = "Phan Thành Tâm",
                Diemdanh = "đã điểm danh",
            };
        }
        
        public void CreateViPhamCollection()
        {
            Viphams = new ObservableCollection<ViPham>
            {
                new ViPham
                {
                    ViPhamName = "Mất trật tự",
                    DiemTru = -50
                },
                new ViPham
                {
                    ViPhamName = "Không thuộc bài",
                    DiemTru = -50
                }
            };
        }
        public void CreateAbsentCollection()
        {
            Absents = new ObservableCollection<ViPham>
            {
                new ViPham
                {
                    ViPhamName = "Có Phép",
                    DiemTru = 0
                },
                new ViPham
                {
                    ViPhamName ="Không phép",
                    DiemTru = -39
                }
            };
        }
        public void CreateSDBcollection()
        {
            SdbDetails = new ObservableCollection<SDBgroup>
            {
                new SDBgroup("Sáng","10TT","Thứ ba, 1/7/2021",
                new ObservableCollection<SDBdetail>
                {
                    new SDBdetail
                    {
                        LessonNumber = "Tiết 1",
                        Subject = "Tin Học",
                        GvName = "Phan Thành Tâm",
                        PPCT = 1,
                        Point1 = 10,
                        Point2 = 10,
                        Point3 = 10,
                        Absent = 0,
                        AbsentFalse = 0,
                        AbsentTrue = 0,
                        VP = 0,
                        LessonName = "Bài 1: Tìm kiếm và sắp xếp",
                        CheckDiemdanh = true,
                        Xeploai = "A",
                        IconStart = "ic_start.png",
                        Diemdanh = "đã điểm danh"
                    },
                    new SDBdetail
                    {
                        LessonNumber = "Tiết 2",
                        Subject = "Tin Học",
                        GvName = "Phan Thành Tâm",
                        PPCT = 2,
                        Point1 = 10,
                        Point2 = 10,
                        Point3 = 10,
                        Absent = 0,
                        AbsentFalse = 0,
                        AbsentTrue = 0,
                        VP = 0,
                        LessonName = "Luyện tập",
                        CheckDiemdanh = true,
                        Xeploai = "A",
                        IconStart = "ic_start.png",
                        Diemdanh = "đã điểm danh"
                    },
                    new SDBdetail
                    {
                        LessonNumber = "Tiết 3",
                        Subject = "Hóa Học",
                        GvName = "Nguyễn T.T. Thảo",
                        PPCT = 1,
                        Point1 = 10,
                        Point2 = 10,
                        Point3 = 10,
                        Absent = 0,
                        AbsentFalse = 0,
                        AbsentTrue = 0,
                        VP = 0,
                        LessonName = "Ôn Tập",
                        CheckDiemdanh = true,
                        Xeploai = "A",
                        IconStart = "ic_start_none.png",
                        Diemdanh = "đã điểm danh"
                    },
                    new SDBdetail
                    {
                        LessonNumber = "Tiết 4",
                        Subject = "Hóa Học",
                        GvName = "Nguyễn T.T. Thảo",
                        PPCT = 2,
                        Point1 = 10,
                        Point2 = 10,
                        Point3 = 10,
                        Absent = 0,
                        AbsentFalse = 0,
                        AbsentTrue = 0,
                        VP = 0,
                        LessonName = "Ôn Tập",
                        CheckDiemdanh = true,
                        Xeploai = "A",
                        IconStart = "ic_start.png",
                        Diemdanh = "đã điểm danh"
                    },
                    new SDBdetail
                    {
                        LessonNumber = "Tiết 5",
                        Subject = "Sinh Học",
                        GvName = "Vũ Thị Ngọc Mai",
                        PPCT = 1,
                        Point1 = 10,
                        Point2 = 10,
                        Point3 = 10,
                        Absent = 0,
                        AbsentFalse = 0,
                        AbsentTrue = 0,
                        VP = 0,
                        LessonName = "Bài 1: Các cấp tổ chức của...",
                        CheckDiemdanh = true,
                        Xeploai = "A",
                        IconStart = "ic_start_regis.png",
                        Diemdanh = "đã điểm danh"
                    },
                })
            };
        }
    }
}
