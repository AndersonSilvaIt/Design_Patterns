using Design_Patterns.FactoryMethod.Interfaces;

namespace Design_Patterns.FactoryMethod
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
