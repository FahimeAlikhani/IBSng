using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeginIBSng.Handlers
{
    public class ApiModol<TData>

    {
        public bool Success { get; set; }
        public TData Data { get; set; }
    }
}
