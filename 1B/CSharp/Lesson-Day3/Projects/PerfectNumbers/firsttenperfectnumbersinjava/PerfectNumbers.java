import java.math.BigInteger;
import java.util.ArrayList;
import java.util.List;

public class PerfectNumbers
{
	public static void main(String[] args) {
        List<BigInteger> perfectNumbers = GetFirstTenPerfectNumbers(GetPrimeNumbersUpTo(100));

        for (BigInteger perfectNumber : perfectNumbers) {
            System.out.println("> "+perfectNumber+" <");
        }
	}

    static List<BigInteger> GetFirstTenPerfectNumbers(List<Integer> primeNumbers) {
        List<BigInteger> perfectNumbers = new ArrayList<>();
        int perfectNumbersCount = perfectNumbers.size();
        BigInteger temp;

        for (Integer primeNumber : primeNumbers) {
            temp = ComputeThePowerOfTwo(primeNumber).subtract(BigInteger.ONE);

            if (temp.isProbablePrime(20)) {
                BigInteger perfectNumber =(ComputeThePowerOfTwo(primeNumber - 1).multiply(ComputeThePowerOfTwo(primeNumber).subtract(BigInteger.ONE)));
                perfectNumbers.add(perfectNumber);

                if (++perfectNumbersCount == 10) {
                    break;
                }
            }
        }
        return perfectNumbers;
    }

    static List<Integer> GetPrimeNumbersUpTo(Integer value) {
        List<Integer> primeNumbers = new ArrayList<>();

        for (int i = 1; i <= value; i++) {
            if(BigInteger.valueOf(i).isProbablePrime(5)){
                primeNumbers.add(i);
            }
        }
        return primeNumbers;
    }

    static BigInteger ComputeThePowerOfTwo(Integer limit) {
        Integer counter = 1;
        BigInteger result = BigInteger.TWO;

        while (counter++ < limit) {
            result = result.multiply(BigInteger.TWO);
        }
        return result;
    }
}
