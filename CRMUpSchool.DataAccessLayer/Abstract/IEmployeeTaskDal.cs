using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeTaskDal: IGenericDal<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTasksByEmployee();
        List<EmployeeTask> GetEmployeeTaskById(int id);
    }
}
