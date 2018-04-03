using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using KledingWebshop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using KledingWebshop.Models;

namespace KledingWebshop.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Welkom op Store.Index()";
        }

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        public IActionResult Details(int id)
        {
            Kledingstuk kledingstuk = new Kledingstuk();
            return View(kledingstuk);
        }
    }
}