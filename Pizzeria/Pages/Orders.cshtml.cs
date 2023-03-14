using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        private readonly ApplicationDBContext _context;
        public OrdersModel(ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
