﻿using LabsTechTestTask.BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabsTechTestTask.BAL.Implementations.Calculator
{
    public class DivideOperation : IOperation
    {
        public decimal Calculate(decimal operator1, decimal operator2)
        {
            // TODO: handle divide by zero

            return operator1 / operator2;
        }

    }
}
