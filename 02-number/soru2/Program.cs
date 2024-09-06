namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir sayı giriniz: ");
        string input = Console.ReadLine();

        System.Console.WriteLine("Bir başka sayı giriniz: ");
        string input2 = Console.ReadLine();

        int input3 = Convert.ToInt32(input);
        int input4 = Convert.ToInt32(input2);

        double maxValue = Math.Max(input3, input4);

        System.Console.WriteLine(maxValue);
    }
}
