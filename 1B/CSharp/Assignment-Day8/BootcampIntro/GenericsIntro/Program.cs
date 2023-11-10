using GenericsIntro;


MyList<string> names = new MyList<string>();
names.Add("Engin");
names.Add("Salih");

foreach (var item in names.GetItems())
{
    Console.WriteLine(item);
}

Console.WriteLine("Length: " + names.Length);