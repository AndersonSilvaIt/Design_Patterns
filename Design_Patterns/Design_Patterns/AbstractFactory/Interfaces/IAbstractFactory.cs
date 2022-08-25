namespace Design_Patterns.AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
