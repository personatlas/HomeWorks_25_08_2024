namespace soru3;

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Bir tam sayı giniz: ");
        int input = Convert.ToInt32(Console.ReadLine());

        while (input < 0)
        {
            System.Console.WriteLine("Program tamamlandı.");
            System.Console.WriteLine($" Bir değişkenin kareleri: ({input * input})");
            break;

        }

        System.Console.WriteLine("Bir başka değer giriniz :");
        int input2 = Convert.ToInt32(Console.ReadLine);


    }
}
