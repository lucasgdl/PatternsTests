using Bridge.Interfaces;

namespace Bridge
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base Operation with: \n" + _implementation.OperationImplementation();
        }
    }
}
