using System.Globalization;

namespace week03_while;

class Program
{
    static void Main(string[] args)
    {

        int input;
        int total = 0;

        System.Console.WriteLine("Pozitif bir sayı giriniz: ");
        input = Convert.ToInt32(Console.ReadLine());

        while (input != 0)
        {
            // Kullanıcı tarafından girilen değeri toplam değişkenine ekle
            total += input;


            // Kullanıcı tarafından girilen değeri ekrana yazdır
            Console.WriteLine("Girdiğiniz sayı: " + input);

            // Toplamı ekrana yazdır
            Console.WriteLine("Girilen sayıların toplamı: " + total);


            // Kullanıcıdan yeni bir sayı girmesini iste
            Console.Write("Bir sayı girin veya programı sonlandırmak için 0'ı tuşlayın.");

            // Yeni girişi al
            input = Convert.ToInt32(Console.ReadLine());
        }


        // Program burada sonlanır
        Console.WriteLine("Program sonlandı.");


    }
}
