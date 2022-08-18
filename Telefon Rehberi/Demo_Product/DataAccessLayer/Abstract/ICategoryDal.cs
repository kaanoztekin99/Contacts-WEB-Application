using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        // Category sınıfına ait yapılacak işlemler için imza atılmış oldu.
        // IGenericDal içerisindeki methodlar kullanıldı.
    }
}
