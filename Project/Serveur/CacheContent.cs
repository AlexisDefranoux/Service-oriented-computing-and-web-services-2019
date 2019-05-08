using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    public class CacheContent<T>
    {
        public DateTime createDate { get; set; }

        public T data { get; set; }

    }
}
