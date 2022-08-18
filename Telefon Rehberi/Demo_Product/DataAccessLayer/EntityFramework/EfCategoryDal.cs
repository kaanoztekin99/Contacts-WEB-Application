using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>, ICategoryDal
    {
        // Bu class sayesinde sadece Category entity'sine ait
        // methodlar üretmemiz gerektiğinde burayı kullanacağız
    }
}
