//Value Types
double number5 = 10.4; //8 bytes, Stores fractional numbers. Sufficient for storing 15 decimal digits
decimal number6 = 10.4M; //16 bytes, Precision 28-29 digits
char character = 'A'; //2 bytes, Stores a single character/letter, surrounded by single quotes
bool condition = false; //1 bit, Stores true or false values
byte number4 = 255; //Unsigned 8-bit integer
short number3 = -32768; //Signed 16-bit integer
int number1 = -2147483648; //Signed 32-bit integer
long number2 = 9223372036854775807; //Signed 64-bit integer
var number7 = 10;
number7 = 'A'; //ilk etapta int atadığımız için bundan sonraki değerler int kabul edilir
//number7 = "A"; //string değer atayamayız...


Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Character is : {0}", (int)character);

// "Monday" - magic string
Console.WriteLine(Days.Monday);
Console.WriteLine((int)Days.Monday);
Console.WriteLine((int)Days.Tuesday);
Console.WriteLine((int)Days.Wednesday);

enum Days
{
    Monday = 10,//default: 0
    Tuesday = 12,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}




