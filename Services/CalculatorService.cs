using CalculatorWeb.Data;
using CalulatorWeb.Data;
using CalulatorWeb.Models;

namespace CalulatorWeb.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CalculatorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Add(int operand1, int operand2)
        {
            int result = operand1 + operand2;

            var model = new CalculatorModel
            {
                Operand1 = operand1,
                Operand2 = operand2,
                Result = result
            };
            _unitOfWork.CalculatorRepository.SaveCalculation(model);
            _unitOfWork.Save();

            return result;
        }

       
        public int Substract(int operand1, int operand2)
        {
            int result = operand1 - operand2;

            var model = new CalculatorModel
            {
                Operand1 = operand1,
                Operand2 = operand2,
                Result = result
            };

            _unitOfWork.CalculatorRepository.SaveCalculation(model);
            _unitOfWork.Save();

            return result;
        }

    }
}
