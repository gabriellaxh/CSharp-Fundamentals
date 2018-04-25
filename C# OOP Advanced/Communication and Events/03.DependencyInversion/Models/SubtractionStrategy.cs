﻿using _03.DependencyInversion.Interfaces;

namespace P03_DependencyInversion
{
	public class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
