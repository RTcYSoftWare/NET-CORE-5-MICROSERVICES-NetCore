using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Database
{
    public class DatabaseContext:DbContext
    {

        /*VERİTABANI BAĞLANTISINI KURMAK İÇİN KULLANDIĞIMIZ FONKSİYON*/
        public DatabaseContext(DbContextOptions<DatabaseContext> options ): base(options)
        {

        }


        /*OLUŞTURDUĞUMUZ MODELLERİN DB SET İÇİN TANIMI*/
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }




    }
}
/* Startup.cs sınıfında bu sınıfı tanımlayarak işlemler gerçekleştirdik
 * appsettings.json dosyamızda connectionStringimizi yazdık.
 * pm üzerinden migration ekledik ve database update işlemlerini yaptık
 * # add-migration initial
 * # update-database -verbose
 * launcSettings.json içerisinde gerekli düzenlemeleri yaptık.
 */