using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.OData.Atom;

namespace KledingWebshop.Data.Models
{
    public class Kledingstuk
    {
        public int kledingstukId { get; set; }
        public string naam { get; set; }
        public string korteBeschrijving { get; set; }
        public string langeBeschrijving { get; set; }
        public decimal prijs { get; set; }
        public string imageUrl { get; set; }
        public string imageThumbnailUrl { get; set; }
        public bool aanbieding { get; set; }
        public int categorieId { get; set; }
        public virtual Categorie categorie { get; set; }

    }
}
