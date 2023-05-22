using CalulatorWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CalulatorWeb.Data
{
    public class CalculatorDbContext : DbContext
    {
        public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options) : base(options)
            {
            }
         public DbSet<CalculatorModel> Calculations { get; set; }
    }
}
