using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Concrete;
using CRMUpSchool.DataAccessLayer.Repository;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.EnttyFramework
{
    public class EFEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        public void ChangeEmployeeStatusToFalse(int id)
        {
            using(var context = new Context())
            {
                var values = context.Employees.Find(id);
                values.EmployeeStatus = false;
                context.SaveChanges();
            }
        }

        public void ChangeEmployeeStatusToTrue(int id)
        {
            using (var context = new Context())
            {
                var values = context.Employees.Find(id);
                values.EmployeeStatus = true;
                context.SaveChanges();
            }
        }

        public List<Employee> GetEmployeesByCategory()
        {
            using (var context = new Context())
            {
                return context.Employees.Include(x => x.Category).ToList();
                //x öyle ki x bana category ile beraber to list getir 
                //category ismi de gelsin istediğim için bu metodu yazdık
            }
        }

       
    }
}
