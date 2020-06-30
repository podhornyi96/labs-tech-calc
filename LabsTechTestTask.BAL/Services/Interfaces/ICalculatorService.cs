using LabsTechTestTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabsTechTestTask.BAL.Services
{
    public interface ICalculatorService
    {
        CalculatorResponse Calculate(CalculationRequest request);
    }
}
