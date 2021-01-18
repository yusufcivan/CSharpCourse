using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class RecordNotFoundExpection:Exception
    {
        public RecordNotFoundExpection(string message):base(message)
        {
            
        }
    }
}
