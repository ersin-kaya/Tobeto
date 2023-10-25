IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Worker(),
    new Manager()
};

foreach (var eat in eats)
{
    eat.Eat();
}

interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}

class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Hi manager, please go to eat.");
    }

    public void GetSalary()
    {
        Console.WriteLine("Hi manager, please get your salary.");
    }

    public void Work()
    {
        Console.WriteLine("Hi manager, please work now.");
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Hi worker, go to eat.");
    }

    public void GetSalary()
    {
        Console.WriteLine("Hi worker, please get your salary.");
    }

    public void Work()
    {
        Console.WriteLine("Hi worker, please work now.");
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Hi robot, work hard.");
    }
}