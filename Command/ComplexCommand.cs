using Command.Interfaces;
using System;

namespace Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _a;
        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receive");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}
