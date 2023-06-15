using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD4.Models
{
    public partial class Order
    {
        public string Info { get { return Number + " | " + OrderDate; } }
    }
}
