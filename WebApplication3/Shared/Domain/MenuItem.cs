using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Shared.Domain
{
    public class MenuItem : BaseDomainModel
    {
        public string Name { get; set; }
        public float Price { get; set; }
        
    }

}
