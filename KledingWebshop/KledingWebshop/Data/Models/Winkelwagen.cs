using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KledingWebshop.Data.Models
{
    public class Winkelwagen
    {
        public int winkelwagenID { get; set; }
        public Kledingstuk kledingstuk { get; set; }
        public int aantal { get; set; }
    }
}
