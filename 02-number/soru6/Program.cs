namespace soru6;

class Program
{
    static void Main(string[] args)
    {

        //**6.** Kullanıcıdan alınan bir sayının trigonometrik sinüs değerini hesaplayan bir program yazın.
        
        System.Console.WriteLine("Derece cinsinden bir sayı giriniz: ");
        double cevap = Convert.ToDouble(Console.ReadLine());

        double result = Math.Sin(cevap);

        System.Console.WriteLine(result);






    }
}
