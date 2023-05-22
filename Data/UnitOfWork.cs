using CalulatorWeb.Data;

namespace CalculatorWeb.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CalculatorDbContext _context;
        private ICalculatorRepository _calculatorRepository;

        public UnitOfWork(CalculatorDbContext context)
        {
            _context = context;
        }

        public ICalculatorRepository CalculatorRepository
        {
            get
            {
                if (_calculatorRepository == null)
                    _calculatorRepository = new CalculatorRepository(_context);

                return _calculatorRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
