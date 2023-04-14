using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Data;
using Pizza.Models;

namespace Pizza.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }   
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
		{
            _context = context;
		}
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            PizzaOrder po = new PizzaOrder();
            po.PizzaName = PizzaName;
            po.BasePrice = PizzaPrice;
            _context.pizzaOrders.Add(po);

            _context.SaveChanges();

        }

        
        
       
     

    }
}
