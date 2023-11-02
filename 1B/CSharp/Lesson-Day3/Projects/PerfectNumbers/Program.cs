//7 - Write a C# program finds first 10 perfect numbers.
using System.Numerics;

var firstTenPerfectNumbers = GetFirstTenPerfectNumbers(GetPrimeNumbersUpTo(100));

foreach (BigInteger perfectNumber in firstTenPerfectNumbers)
{
    //Console.WriteLine(perfectNumber);
}

static List<BigInteger> GetFirstTenPerfectNumbers(List<int> primeNumbers)
{
    List<BigInteger> perfectNumbers = new List<BigInteger>();
    short perfectNumbersCount = (short)perfectNumbers.Count();

    foreach (int primeNumber in primeNumbers)
    {
        //n asal iken, (2^n)-1'de asal ise 2^(n-1)*((2^n)-1) => perfect number
        if (!IsDividerMoreThanTwo(ComputeThePowerOfTwo(primeNumber) - 1))
        {
            BigInteger perfectNumber = ComputeThePowerOfTwo(primeNumber - 1) * (ComputeThePowerOfTwo(primeNumber) - 1);
            perfectNumbers.Add(perfectNumber);
            Console.WriteLine(perfectNumber);

            if (++perfectNumbersCount == 10) //örn. ilk 8 sayıyı almak isterseniz bir süre beklettikten sonra sonuç dönecektir, veya doğrudan ekrana yazdırılırsa sadece 8. sayı geç yazdırılacaktır...
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
static bool IsDividerMoreThanTwo(BigInteger number)
{
    int counter = 0;
    for (BigInteger i = 1; i <= number; i++) //not: döngüyü number/2'ye gidecek şekilde ele almak çözüm olmuyor
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

static BigInteger ComputeThePowerOfTwo(BigInteger power)
{
    return (BigInteger)Math.Pow(2, (double)power); //refactor
}
