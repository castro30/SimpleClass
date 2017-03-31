using System;
namespace Messenger
{
    class MessengerDemo
    {
        public string message = "Default Message ";
        public void DisplayMessage()
        {
            Console.WriteLine(message);
        }

        public static void Main()
        {
            MessengerDemo objMessage = new MessengerDemo();
            objMessage.message = "Hello from C#";
            objMessage.DisplayMessage();
            Console.ReadKey();

        }
    }
}