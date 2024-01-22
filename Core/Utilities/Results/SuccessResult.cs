using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // base(true, message): Bu ifade, bu constructor'ın üst sınıfın (base class) constructor'ını çağırdığını belirtir.
        // Yani, SuccessResult sınıfının base class'ının (muhtemelen bir başka sınıfın) constructor'ını çağırırken, bu constructor true ve message değerlerini iletiyor demektir. 
        public SuccessResult(string message) : base(true, message)
        {

        }

        // Buradaki constructorı, kullanıcı mesaj göndermeyip sadece başarılı olduğunu döndürebileceği metot tanımladık. 
        public SuccessResult(): base(true)
        {

        }
    }
}
