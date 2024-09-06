namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir sayı giriniz: ");
        string input = Console.ReadLine();

        double input2 = double.Parse(input);

        double kare = Math.Sqrt(input2);

        System.Console.WriteLine(kare);

    }
}
