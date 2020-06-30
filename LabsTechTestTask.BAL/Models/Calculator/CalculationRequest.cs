using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabsTechTestTask.Models
{
    public class CalculationRequest
    {
        public int Operator1 { get; set; }
        public OperationType Operand { get; set; }
        public int Operator2 { get; set; }
    }
}
