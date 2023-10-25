Person[] people = new Person[3]
{
    new Customer { FirstName = "Engin" },
    new Student { FirstName = "Derin" },
    new Person { FirstName = "Salih" }
};

foreach (var person in people)
{
    Console.WriteLine(person.FirstName);
}

// Bir nesne yalnızca bir class'tan inheritance alabilir (örnek: Customer class'ı)
// Ancak birden fazla interface'i implemente edilebilir (örnek: Person class'ı)

// Öne inheritance yazıldıktan sonra interface'ler yazılır (örnek: Student class'ı)

// Yeni nesil dillerde interface'lerin inheritance gibi kullanım senaryolarıda söz konusudur

// Not: Hangisini kullanacağınıza karar verirken eğer interface kullanabiliyorsanız, inheritance'a ihtiyacınız olduğunu(zorunlu) düşünmüyorsanız, interface kullanın

class Person : IPerson, IPerson2
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person//, Person2
{
    public string City { get; set; }
}

class Student : Person, IPerson, IPerson2
{
    public string Department { get; set; }
}

class Person2
{

}

interface IPerson
{

}

interface IPerson2
{

}