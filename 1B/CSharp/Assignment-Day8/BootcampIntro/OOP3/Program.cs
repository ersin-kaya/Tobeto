using OOP3;

ILoanService consumerLoanManager = new ConsumerLoanManager();
ILoanService vehicleLoanManager = new VehicleLoanManager();
ILoanService housingLoanManager = new HousingLoanManager();

ILoggerService databaseLoggerManager = new DatabaseLoggerManager();
ILoggerService fileLoggerManager = new FileLoggerManager();

List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerManager(), new DatabaseLoggerManager() };


ApplicationManager applicationManager = new ApplicationManager();
applicationManager.Apply(new TradesmanLoanManager(), loggers);

List<ILoanService> loans = new List<ILoanService>() { consumerLoanManager, vehicleLoanManager };

//applicationManager.LoanPreliminaryInformation(loans);