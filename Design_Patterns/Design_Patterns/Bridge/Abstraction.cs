﻿using Design_Patterns.Bridge.Interfacecs;

namespace Design_Patterns.Bridge
{
    class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }
}
