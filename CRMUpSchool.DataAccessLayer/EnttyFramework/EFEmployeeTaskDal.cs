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
    public class EFEmployeeTaskDal : GenericRepository<EmployeeTask>, IEmployeeTaskDal
    {
        public List<EmployeeTask> GetEmployeeTasksByEmployee()
        {
            using(var context = new Context())
            {
                var values = context.EmployeeTasks.Include(x => x.AppUser).ToList();
                return values;
            }
        }
    }
}
