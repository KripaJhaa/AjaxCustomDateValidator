using letsTryEntityFramework.Models;
using PagedList;
using System.Linq;

namespace letsTryEntityFramework.ViewModel
{
    public class StudentViewModel
    {

        public string CurrentSort { get; set; }
        public string NameSortParm { get; set; }
        public string DateSortParm { get; set; }
        public string CurrentFilter { get; set; }
        public IPagedList<Student> dataList;
    }
}