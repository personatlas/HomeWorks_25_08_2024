namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir sayı giriniz: ");
        string sayı1 = Console.ReadLine();

        System.Console.WriteLine("Bir sayı daha giriniz: ");
        string sayı2 = Console.ReadLine();

        double sayı1double = double.Parse(sayı1);
        double sayı2double = double.Parse(sayı2);

        double result = Math.Pow(sayı1double, sayı2double);

        System.Console.WriteLine(result);


    }
}
