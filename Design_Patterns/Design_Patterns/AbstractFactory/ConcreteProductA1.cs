﻿using Design_Patterns.AbstractFactory.Interfaces;

namespace Design_Patterns.AbstractFactory
{
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
