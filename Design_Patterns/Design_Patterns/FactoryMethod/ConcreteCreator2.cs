using Design_Patterns.FactoryMethod.Interfaces;

namespace Design_Patterns.FactoryMethod
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
