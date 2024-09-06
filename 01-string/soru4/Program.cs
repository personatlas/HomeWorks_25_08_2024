namespace soru4;

class Program
{
    static void Main(string[] args)
    {
          System.Console.WriteLine("Bir metin giriniz: ");
        string answer = Console.ReadLine();

        string answerTrim = answer.Trim();

        Console.WriteLine($" {answerTrim}");
    }
}
