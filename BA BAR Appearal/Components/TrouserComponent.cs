using BA_BAR_Appearal.Models;
using Microsoft.AspNetCore.Mvc;
namespace BA_BAR_Appearal.Components
{
    [ViewComponent(Name = "TrouserComponent")]
    public class TrouserComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Trouser> shirts = new List<Trouser>();

            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser1.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser2.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser3.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser4.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser5.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser6.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser7.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser8.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser9.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser10.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser11.jpg",
                price = 1049.00
            });
            shirts.Add(new Trouser
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Trouser12.jpg",
                price = 1049.00
            });


            return View(shirts);
        }
    }


}
