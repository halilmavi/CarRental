using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Burada tanımladığımız ErrorDataResult classımızı da işlemlerimizin başarısız döneceği işlemlerimizde tanımlarız. 
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        // Datayı döndürmek istemediğimiz durumlarda bu şekilde default olarak tanımlayabiliriz.
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
