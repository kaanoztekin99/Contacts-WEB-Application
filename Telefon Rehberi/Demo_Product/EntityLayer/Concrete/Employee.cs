using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        //Telefon rehberinde görünecek çalışanlarımızın verilerini burada tutuyoruz.

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public string PhoneNo { get; set; }

        public int JobID { get; set; }
        public Job Job { get; set; }
    }
}
