using Microsoft.EntityFrameworkCore;
using Pizza.Models;

namespace Pizza.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<PizzaOrder> pizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
