namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir sayı giriniz: ");
        string input = Console.ReadLine();

        double input2 = Convert.ToDouble(input);

        double input3 = Math.Round(input2);
        System.Console.WriteLine(input3);
    }
}
