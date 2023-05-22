using CalulatorWeb.Models;

namespace CalulatorWeb.Services
{
    public interface ICalculatorService
    {
        int Add(int operand1, int operand2);
        int Substract(int operand1, int operand2);
    }
}
