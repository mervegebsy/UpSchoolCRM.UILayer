
using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        //Bağımlılıkları minimize etmek

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);

        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            //if (t.categoryname = !null && t.categoryname.length >= 5 && t.categorydescription.startswith("a"))
            //{
            //    _categorydal.ınsert(t);

            //}
            //else
            //{
            //    hata mesajı
            //}
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
    //37. dakikada kaldım
}
