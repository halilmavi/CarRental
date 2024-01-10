using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    /*
     
      IEntityRepository i interface ini oluşturmamızın sebebi farklı entity classları( Product, Category, Customer, Order vs.) içerisinde benzer operasyonları yapacağımız 
      için  aynı operasyonlar(Add,Update, Delete, GetAll, Get vs.) kodlarını tekrar etmemek için bir tane interface oluşturduk ve bu interface i Generic Repository Patterne 
      göre oluşturduk. 
      Bu interface içerisinde aynı işlemleri farklı entity ler için yapacağımız operasyonlarımızı tanımladık.
      Aşağıda GetAll ve Get metotları içerisinde parametre olarak tanımlanan Expression yapısını bu metotlara gönderecek olduğumuz değerlere göre filtreli bir
      yapıyı kurgulayabilmek için tanımladık.
      IEntityRepository<T> buraya parametre olarak gonderdiğimiz tipleri Generic Constraint ile kısıtlamamız gerekir.
        Çünkü buraya sadece bizim tanımladığımız tipler gönderilmeli rastegele bir tip gönderilmemeli.O yüzden
        where ile koşullarımızı ekledik. IEntityRepository e parametre olarak gelen tip bir class olmalı ve IEntity implemente eden 
        bir class olmalı şeklinde tanımladık. IEntity bütün veritabanı nesnelerimizi işaretlediği için onu kullanabiliriz.
        Son olarak eklediğimiz new() keywordu ile soyut bir interface verilmesininde önüne geçmek için tanımladık. interface ler new
        lenemez. O yüzden kullanıcı somut bir class tanımlamak zorunda kalmasını sağladık.

     */

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
