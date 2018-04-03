using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KledingWebshop.Data.Models
{
    public class Categorie
    {
        public int categorieId { get; set; }
        public string categorieNaam { get; set; }
        public string beschrijving { get; set; }
        public List<Kledingstuk> kledingstukken { get; set; }
    }
}
