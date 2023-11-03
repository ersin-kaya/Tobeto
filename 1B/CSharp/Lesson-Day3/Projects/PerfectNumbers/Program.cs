using System.Diagnostics;
using System.Numerics;

//7 - Write a C# program finds first 10 perfect numbers.

var firstTenPerfectNumbers = GetFirstTenPerfectNumbers(GetPrimeNumbersUpTo(100));

foreach (BigInteger perfectNumber in firstTenPerfectNumbers)
{
    //Console.WriteLine(perfectNumber);
}

static List<BigInteger> GetFirstTenPerfectNumbers(List<int> primeNumbers)
{
    List<BigInteger> perfectNumbers = new List<BigInteger>();
    int perfectNumbersCount = perfectNumbers.Count();

    foreach (BigInteger primeNumber in primeNumbers)
    {
        //n asal iken, (2^n)-1'de asal ise 2^(n-1)*((2^n)-1) => perfect number
        if (IsPrime(ComputeThePowerOfTwo(primeNumber) - 1))
        {
            BigInteger perfectNumber = ComputeThePowerOfTwo(primeNumber - 1) * (ComputeThePowerOfTwo(primeNumber) - 1);

            perfectNumbers.Add(perfectNumber);
            Console.WriteLine(perfectNumber);

            if (++perfectNumbersCount == 10)
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
        if (IsPrime(i))
        {
            primeNumbers.Add(i);
        }
    }
    return primeNumbers;
}

//Fermat asallık testi uygulanmaya çalışılmıştır...
static bool FermatPrimalityTest(BigInteger number)
{
    //1. number asallığını kontrol edeceğimiz tam sayı olmak üzere

    Random random = new Random();
    BigInteger randomNumber = NextBigInteger(random, 1, number); //2. number'dan küçük rastgele bir tam sayı üretiyoruz

    //3. number ve randomNumber'ın en büyük ortak böleni 1 midir?
    if (GCD(number, randomNumber) == 1)
    {
        //5. en büyük ortak bölenleri 1 ise randomNumber^(number-1) % number'ın 1'e eşit olup olmadığına bakılır
        if (ComputeThePowerOf(randomNumber, number - 1) % number == 1)
        {
            return true;
        }
        else
        {
            //6. cevap hayır ise number'ın bileşik sayı olduğuna dair bir kanıt elde etmiş oluyoruz
            return false;
        }
    }
    else
    { //4. en büyük ortak bölen 1'den büyük ise bunların ortak bir çarpanı vardır ve bu durumda number bileşik sayıdır
        return false;
    }
}

static bool IsPrime(BigInteger number)
{
    List<bool> bools = new List<bool>();
    int numberTrials = 0;

    while (++numberTrials != 5)
    {
        bools.Add(FermatPrimalityTest(number));
    }

    if (bools.Contains(false))
    {
        return false;
    }
    return true;
}

static BigInteger ComputeThePowerOfTwo(BigInteger power)
{
    BigInteger counter = 1;
    BigInteger result = 2;

    while (counter++ < power)
    {
        result *= 2;
    }
    return result;
}

static BigInteger ComputeThePowerOf(BigInteger number, BigInteger power)
{
    BigInteger counter = 1;
    BigInteger result = number;

    while (counter++ < power)
    {
        result *= number;
    }
    return result;
}

static BigInteger GCD(BigInteger a, BigInteger b)
{
    while (a != 0 && b != 0)
    {
        if (a > b)
            a %= b;
        else
            b %= a;
    }
    return a | b;
}

static BigInteger NextBigInteger(Random random, BigInteger minValue, BigInteger maxValue)
{
    if (minValue > maxValue) throw new ArgumentException();
    if (minValue == maxValue) return minValue;
    BigInteger zeroBasedUpperBound = maxValue - 1 - minValue; // Inclusive
    Debug.Assert(zeroBasedUpperBound.Sign >= 0);
    byte[] bytes = zeroBasedUpperBound.ToByteArray();
    Debug.Assert(bytes.Length > 0);
    Debug.Assert((bytes[bytes.Length - 1] & 0b10000000) == 0);

    // Search for the most significant non-zero bit
    byte lastByteMask = 0b11111111;
    for (byte mask = 0b10000000; mask > 0; mask >>= 1, lastByteMask >>= 1)
    {
        if ((bytes[bytes.Length - 1] & mask) == mask) break; // We found it
    }

    while (true)
    {
        random.NextBytes(bytes);
        bytes[bytes.Length - 1] &= lastByteMask;
        var result = new BigInteger(bytes);
        Debug.Assert(result.Sign >= 0);
        if (result <= zeroBasedUpperBound) return result + minValue;
    }
}

////son 2 sayının üretilmesine engel olan, refactor edilmesi gereken metot
//static bool IsDividerMoreThanTwo(Int128 number)
//{
//    int counter = 0;
//    for (Int128 i = 1; i <= number; i++) //not: döngüyü number/2'ye gidecek şekilde ele almak çözüm olmuyor
//    {
//        if (number % i == 0)
//        {
//            counter++;
//        }
//        if (counter > 2)
//        {
//            return true;
//        }
//    }
//    return (counter == 1) ? true : false;
//}