using LabsTechTestTask.BAL.Interfaces;
using LabsTechTestTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabsTechTestTask.BAL.Implementations.Calculator.Common
{
    public class OperationFactory
    {

        public static IOperation Create(OperationType type)
        {
            switch (type)
            {
                case OperationType.Add:
                    return new AddOperation();
                case OperationType.Subtract:
                    return new SubtractOperation();
                case OperationType.Divide:
                    return new DivideOperation();
                case OperationType.Multiply:
                    return new MultiplyOperation();
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
