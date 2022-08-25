using Design_Patterns.Bridge.Interfacecs;

namespace Design_Patterns.Bridge
{
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }

}
