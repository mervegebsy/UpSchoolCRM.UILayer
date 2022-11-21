using CRMUpSchool.EntityLayer.Concrete;

namespace CRMUpSchool.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        void GetProductByCategory();
    }
}
