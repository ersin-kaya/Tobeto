using System;
namespace OOP3
{
    public class DatabaseLoggerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}

