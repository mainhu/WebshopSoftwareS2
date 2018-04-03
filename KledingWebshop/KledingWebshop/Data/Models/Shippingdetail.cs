using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KledingWebshop.Data.Models
{
    public class Shippingdetail
    {
        public int shippingId { get; set; }
        public decimal kosten { get; set; }
        public DateTime datum { get; set; }
    }
}
