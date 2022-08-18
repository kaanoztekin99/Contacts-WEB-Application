using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T :class
    {
        /* t değerimiz bir class aynı zamanda entity
         Generic Repository için oluşturuldu.
         IProductDal, IGenericDal ve IEmployeeDal interfacelerinin methodları burada kullanıldı.
         SOLID'e uygunluk
         Oluşturulan gereksiz ve kullanılmayan methodlar burada kullanıldı.*/
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
        T GetByName(string name);
    }
}
