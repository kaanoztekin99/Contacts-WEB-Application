using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    //EntityLayer Tablolarımızdaki entity'leri tutuyor.
    //Bu katmandaki Concrete klasörü somut ifadelerimizi tutar.
    public class Product
    {
        //Ürünlerimizin tablodaki değerlerini tanımladık.
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
