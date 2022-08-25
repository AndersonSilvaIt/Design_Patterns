using Design_Patterns.Bridge.Interfacecs;

namespace Design_Patterns.Bridge
{
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}
