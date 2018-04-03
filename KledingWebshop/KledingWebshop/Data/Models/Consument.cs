using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KledingWebshop.Data.Models
{
    public class Consument
    {
        public string naam { get; set; }
        public string achternaam { get; set; }
        public string straat { get; set; }
        public string huisnummer { get; set; }
        public string postcode { get; set; }
        public DateTime geboortedatum { get; set; }
        public string emailID { get; set; }

    }
}
