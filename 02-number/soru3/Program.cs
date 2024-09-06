namespace soru3;

class Program
{
    static void Main(string[] args)
    {
         System.Console.WriteLine("Bir sayı giriniz : ");
        string ans = Console.ReadLine();

        double ansdob = double.Parse(ans);

        double result = Math.Abs(ansdob);

        System.Console.WriteLine(result);
    }
}
