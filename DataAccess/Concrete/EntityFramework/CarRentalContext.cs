using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    /*
     Entity Framework (EF) kullanarak bir veritabanı bağlantısı kurmak için genellikle DbContext sınıfını kalıtım almanız gerekir. 
     DbContext sınıfı, Entity Framework tarafından sağlanan temel sınıftır ve veritabanı bağlantısı, tablo ilişkileri, sorgular ve diğer birçok özellikle ilgili nesneleri yönetmek için kullanılır.
     */
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CarRental; Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
