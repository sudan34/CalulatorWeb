using CalulatorWeb.Models;

namespace CalulatorWeb.Data
{
    public class CalculatorRepository : ICalculatorRepository
    {
        private readonly CalculatorDbContext _context;

        public CalculatorRepository(CalculatorDbContext context)
        {
            _context = context;
        }

        public void SaveCalculation(CalculatorModel model)
        {
            _context.Calculations.Add(model);
           // _context.SaveChanges();
        }
    }
}
