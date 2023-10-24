string[] students = new string[3];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

//string[] students2 = new[] { "Engin","Derin","Salih"}; 
//string[] students3 = { "Engin","Derin","Salih"};
string[] students4 = new string[3] { "Engin", "Derin", "Salih" };

foreach (var student in students4)
{
    Console.WriteLine(student);
}

//students[3] = "Ahmet"; // "Index was outside the bounds of the array."


//Multidimensional
string[,] regions = new string[5, 4]
{
    { "Marmara","İstanbul","İzmit","Bursa" },
    { "İç Anadolu","Konya","Ankara","Kırıkkale" },
    { "Akdeniz","Antalya","Adana","Mersin" },
    { "Karadeniz","Rize","Trabzon","Samsun" },
    { "Ege","İzmir","Muğla","Manisa" },
};

//Console.WriteLine(regions.Rank); //2
//Console.WriteLine(regions.GetUpperBound(0)); //4
//Console.WriteLine(regions.GetUpperBound(1)); //3

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
}

