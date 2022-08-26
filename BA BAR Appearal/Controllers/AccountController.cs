using Microsoft.AspNetCore.Mvc;
using BA_BAR_Appearal.Models;

namespace BA_BAR_Appearal.Controllers
{
    
    public class AccountController : Controller
    {
        public ViewResult SignUp(User u)
        {

            return View("SignUp");
        }
        public ViewResult Login()
        {

            return View("Login");
        }
        public ViewResult Registered(User u)
        {
            UserRepo.AddUser(u);
            return View("Login");
        }
        public ViewResult CheckLogin(User u)
        {
            if (UserRepo.CheckUser(u) == true)
            {
                return View("Account");
            }
            else
            {
                return View("SignUp");
            }
            
        }
    }
}
