using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IEmployeeService:IGenericService<Employee>
    {
        // Managerları yazmadan önce entitylerin imzasını atmış olduk
        List<Employee> GetEmployeesListWithJob();
    }
}
