using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    /*
     
    EfEntityRepositoryBase bu classı generic bir şekilde tanımladık. Çünkü bu class içerisinde tanımladığımız operasyonların hepsi veritabanı tablolarına karşılık gelen sınıflarda yapılacak tüm CRUD işlemler birbirinin aynısı olacak
    sadece entitylerin tipleri farklı olacağı için böyle bir yapı kurduk.
    EfEntityRepositoryBase  sınıfının parametre olarak aldığı 2 şey var bunlardan ilki TEntity, bu parametre bu base sınıfı hangi sınıf implemente ediyorsa onun tipini(Car, Brand, Color vs.) parametre olarak vermemiz gerekiyor.
    İkinci parametre ise TContext, bu parametremiz ise CRUD işlemleri yapılırken veritabanındaki tablolara erişim sağlamamız için kullanmamız gereken veritabanını yapılandırdığımız classımızı (Şuan CarRentalContext veritabanını kullanıyoruz. Daha sonra ihtiyaca göre yeni bir
    bir veritabanı eklendiğindede bu operasyonları olduğu gibi kullanabiliriz. ) parametre olarak gönderiririz.
    EfEntityRepositoryBase sınıfımız, IEntityRepository interface ni implement ediyor. Bu interface tüm Crud işlemlerinde kullanacağımız metotların imzalarını tanımlıyoruz. IEntityRepository bu interface DataAccess katmanında abstract klasöründe yer alan tüm veritabanı tablolarının
    interfacelerine implemente edildi çünkü business katmanında işlemler yaparken biz bu soyut sınıfları kullanarak injection işlemi yapıp tüm CRUD operasyonlarına erişim sağlayacağız.


    EfEntityRepositoryBase<TEntity, TContext>  buraya parametre olarak gonderdiğimiz tipleri Generic Constraint ile kısıtlamamız gerekir.
    Çünkü buraya sadece bizim tanımladığımız tipler gönderilmeli rastegele bir tip gönderilmemelidir.
    O yüzden where ile koşullarımızı ekledik. EfEntityRepositoryBase e parametre olarak gelen TEntity bir class olmalı ve IEntity implemente eden 
    bir class olmalı şeklinde tanımladık. IEntity bütün veritabanı nesnelerimizi işaretlediği için onu kullanabiliriz.
    Son olarak eklediğimiz new() keywordu ile soyut bir interface verilmesininde önüne geçmek için tanımladık. interface ler new
    lenemez. O yüzden kullanıcı somut bir class tanımlamak zorunda kalmasını sağladık.
    EfEntityRepositoryBase e parametre olarak gelen TContext, bu parametre de çalıştığımız veritabanının yapılandırdığımız sınıf gelmesi gerektiği için DbContext i kalıtım alan bir sınıf olması gerektiği için böyle bir koşul ekledik.
     
     */
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                      ? context.Set<TEntity>().ToList()
                      : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
    }
}
