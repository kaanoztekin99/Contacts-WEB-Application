using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager : IGenericService<Employee>
    {
        // EntityFrameworkteki ya da DataAccesteki verilere erişim sağlamak gerekiyor
        // Yapıcı Constructor method ile bunu sağlıyoruz.
        IEmployeeDal _employeeDal;
        // Aynı şekilde generic repository design pattern kullanıyoruz
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }// Constructor method

        public List<Employee> GetEmployeesListWithJob()
        {
            return _employeeDal.GetEmployeesListWithJob();
        }

        public void TDelete(Employee t)
        {
            _employeeDal.Delete(t);
        }

        public Employee TGetById(int id)
        {
            return _employeeDal.GetById(id);
        }

        public Employee TGetByName(string name) 
        {
            return _employeeDal.GetByName(name);
        }

        public List<Employee> TGetList()
        {
            return _employeeDal.GetList();
        }

        public void TInsert(Employee t)
        {
            // Kişileri ekledik şartlarını ise FluentValidation kısmında kullandık
            _employeeDal.Insert(t);
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);
        }
    }
}
