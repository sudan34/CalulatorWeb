using CalulatorWeb.Data;

namespace CalculatorWeb.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICalculatorRepository CalculatorRepository { get; }
        void Save();
    }
}
