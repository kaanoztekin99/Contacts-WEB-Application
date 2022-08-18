using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        // Bu class sayesinde sadece Employee entity'sine ait
        // methodlar üretmemiz gerektiğinde burayı kullanacağız
        public List<Employee> GetEmployeesListWithJob()
        {
            using (var c = new Context()) 
            {
                return c.Employees.Include(x => x.Job).ToList();
            }
        }
    }
}
