using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }

        public string CustomerDistrict { get; set; }

        public string CustomerCity { get; set; }
    }

}

/* SOLID 
    Single responsibility - Tek sorumluluk ilkesi, bir method interface başka bir bileşen bağlı bulunduğu alanda sadece tek 
işlem yapmalı örn.aritmetik işlemleri
 
 
 
 
 
 
 */