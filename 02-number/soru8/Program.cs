namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        // Math.Log(double x) 
        // double logValue = Math.Log(2.718281828459); // logValue ≈ 1
        // **8.** Kullanıcıdan alınan bir sayının logaritmasını (doğal logaritma) hesaplayan bir program yazın.


        System.Console.WriteLine("Derece cinsinden bir sayı giriniz: ");
        string cevap = Console.ReadLine();

        double cevap2 = double.Parse(cevap);

        double result = Math.Log(cevap2);

        System.Console.WriteLine($"Sayı {cevap} için doğal logaritma değeri: {result}");





    }
}
