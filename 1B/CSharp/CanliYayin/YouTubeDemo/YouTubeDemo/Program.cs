//Intentional programming:
//In computer programming, Intentional Programming is a programming paradigm
//developed by Charles Simonyi that encodes in software source code the precise intention
//which programmers (or users) have in mind when conceiving their work.


// IoC container, ninject, autofac,...
CustomerManager customerManager =
    new CustomerManager(new NhCustomerDal(), new MainLoggerAdapter()); //ioc container bir konfigürasyondur, database'den email'e çektik ve bitti //4. ve firmanın merkezi microservice'ine geçiyoruz(new MainLoggerAdapter())  //6. yani merkezi logger olmadan da development ve test'e devam edebilmeliyiz (burada FakeLogger() ile)
customerManager.Save(new Customer());



class CustomerDal : ICustomerDal
{
    public void Save()
    {
        Console.WriteLine("Customer Added with Ef");
    }
}

class NhCustomerDal : ICustomerDal
{
    public void Save()
    {
        Console.WriteLine("Customer Added with Nh");
    }
}

interface ICustomerDal
{
    void Save();
}




// class, interface, struct, delegate, field, property ve metotların default access modifier'ı internal'dır.
// Bir sınıf bağımlı olduğu başka bir sınıfı new'leyemez!
class CustomerManager : ICustomerService
{
    ICustomerDal _customerDal;
    ILogger _logger;

    public CustomerManager(ICustomerDal customerDal, ILogger logger)
    {
        _customerDal = customerDal;
        _logger = logger;
    }

    public void Save(Customer customer)
    {
        // kurallar
        _customerDal.Save();
        //Logger logger = new Logger(); //bu kullanımda doğru değil
        //logger.Log(LoggerType.Email);

        _logger.Log();
    }
}


interface ICustomerService
{
    void Save(Customer customer);
}

class Customer:IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}

interface IEntity
{
}

//bu class'ı da kaldıralım çünkü ILogger'ı implemente eden DatabaseLogger'ı yazdık
////enum'lar hiçbir şekilde logic kontrolü için kullanılamaz,
////enum'ların amacı magic string'ler ile çalışmaktır,
////eğer logic kontrolü yapıyorsanız uygulamanızın içi if'lerle dolacaktır.
//class Logger //burada Logger hiçbir inheritance özelliği barındırmadığı için bununla hiçbir design pattern'i kullanacamayacağımız anlamına geliyor
//{
//    public void Log(LoggerType loggerType)
//    {
//        if(loggerType == LoggerType.Database)
//        {
//            Console.WriteLine("Logged to db");
//        }
//        else if (loggerType == LoggerType.File)
//        {
//            Console.WriteLine("Logged to file");
//        }
//        else if (loggerType == LoggerType.Email)
//        {
//            Console.WriteLine("Logged to email");
//        }
//    }
//}

//enum LoggerType //bu kullanım yanlıştı, kaldıralım, ILogger adında bir interface tanımlayalım
//{
//    Database,File,Email //bu üçü birbirinin alternatifidir.
//                  // şart bloklarında amaç uygulamayı aynı fonksiyon içerisinde dallandırmaktır.
//                  // sonuç olarak böyle birbirinin alternatifi olan durumlarda if kullanmamalıyız... (yukarıdaki Log metodunda kötü kod yazıyoruz) // örneğin burada Email'i sonradan ekledik (yeni bir özellik ekledik) ve gidip önceki kodlara dokunmak zorunda kaldık çünkü if odaklı bir yazılım gerçekleştirdik...
//}

interface ILogger
{
    void Log();
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to db");
    }
}

class EmailLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to email");
    }
}

//5. örneğin development aşamasında merkezi log'a yazmasını istemiyoruz
class FakeLogger : ILogger
{
    public void Log()
    {

    }
}

class MainLoggerAdapter : ILogger //1. kendi mimarimize adaptasyon yapıyoruz
{
    public void Log() //3. yani kendi Log()'umuzun içerisinde çalışmasını istediğimiz Log()'u(mainLogger.LogToMain()) çağırıyoruz
    {
        //2. ve onun içinde diğer log'u çağırıyoruz

        MainLogger mainLogger = new MainLogger();
        mainLogger.LogToMain();
        //burası IoC container ile yönetilebilir ancak
        //burada bağımlılık net olduğu için new'lemekte de bir sakınca yoktur
    }
}


//Örneğin firma dediki her uygulama kendi logger'ını çalıştırıyor
//artık kendiniz log almayın, merkezi sisteme yazılacak
//artık DatabaseLogger ve EmailLogger firmanın kullandığı sistem değil ve
//biz böyle bir gereksinimi öngörmemiştik ancak bu teknikle yazmanın avantajıyla...

//Firmanın Microservice'i gibi düşünün, bu koda hiçbir şekilde dokunamıyoruz
//bunu görmüyoruz aslında demo amaçlı yazdık, bu bize service olarak geliyor
//Peki bir microservice'i projemize nasıl dahil ederiz? burada devreye "adapter pattern" giriyor --> yukarıda MainLoggerAdapter olarak yazıyoruz...
class MainLogger
{
    public void LogToMain()
    {
        Console.WriteLine("Logged to main");
    }
}

