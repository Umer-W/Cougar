using BA_BAR_Appearal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BA_BAR_Appearal.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
        public ViewResult Men()
        {
            return View("Men");
        }
        public ViewResult Women()
        {
            return View("Women");
        }
        public ViewResult Kurti()
        {
            return View("Kurti");
        }
        public ViewResult T_Shirts()
        {
            return View("T-Shirts");
        }  public ViewResult Casual_Shirts()
        {
            return View("Casual-Shirts");
        } 
        public ViewResult Freedom_Polos()
        {
            return View("Freedom-Polos");
        }
        public ViewResult Polos()
        {
            return View("Polos");
        }
        public ViewResult Trousers()
        {
            return View("Trousers");
        }
        public ViewResult Top()
        {
            return View("Top");
        }
        public ViewResult Jeans()
        {
            return View("Jeans");
        }
        public ViewResult Women_T_Shirts()
        {
            return View("Women-T-Shirts");
        }
        public ViewResult Co_Ords()
        {
            return View("Co-Ords");
        }
        public ViewResult Women_Trousers()
        {
            return View("Women-Trousers");
        }
        public ViewResult Embroided()
        {
            return View("Embroided-Kurtis");
        }
        public ViewResult Shalwar()
        {
            return View("Shalwar");
        }
        public ViewResult TwoPiece()
        {
            return View("2-Piece");
        }
        public ViewResult DigitalKurti()
        {
            return View("Digital-Kurtis");
        }
        public ViewResult KurtiTrouser()
        {
            return View("Kurti-Trouser");
        }
        
    }
}