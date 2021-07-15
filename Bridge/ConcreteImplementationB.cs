using Bridge.Interfaces;

namespace Bridge
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: the result in platform B. /n";
        }
    }
}
