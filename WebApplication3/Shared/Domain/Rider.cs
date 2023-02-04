using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Shared.Domain
{
    public class Rider : BaseDomainModel
    {
        public string Name { get; set; }
        public string Vehicle { get; set; }
        public float DeliveryFee { get; set; }
    }

}
