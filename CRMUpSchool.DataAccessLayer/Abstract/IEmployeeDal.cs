using CRMUpSchool.DataAccessLayer.Concrete;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeDal : IGenericDal<Employee>
    {
        List<Employee> GetEmployeesByCategory();
        void ChangeEmployeeStatusToTrue(int id);
        void ChangeEmployeeStatusToFalse(int id);
    }
}
