static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            result = false;
            //break;
            i = number;
        }
    }

    return result;
}

Console.WriteLine(IsPrimeNumber(89));