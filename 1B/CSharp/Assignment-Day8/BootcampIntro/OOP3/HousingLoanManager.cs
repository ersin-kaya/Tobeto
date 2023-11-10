using System;
namespace OOP3
{
    public class HousingLoanManager : ILoanService
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}

