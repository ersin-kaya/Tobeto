using System;
namespace OOP3
{
	public class SmsLoggerManager : ILoggerService
	{
        public void Log()
        {
            Console.WriteLine("Sms gönderildi");
        }
    }
}

