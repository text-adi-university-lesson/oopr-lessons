using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2.Tools
{
    public delegate void MessageHandler(string message);
    internal class Delegate
    {
        private List<string> processedMessages = new List<string>();

        public void AddMessage(string message)
        {
            processedMessages.Add(message);
        }

        public void PrintAllMessages()
        {
            foreach (var message in processedMessages)
            {
                Console.WriteLine(message);
            }
        }
        public void ProcessTextMessage(string message)
        {
            Console.WriteLine($"Processing text message: {message}");
        }

        public void ProcessImageMessage(string message)
        {
            Console.WriteLine($"Processing image message: {message}");
        }

        public void ProcessVideoMessage(string message)
        {
            Console.WriteLine($"Processing video message: {message}");
        }
    }
}
