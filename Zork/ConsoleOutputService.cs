using System;

namespace Zork
{
    internal class ConsoleOutputService : IOutputService
    {
        public event EventHandler<string> OutputGenerated;

        public void Clear() => Console.Clear();

        public void Write(string message)
        {
            Console.Write(message);
            if (string.IsNullOrWhiteSpace(message) == false)
            {
                OutputGenerated?.Invoke(this, message);
            }
        }

        public void Write(object message)
        {
            Write(message.ToString());
            if (string.IsNullOrWhiteSpace(message.ToString()) == false)
            {
                OutputGenerated?.Invoke(this, message.ToString());
            }
        }

        public void WriteLine(string message)
        {
            Console.Write(message);
            if (string.IsNullOrWhiteSpace(message) == false)
            {
                OutputGenerated?.Invoke(this, message);
            }
        }

        public void WriteLine(object message)
        {
            WriteLine(message.ToString());
            if (string.IsNullOrWhiteSpace(message.ToString()) == false)
            {
                OutputGenerated?.Invoke(this, message.ToString());
            }
        }
    }
}
