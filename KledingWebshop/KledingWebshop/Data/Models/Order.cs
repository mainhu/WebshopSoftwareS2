using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KledingWebshop.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime datum { get; set; }
        public string consumentNaam { get; set; }
        public int consumentID { get; set; }
    }
}
