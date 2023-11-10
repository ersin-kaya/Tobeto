using System;
namespace OOP3
{
    public class VehicleLoanManager : ILoanService
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}

