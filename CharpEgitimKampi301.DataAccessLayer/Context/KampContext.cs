using CharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext:DbContext  // veri tabanın ayansıyacak tüm verilerimiz KampContext içinde yer alacak  buraya yazmamız gerekiyor
    {
        public DbSet<Category> Categories { get; set; }     // Category-  Csharp içindeki kullanılacak oldugumuz sınıf adı  
                                                            // Categories - Sql içindeki tablo   //sınıfla tablo iç içe girmesin yalın hali csharp çoğul hali tablo olsun

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
