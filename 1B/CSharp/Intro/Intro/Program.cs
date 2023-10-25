int number1 = 10;
int number2 = 11;

string city = "Ankara"; //char array

char firstLetter = 'A';
string secondLetter = "B"; //günümüzde genellikle tek karakter bile olsa bunu duruma göre string olarak tanımlayabiliriz

//Console.WriteLine(city[0]);
//Console.WriteLine(city[1]);
//Console.WriteLine(city[2]);
//Console.WriteLine(city[3]);
//Console.WriteLine(city[4]);
//Console.WriteLine(city[5]);

double price = 25.9;
bool isItCorrect = true;

bool isLoggedIn = true;

string button1 = "<button>Giriş yap</button>";
string button2 = "<button>Hoşgeldiniz</button>";

if (isLoggedIn)
{
    Console.WriteLine(button2);
}
else
{
    Console.WriteLine(button1);
}

double dollarYesterday = 27.50;
double dollarToday = 27.40;

if (dollarToday > dollarYesterday)
{
    Console.WriteLine("UP");
}
else if (dollarToday < dollarYesterday)
{
    Console.WriteLine("DOWN");
}
else
{
    Console.WriteLine("EQUAL");
}



string[] courses = new string[] {"C#","Java","Python", "C++","JavaScript"};

Console.WriteLine("<ul>");
foreach (string course in courses) //bir array'i genellikle foreach ile döneriz
{
    Console.WriteLine("<li>{0}</li>",course);
}
Console.WriteLine("</ul>");

Console.WriteLine("<ul>");
for (int i = 0; i < courses.Length; i++) //Length yerine Count() kullanılabilir, collection'larda Count() kullanırız //collection'lar özünde array'dir
{
    Console.WriteLine("<li>{0}</li>", courses[i]);
}
Console.WriteLine("</ul>");

