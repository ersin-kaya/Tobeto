string sentence = "My name is Engin Demiroğ";

var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Derin Demiroğ";

bool result3 = sentence.EndsWith("ğ");
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name"); //3. indexten başlıyor
result5 = sentence.IndexOf("nae"); //-1
var result6 = sentence.IndexOf(" "); //bulduğu ilk boşluğun index'ini alır
var result7 = sentence.LastIndexOf(" "); //aramaya string'in sonundan başlar ancak index değeri yine baştan hesaplanır
var result8 = sentence.Insert(0, "Hi, "); //0.karakterden itibaren verilen ifadeyi ekler ancak string'i değiştirmez
var result9 = sentence.Substring(3); //3. karakterden itibaren alır, string'i değiştirmez
var result10 = sentence.Substring(3, 4); //3. karakterden itibaren ilk 4 karakteri alır
var result11 = sentence.ToLower();
var result12 = sentence.ToUpper();
var result13 = sentence.Replace(" ", "-");
var result14 = sentence.Remove(2); //2. index'i ve sonrasını çıkartır
var result15 = sentence.Remove(2, 1); //2. index'ten itibaren 1 karakter çıkartır

Console.WriteLine(result15);
//Console.WriteLine(sentence);


static void Intro()
{
    string city = "Ankara"; //aynı zamanda bir char[]'dir
                            //Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";
    //string result = String.Format("{0} {1}", city2, city);

    Console.WriteLine(String.Format("{0} {1}", city2, city)); //Console.WriteLine'da zaten formatlı bir string kabul eder o yüzden burada yazmak gereksiz oluyor
}