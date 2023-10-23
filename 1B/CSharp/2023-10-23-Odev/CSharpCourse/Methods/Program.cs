//Add();
//Add();
//Add();
//Add();
//var result = Add2(2);
//Console.WriteLine(result);

int number1 = 20;
int number2 = 100;

var result2 = Add3(ref number1, number2); //number1 değerinin metot içerisinde değişebileceğini düşünüyor ve bunu kabul ediyorsak, bu bizim için geçerli bir iş süreci ise onu ref olarak gönderebiliriz
Console.WriteLine(result2);
Console.WriteLine(number1);


var result3 = Add4(out number1, number2); //ref keyword: parametrede ref geçtiğimiz değişkenin önceden mutlaka set edilmiş olması gerekmektedir ancak out ile geçeceksek böyle bir zorunluluk yoktur... Ancak out ile geçilen değişkenin ise metodun içerisinde kullanılmadan önce kesinlikle bir kez set edilmesi gerekiyor(bu durumda zaten parametreye geçilmeden önce set edilmiş olmasının bir önemi kalmıyor)... Tek farkı bu
Console.WriteLine(result3);
Console.WriteLine(number1);

Console.WriteLine(MultiplyBase.Multiply(2, 4));
Console.WriteLine(MultiplyBase.Multiply(2, 4, 5));

Console.WriteLine(Add5(2,3,5,6,8));

static void Add()
{
    Console.WriteLine("Added!!");
}

static int Add2(int number1, int number2 = 10) //default değerlerin metot imzasının sonunda olması gerekiyor
{
    var result = number1 + number2;
    return result;
}

static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

static int Add4(out int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

static int Add5(params int[] numbers) //params parametresi öncesinde başka parametrelerde alabilir. params parametresi metodun son parametresi olmak zorunda
{
    return numbers.Sum();
}

static class MultiplyBase
{
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }
}
