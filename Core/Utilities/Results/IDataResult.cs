using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Buradaki IDataResult sınıfında IResult implementasyonunu da tanımlıyoruz. Çünkü kullanıcı data ile birlikte başarılı,başarısız veya mesaj göndermek isteyebilir. 
    // IDataResult ı da generic olarak tanımlıyoruz. Kullanıcı hangi tiple çalışacaksa onu belirtmesi gerekiyor.
    public interface IDataResult<T> :IResult
    {
        T Data { get; }
    }
}
