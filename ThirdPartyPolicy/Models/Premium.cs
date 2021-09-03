using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyPolicy.Models
{
    public class Premium
    {
        public int Id { get; set; }
        public string PremiumAmount { get; set; }
        public List<BodyType> BodyTypes { get; set; }
    }
}
