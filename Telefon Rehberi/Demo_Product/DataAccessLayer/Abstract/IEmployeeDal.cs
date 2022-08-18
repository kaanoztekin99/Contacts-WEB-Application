using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IEmployeeDal:IGenericDal<Employee>
    {
        // Employee tablosuna ait yapılacak olan işlemlerin imzası yapıldı.
        List<Employee> GetEmployeesListWithJob();

        //IGenericDal içerisindeki methodlar kullanıldı.
    }
}
