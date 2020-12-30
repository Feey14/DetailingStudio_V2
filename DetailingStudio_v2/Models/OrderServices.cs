using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models
{
    public class OrderServices
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
