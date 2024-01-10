using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    /*
       Burada olacak operasyonlarımızı IEntityRepository içerisinde tanımladık ve o interface implemente ediyoruz.
       Bu sınıfı diğer entityler için ortak bir class olduğu için hangi tipte(Product) çalışacağımızı parametre olarak geçiyoruz.    
       Burada sadece Car  ı ilgilendiren özel operasyonlarımızı tanımlayabiliriz.(Car tablolarına join atma işlemleri gibi mesela Car da yer alan brand id göstermek yerine Brand tablosunu join ederek BrandName i göstermek vs. )
    */
    public interface ICarDal: IEntityRepository<Car>
    {
        List<CarDetailDto> GerCarDetails();
    }
}
