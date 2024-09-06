namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        // //**1.** Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın. (`Split` metodunu araştırınız.)

        // Kullanıcıdan cümleyi al
        // Console.Write("Lütfen bir cümle girin: ");
        // string sent = Console.ReadLine();


        // string[] vocab = sent.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        // int vocabNumber = vocab.Length;

        // Sonucu ekrana yazdır
        // / Console.WriteLine("Cümledeki kelime sayısı: " + vocabNumber);

        //         Bu programın çalışma mantığı şu şekildedir:

        // Console.ReadLine() fonksiyonu kullanılarak kullanıcıdan bir cümle alınır.
        // Split() metodu, cümleyi boşluk ve tab karakterlerine göre ayırarak bir kelime dizisi oluşturur.StringSplitOptions.RemoveEmptyEntries seçeneği, boş girişleri yok sayarak sadece geçerli kelimeleri sayar.
        // kelimeler.Length ifadesi, kelime dizisinin uzunluğunu yani kelime sayısını hesaplar.
        // Sonuç, Console.WriteLine() ile ekrana yazdırılır.
        // Bu kod, kullanıcıdan gelen cümledeki kelimeleri saymak için oldukça basit ve etkili bir yöntemdir.
    }
}
