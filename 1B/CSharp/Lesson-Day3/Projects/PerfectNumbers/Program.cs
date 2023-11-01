//7 - Write a C# program finds first 10 perfect numbers.

var firstTenPerfectNumbers = GetFirstSevenPerfectNumbers(GetPrimeNumbersUpTo(100));

foreach (Int128 perfectNumber in firstTenPerfectNumbers)
{
    Console.WriteLine(perfectNumber);
}

static List<Int128> GetFirstSevenPerfectNumbers(List<int> primeNumbers)
{
    List<Int128> perfectNumbers = new List<Int128>();
    short perfectNumbersCount = (short)perfectNumbers.Count();

    foreach (double primeNumber in primeNumbers)
    {
        //n asal iken, (2^n)-1'de asal ise 2^(n-1)*((2^n)-1) => perfect number
        if (!IsDividerMoreThanTwo(ComputeThePowerOfTwo((Int128)primeNumber) - 1))
        {
            Int128 perfectNumber = ComputeThePowerOfTwo((Int128)primeNumber - 1) * (ComputeThePowerOfTwo((Int128)primeNumber) - 1);
            perfectNumbers.Add(perfectNumber);
            if (++perfectNumbersCount == 7) //örn. ilk 8 sayıyı almak isterseniz bir süre beklettikten sonra sonuç dönecektir, veya doğrudan ekrana yazdırılırsa sadece 8. sayı geç yazdırılacaktır...
            {
                break;
            }
        }
    }
    return perfectNumbers;
}

static List<int> GetPrimeNumbersUpTo(int number)
{
    List<int> primeNumbers = new List<int>();

    for (int i = 1; i < number; i++)
    {
        if (!IsDividerMoreThanTwo(i))
        {
            primeNumbers.Add(i);
        }
    }
    return primeNumbers;
}

//son 2 sayının üretilmesine engel olan, refactor edilmesi gereken metot
static bool IsDividerMoreThanTwo(Int128 number)
{
    int counter = 0;
    for (Int128 i = 1; i <= number; i++) //not: döngüyü number/2'ye gidecek şekilde ele almak çözüm olmuyor
    {
        if (number % i == 0)
        {
            counter++;
        }
        if (counter > 2)
        {
            return true;
        }
    }
    return (counter == 1) ? true : false;
}

static Int128 ComputeThePowerOfTwo(Int128 power)
{
    return (Int128)Math.Pow(2, (double)power);
}
