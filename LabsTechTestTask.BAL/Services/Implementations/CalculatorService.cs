using LabsTechTestTask.BAL.Implementations.Calculator.Common;
using LabsTechTestTask.BAL.Models.Calculator;
using LabsTechTestTask.BAL.Services;
using LabsTechTestTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabsTechTestTask.BAL.Implementations
{
    public class CalculatorService : ICalculatorService
    {

        public CalculatorResponse Calculate(CalculationRequest request)
        {
            var operation = OperationFactory.Create(request.Operand);

            var result = operation.Calculate(request.Operator1, request.Operator2);

            return new CalculatorResponse { Result = result };
        }

    }
}
