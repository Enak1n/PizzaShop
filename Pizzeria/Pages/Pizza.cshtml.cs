using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle = "Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSause = true,
                Cheese=true,
                FinalPrice =4 },
            new PizzasModel(){
                ImageTitle = "Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSause = true,
                FinalPrice =3 },
            new PizzasModel(){
                ImageTitle = "Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=15,
                TomatoSause = true,
                Cheese=true,
                Pineapple = true,
                FinalPrice =25 },
            new PizzasModel(){
                ImageTitle = "Carbonara",
                PizzaName="Carbonara",
                BasePrice=4,
                TomatoSause = true,
                Cheese=true,
                Beef = true,
                Mushrooms = true,
                FinalPrice =4 },
             new PizzasModel(){
                ImageTitle = "MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=5,
                TomatoSause = true,
                Cheese=true,
                Beef = true,
                Ham = true,
                Peperoni = true,
                FinalPrice =12 },
              new PizzasModel(){
                ImageTitle = "Mushroom",
                PizzaName="Mushroom",
                BasePrice=5,
                TomatoSause = true,
                Cheese=true,
                Beef = true,
                Ham = true,
                Mushrooms = true,
                FinalPrice =10 },
               new PizzasModel(){
                ImageTitle = "Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=5,
                TomatoSause = true,
                Cheese=true,
                Beef = true,
                Ham = true,
                Peperoni = true,
                FinalPrice =9 },                     
            new PizzasModel(){
                ImageTitle = "Seafood",
                PizzaName="Seafood",
                BasePrice=10,
                TomatoSause = true,
                Cheese=true,
                Tuna = true,
                FinalPrice =15 },
            new PizzasModel(){
                ImageTitle = "Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=1,
                TomatoSause = true,
                Cheese=true,
                Mushrooms = true,
                FinalPrice =4 },

        };
        public void OnGet()
        {
        }
    }
}
