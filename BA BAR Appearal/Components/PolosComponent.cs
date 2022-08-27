using BA_BAR_Appearal.Models;
using Microsoft.AspNetCore.Mvc;

namespace BA_BAR_Appearal.Components
{
    [ViewComponent(Name="PolosComponent")]
    public class PolosComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Polos> polo = new List<Polos>();
            polo.Add(new Polos{
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt1.jpg",
                price = 1049.00
            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt2.jpg",
                price = 1049.00
            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt3.jpg",
                price = 1049.00
            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt4.jpg",
                price = 1049.00
            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt5.jpg",
                price = 1049.00
            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt6.jpg",
                price = 1049.00
            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt7.jpg",
                price = 1049.00

            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt8.jpg",
                price = 1049.00
            });
            polo.Add(new Polos
            {
                name = "Maroon Round Neck T-shirt",
                path = "/lib/Polos_Shirt9.jpg",
                price = 1049.00
            });
            return View(polo);
        }
    }
}
