namespace soru6;

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Derece cinsinden bir sayı giriniz: ");
        string cevap = Console.ReadLine();

        double cevap2 = double.Parse(cevap);

        double result = Math.Sin(cevap2);

        System.Console.WriteLine(result);

        


    }
}
