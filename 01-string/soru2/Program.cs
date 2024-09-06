namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir metin yazınız: ");

        string sent = Console.ReadLine();

        string sentLow = sent.ToLower();
        string sentUp = sent.ToUpper();


        Console.WriteLine($"lower : {sentLow} \nupper: {sentUp}");
    }
}
