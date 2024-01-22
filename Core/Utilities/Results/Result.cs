using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Getter olarak  tanımladığımız yapılar redonly dir setlenemezler fakat sadece constructor içerisinde setlenebilirler.
    // Constructor a eklediğimiz this(success) ile kullanıcı sadece true veya message de gönderebilir. Gönderdiği parametreye göre constructor çalışır.
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
