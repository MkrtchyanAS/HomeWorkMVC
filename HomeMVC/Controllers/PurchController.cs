using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;
using HomeMVC.Models;

namespace HomeMVC.Controllers
{
    public class PurchController : Controller
    {
        BookContext db = new BookContext();
        // GET
        public ActionResult Purchases()
        {
            IEnumerable<Purchase> purchases = db.Purchases;
            ViewBag.Purchases = purchases;
            return View();
        }
    }
}