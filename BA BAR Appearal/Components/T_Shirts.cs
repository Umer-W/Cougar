using BA_BAR_Appearal.Models;
using Microsoft.AspNetCore.Mvc;
namespace BA_BAR_Appearal.Components
{
    [ViewComponent(Name="T_ShirtsComponent")]
    public class T_Shirts:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<TeShirts> shirts=new List<TeShirts>();

            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt1.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt2.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt3.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt4.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt5.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt6.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt7.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt8.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt9.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt10.jpg",
                price = 1049.00
            });
            shirts.Add(new TeShirts
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/T_Shirt11.jpg",
                price = 1049.00
            });
          

            return View(shirts);
        }
    }

    
}
