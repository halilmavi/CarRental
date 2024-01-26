using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /*
       .NET de bir controller ın controller olabilmesi için mutlaka ControllerBase classından inheritance edilmesi gerekiyor.
       [ApiController] C# da bu yapıyı attribute olarak adlandırıyoruz. Bu sınıfın bir kontroller sınıfı olduğunu .NET e bildiriyoruz. Attribute java farklı bir anlamı vardır.Java da karşılığı annotationdır.

       Route attribute u, bir controller sınıfına bir rota şablonu atanabilmesini sağlar. Rota şablonu, bir HTTP isteğinin belirli bir controller sınıfına yönlendirilmesi için kullanılır.
       [Route("api/[controller]")] ifadesi, bir rota şablonunu temsil eder.
       Burada api/ ifadesi bir ön ek oluşturur ve [controller] kısmı, controller sınıfının adının yerine geçecek bir parametreyi temsil eder.
       Yani, [controller] ifadesi, bu route'un kullanıldığı controller sınıfının adını alacaktır.

       IActionResult C# ve .NET Core/.NET 5+ web uygulamalarında sıkça kullanılan bir arayüzdür. Bu arayüz, bir HTTP isteğine karşı bir yanıtı temsil eder.
       IActionResult'ün kullanılmasının önemli avantajları vardır:

       Esneklik: IActionResult, çeşitli HTTP durum kodlarına ve içerik türlerine uyum sağlar.
                 Örneğin, bir metot bir sayfa görüntüsü, bir JSON nesnesi, bir dosya indirme isteği gibi farklı türlerde yanıtlar dönebilir.

       Bağımsızlık: IActionResult türü, bir metodu belirli bir HTTP durum kodu veya içerik türüne bağlamaz.
                    Bu, metotların iş mantığının HTTP iletişimiyle daha az bağımlı ve yeniden kullanılabilir olmasını sağlar.

       Test Edilebilirlik: IActionResult kullanmak, metotların birim testlerini yazmayı kolaylaştırır.
                           Çünkü metotların dönüş değerleri üzerinden işlemlerin doğruluğunu kontrol etmek daha kolaydır.
  */


    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


    }

}