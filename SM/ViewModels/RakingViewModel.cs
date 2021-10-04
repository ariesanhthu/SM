using SM.Models;
using System.Collections.ObjectModel;
namespace SM.ViewModels
{
    public class RakingViewModel
    {
        public ObservableCollection<ManageClass> ManageClasses { get; private set; }
        public RakingViewModel()
        {
            CreateManageClassCollection();
        }
        public void CreateManageClassCollection()
        {
            ManageClasses = new ObservableCollection<ManageClass>
            {
                    new ManageClass
                    {
                        ClassName = "10TT",
                        SumAbsent = 2,
                        SumAbsentTrue = 1,
                        SumAbsentFalse = 1,
                        SumVP = 2,
                        RankImg = "ic_firstPrize.png",
                        SumA = 30,
                        SumB = 5,
                        SumC = 0,
                        SumD = 0
                    },
                    new ManageClass
                    {
                        ClassName = "11TT",
                        SumAbsent = 0,
                        SumAbsentTrue = 0,
                        SumAbsentFalse = 0,
                        SumVP = 0,
                        RankImg = "ic_firstPrize.png",
                        SumA = 30,
                        SumB = 5,
                        SumC = 0,
                        SumD = 0
                    },
            };
        }
    }
}
