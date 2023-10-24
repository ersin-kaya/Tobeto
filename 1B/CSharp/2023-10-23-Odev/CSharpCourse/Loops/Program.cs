static void ForLoop()
{
    for (int i = 99; i >= 0; i -= 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}

static void WhileLoop()
{
    int number = 100;

    while (number >= 0)
    {
        Console.WriteLine(number--);
    }
    Console.WriteLine("Now number is {0}", number);
}

static void DoWhileLoop()
{
    int number = 10;

    do
    {
        Console.WriteLine(number--);
    } while (number >= 11);
}

static void ForeachLoop()
{
    //The foreach statement executes a statement or a block of statements
    //    for each element in an instance of the type that implements
    //    the System.Collections.IEnumerable or
    //    System.Collections.Generic.IEnumerable<T> interface,
    //    as the following example shows:

    //Koleksiyonlarda foreach döngüsünü kullanabilmemizi sağlayan etken onun IEnumerable implementasyonu olmasıdır

    string[] students = new string[3] { "Engin", "Derin", "Salih" };

    foreach (var student in students)
    {
        Console.WriteLine(student);
        //student = "Ahmet"; //dönülen yapının elemanlarını foreach içerisinde değiştiremeyiz çünkü readonly durumdadır
    }
}