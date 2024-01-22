using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Temel void işlemlerimiz için oluşturduğumuz interfacemiz. Sadece işlem sonucu ve mesajı döndüreceğiz. Herhangi bir data dönmüyor.
    // Burada başarılı olup olmadığını ve mesajı ileteceğimiz için get olarak tanımladık.
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
