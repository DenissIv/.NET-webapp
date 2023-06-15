using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD4.Models
{
    public partial class Customer
    {
        public string FullName { get { return Name + " " + Surname; } } // var pielikt klāt  + " " + Email, lai drukā arī e-pastu
    }
}
