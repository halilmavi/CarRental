using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        // Burada tanımladığımız SuccessDataResult classımızı da işlemlerimizin başarılı döneceği işlemlerimizde tanımlarız. 
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        // Datayı döndürmek istemediğimiz durumlar ve mesaj göndermek istediğimiz durumlarda bu şekilde default olarak tanımlayabiliriz.
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }

    }
}
