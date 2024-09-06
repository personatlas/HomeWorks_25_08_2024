namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        // Math.Log(double x) 


        System.Console.WriteLine("Derece cinsinden bir sayı giriniz: ");
        string cevap = Console.ReadLine();

        double cevap2 = double.Parse(cevap);

        double result = Math.Log(cevap2);

        System.Console.WriteLine($"Sayı {cevap} için doğal logaritma değeri: {result}");
    }
}
