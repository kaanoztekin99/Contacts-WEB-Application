using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<AppUser, AppRole, int>
    {
        /*Veritabanı bağlantımızı burada yaptığımız için Veritabanımızı oluştururken ya da herhangi bir
        veri göçü durumunda Package Manager Console üzerinden Default Project kısmında
        DataAccessLayer seçtik.*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PUSH3QC\\MSSQLSERVER01;database=TelefonRehberi;integrated security=true;");
        }//database configürasyonu yaptık
        //Veritabanımıza Telefon Rehberi ismini verdik ve SQL Server Management'ı açarken bu server'a bağlandık. 
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
    /* Veri göçünde add-migration mig_ornek dedik ve
     update-database komutu ile verilerimizi tablolarda güncelledik*/
}
