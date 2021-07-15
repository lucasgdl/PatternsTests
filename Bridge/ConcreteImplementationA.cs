using Bridge.Interfaces;

namespace Bridge
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: the result in platform A. /n";
        }
    }
}
