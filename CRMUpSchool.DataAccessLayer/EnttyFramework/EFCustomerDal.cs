using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Repository;
using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.EnttyFramework
{
    public class EFCustomerDal:GenericRepository<Customer>, ICustomerDal
    {
    }
}
