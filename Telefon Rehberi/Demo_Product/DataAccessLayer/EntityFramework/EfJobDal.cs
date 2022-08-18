using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfJobDal : GenericRepository<Job>, IJobDal
    {
        // Bu class sayesinde sadece Job entity'sine ait
        // methodlar üretmemiz gerektiğinde burayı kullanacağız
    }
}
