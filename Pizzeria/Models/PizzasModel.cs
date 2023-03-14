﻿namespace Pizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle{ get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSause { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushrooms{ get; set; }
        public bool Beef { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Tuna { get; set; }
        public float FinalPrice { get; set; }
    }
}
