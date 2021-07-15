using Command.Interfaces;
using System;

namespace Command
{
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand:See, I can do simple things like printing");
        }
    }
}
