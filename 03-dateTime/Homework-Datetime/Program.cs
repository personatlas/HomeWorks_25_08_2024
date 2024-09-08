using System.Diagnostics.CodeAnalysis;

namespace Homework_Datetime;

class Program
{
    static void Main(string[] args)
    {


        #region homework01

        // - [] * *1.* *Kullanıcıdan alınan bir tarihin haftanın hangi günü olduğunu bulan bir program yazın.

        // Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        // string input = Console.ReadLine();

        // DateTime date = DateTime.Parse(input);
        // Console.WriteLine($"Tarih: {date.ToShortDateString()}, Haftanın Günü: {date.DayOfWeek}");
        #endregion

        #region homework02
        // - [] * *2.* *Şu anki tarih ve saati ekrana yazdıran bir program yazın.


        // DateTime input = DateTime.Now;

        // System.Console.WriteLine($"Şimdiki tarih ve saat: {input}");



        #endregion


        #region homework03
        // - [] * *3.* *Kullanıcıdan alınan bir tarihe belirli bir gün sayısı ekleyerek yeni tarihi bulan bir program yazın.

        System.Console.WriteLine("Bir gün giriniz:");
        string input = Console.ReadLine();

        DateTime result = DateTime.Parse(input);

         System.Console.WriteLine(DateTime.Now.AddDays(12));


        // System.Console.WriteLine($"3 ay sonraki tarih: {now.AddMonths(3)}");
        #endregion




        // - [] * *4.* *İki tarih arasındaki gün farkını hesaplayan bir program yazın.

        // - [] * *5.* *Kullanıcıdan alınan bir tarihin yılın kaçıncı günü olduğunu hesaplayan bir program yazın.

        // - [] * *6.* *Kullanıcıdan alınan bir yılın artık yıl olup olmadığını kontrol eden bir program yazın.

        // - [] * *7.* *Belirli bir tarih formatında(örneğin, "dd/MM/yyyy") girilen bir tarihi DateTime nesnesine çeviren ve ekrana yazdıran bir program yazın.

        // - [] * *8.* *Şu anki tarihin ay adını tam olarak yazdıran bir program yazın(örneğin, "Ağustos").

        // - [] * *9.* *Kullanıcıdan alınan bir tarihin, başka bir kullanıcıdan alınan tarihten önce mi, sonra mı yoksa aynı mı olduğunu kontrol eden bir program yazın.

        // - [] * *10.* *Kullanıcıdan alınan bir saati, 12 saat formatından 24 saat formatına(veya tam tersi) çeviren bir program yazın.


    }
}
