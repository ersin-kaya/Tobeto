//string[] names = new string[] { "Engin", "Murat" ,"Kerem", "Halil"};

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}


//names = new string[5];
//names[4] = "İlker";
//Console.WriteLine(names[4]);
//Console.WriteLine(names[0]);

//Collections
List<string> names2 = new List<string> { "Engin", "Murat",
 "Kerem", "Halil"};
//names2.Add("Engin");

foreach (var name in names2)
{
    Console.WriteLine(name);
}

names2.Add("İlker");
Console.WriteLine(names2[4]);
Console.WriteLine(names2[0]);