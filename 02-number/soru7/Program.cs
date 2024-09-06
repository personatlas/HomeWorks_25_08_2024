namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        // double radyan = derece * (Math.PI / 180);

        System.Console.WriteLine("Derece cinsinden bir sayı giriniz: ");
        string cevap = Console.ReadLine();

        double cevap2 = double.Parse(cevap);
        double radyan = cevap2 * (Math.PI / 180);

        System.Console.WriteLine(radyan);





    }
}
