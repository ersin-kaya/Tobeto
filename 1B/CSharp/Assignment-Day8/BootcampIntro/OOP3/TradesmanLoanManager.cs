using System;
namespace OOP3
{
    public class TradesmanLoanManager : ILoanService
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}

