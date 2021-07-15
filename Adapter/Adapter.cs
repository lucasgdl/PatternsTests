using Adapter.Interfaces;

namespace Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"this is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
