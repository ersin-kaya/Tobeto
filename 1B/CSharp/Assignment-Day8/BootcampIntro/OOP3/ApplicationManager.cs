using System;
namespace OOP3
{
	public class ApplicationManager
	{
		//Method Injection -> bu metodun hangi kredi türünü ve hangi loglayıcıyı kullanacağını enjekte ediyoruz
		public void Apply(ILoanService loanManager, List<ILoggerService> loggerServices)
		{
			//Başvuran bilgilerini değerlendirme işlemleri
			loanManager.Calculate();
			foreach (var loggerService in loggerServices)
			{
				loggerService.Log();
			}
		}

		public void LoanPreliminaryInformation(List<ILoanService> loans)
		{
			foreach (var loan in loans)
			{
				loan.Calculate();
			}
		}
    }
}

