using System;
namespace OOP3
{
    public class ConsumerLoanManager : ILoanService
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}

