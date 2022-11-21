using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }

    //transaction nedir
    // aynı anda iki yerden bir veri güncellenmek istenirse ne olur problem çıkarsa nasıl çözülür
    // aynı anda çalışan şeyler nedir paralel programing nedir
    //mapping işlemleri nedir
    //imutable nedir
    //mongo db kullandın mı design patternlarda neleri kullandın
    //singleton kullandın mı
}
