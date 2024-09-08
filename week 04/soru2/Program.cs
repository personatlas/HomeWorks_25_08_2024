namespace soru2;

class Program
{
    static void Main(string[] args)
    {


        // int [] numbers ={49, 34, 90,67, 42}; // boyutu 5 

        // string[] studentNames = {
        //     "Ali",
        //     "Ayşe",
        //     "Murat",
        //     "Irmak",
        //     "Sezen",
        // };

        //  for (int i = 0; i < studentNames.Length; i++)
        // {
        //     Console.WriteLine(studentNames[i]);

        // }

        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     studentNames[i] += " Canoğlu";

        // }
        // System.Console.WriteLine();
        // System.Console.WriteLine("Değişmiş Hali:");

        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     Console.WriteLine(studentNames[i]);

        // }

        // string[] studentNames = {
        //     "Ali",
        //     "Ayşe",
        //     "Murat",
        //     "Irmak",
        //     "Sezen",
        // };

        // foreach (string student in studentNames)
        // {
        //     System.Console.WriteLine(student);
        // }

        // // // int[] price = { 40, 50, 20, 60, 70, 80 };
        // // // //price dizisinin içindeki fiyatlara  yüzde on zam gelmiştir. Zamlı giyatları içerecek şekilde güncellenecek kodu yazınız.

        // // // System.Console.WriteLine("Fiyatların zamsız hali: ");
        // // // for (int i = 0; i < price.Length; i++)
        // // // {
        // // //     Console.WriteLine(price[i]);

        // // // }
        // // // System.Console.WriteLine();
        // // // System.Console.WriteLine("Fiyatların %10 zamlı hali:");

        // // // for (int i = 0; i < price.Length; i++)
        // // // {
        // // //     price[i] = ((price[i] * 10) / 100) + price[i];

        // // //     System.Console.WriteLine(price[i]);
        // // // }


        #region yeni soru
        //a= 40 b=50 c=45 en büyüğünü bulduran kod

        // int a =400;
        // int b =50;
        // int c =450;

        // int max= int.MinValue;
        // if (a>max)
        // {
        //     max=a;
        // } 
        // if (b>max)
        // {
        //     max=b;
        // }
        // if (c>max)
        // {
        //     max=c;
        // }

        // System.Console.WriteLine(max);
        #endregion

        #region yeni soru 2

        // // //20 elemanlı bir int dizisine 1 ile 100 arasında rastgele değerler atayalım. Ardından bu dizinin min ve max değerini tespit edip ekrana yazdıralım.

        // // // dizimizi oluşturup içine rastgele değerler atıyoruz.
        // // Random rnd = new Random(); // bu kod çok önemli oop de.
        // // int[] numbers = new int[20];

        // // for (int i = 0; i < numbers.Length; i++)
        // // {
        // //     numbers[i] = rnd.Next(1, 11);
        // //     System.Console.WriteLine(numbers[i]);
        // // }

        // // // min ve maxı bulduruyoruz
        // // int max = int.MinValue;
        // // int min = int.MaxValue;

        // // foreach (var number in numbers)
        // // {
        // //     if (number > max) max = number;
        // //     if (number < min) min = number;

        // // }

        // // // min ve max değerlerinin yazdırıyoruz
        // // System.Console.WriteLine($"en büyük sayı: {max} ve en küçük sayı : {min
        // // }");


        #endregion

        #region yeniSoru3

        // dizimizi oluşturup içine rastgele değerler atıyoruz.
        // Random rnd = new Random(); // bu kod çok önemli oop de.
        // int[] numbers = new int[20];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);
        //     System.Console.WriteLine(numbers[i]);

        // }

        // Array.Sort(numbers); // bu kod küçükten büyüğe sıralama
        // System.Console.WriteLine("dizinin k ten büyüğe sıralı hali : ");
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine(numbers[i]);
        // }

        // Array.Reverse(numbers); // bu kod büyükten küçüye sıralama
        // System.Console.WriteLine("dizinin büyükten küçüğesıralı hali : ");
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine(numbers[i]);
        // }














        #endregion

        #region yeniSoru4

        // // dizimizi oluşturup içine rastgele değerler atıyoruz.
        // Random rnd = new Random(); // bu kod çok önemli oop de.
        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);
        //     //  System.Console.WriteLine($"Index: {i} - Number:  {numbers[i]} ");

        // }
        // numbers[0] = 99;
        // for (int i = 0; i < numbers.Length; i++)
        // {

        //     System.Console.WriteLine($"Index: {i} - Number:  {numbers[i]} ");

        // }
        // System.Console.WriteLine(Array.IndexOf(numbers, "engin"));




        #endregion

        #region yeniSoru5


        // string firstName = "Alex de Souza";
        // System.Console.WriteLine(firstName[3]);

        // string text = "Macbook ile Yazılım Geliştirme Ortamının Hazırlanması";
        // string[] result = text.Split("-");
        // System.Console.WriteLine(result[0]);





        #endregion

        #region soru06

        // Kullanıcıdan alınan bir cümlede belirli bir kelimenin kaç kez geçtiğini bulan bir program yazın. (`Split` metodunu araştırınız.)

        // string text = "çok hava çok güzel ";
        // string[] result = text.Split("çok");
        // int wordCount = result.Length-1;
        // System.Console.WriteLine(wordCount);
        #endregion

        #region DİZİLERİ KOPYALAMAK
        //DİZİLERİ KOPYALAMAK

        // string[] names = {"Ayşen" , "Umay", "Ceyda", "Begüm"};
        // string[] newNames = names ; 
        // names[0]="Heda";
        // System.Console.WriteLine(newNames[]);

        // string[] names = { "Ayşen", "Umay", "Ceyda", "Begüm" };
        // string[] newNames = new string[names.Length];
        // Array.Copy(names, newNames, 4);
        // foreach (var name in names)
        // {
        //     System.Console.WriteLine(name);
        // }
        // newNames[0]="Heda";
        // foreach (var name in newNames)
        // {
        //     System.Console.WriteLine(name);
        // }




        #endregion

        #region DİZİDE VAR YOK KONTROLÜ YAPMAK
        // int[] numbers = { 3, 6, 7, 12 };
        // bool exist = Array.Exists(numbers, n => n > 10);
        // System.Console.WriteLine(exist ? "var" : "Yok");

        #endregion

        #region DİZİDE BELİRTİLEN KOŞULA UYGUN İLK ELEMANI GETİRMEK
        // int[] numbers = { 3, 6, 7, 12 };
        // int result = Array.Find(numbers, n => n == 6);
        // System.Console.WriteLine(result);

        #endregion

        #region DİZİDE BELİRTİLEN KOŞULA UYGUN tüm ELEMANI GETİRMEK
        // int[] numbers = { 3, 6, 7, 12 };
        // int[] result = Array.FindAll(numbers, x => x > 6);
        // foreach (var n in result)
        // {
        //     System.Console.WriteLine(n);
        // }

        #endregion

        #region DİZİNİN ELEMAN SAYISINI(BOYUTUNU) DEĞİŞTİRMEK
        // int[] numbers = { 3, 6, 8 };
        // System.Console.WriteLine(numbers.Length);
        // Array.Resize(ref numbers, numbers.Length+1);
        // numbers[3] = 55;
        // System.Console.WriteLine(numbers.Length);







        #endregion

        #region DİZİNİN BELİRLİ BİR BÖLÜMÜNÜ TEMİZLEMEK

    
        // int[] numbers = [3, 4, 6, 7, 45, 11, ];
        // System.Console.WriteLine("Dizinin orjinal hali: ");
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }
        // System.Console.WriteLine();
        // Array.Clear(numbers, 2, 3);
        //  System.Console.WriteLine("Dizinin temizlenmiş hali: ");
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }





        #endregion

        #region RASTGELE GRUP OLUŞTURMA
            

        #endregion

    #region grup atama
        /* string[] students ={
            "Hakan Çakdı",
            "Tunacan Eşki",
            "Rojin Çetiz",
            "Elif Öztürk",
            "Ömer Taştekin",
            "Enes Kılıçaslan",
            "Atlas Uyar",
            "Erdem Yüce Gül",
            "Enes Can Aydemir",
            "Irmak Özen",
            "Burhan Torun",
            "Miraç Katmer",
            "Bedirhan Çaylı",
            "Melina Balcı",
            "Merve Kahraman",
            "Kerem Can Kırpar",
            "Gizem Yüksel",
            "Celal Uğur Koçan",
            "Tahir Burak Avar",
            "Samet Önür",
            "Aleyna Çelen",
            "Elifnur Binici",
            "Doğukan Babayiğit",
            "Emre Kılıç"
        };

        string[] teamNames = {
            "Debuggers",
            "CodeWars",
            "Algorithmics",
            "BinaryCoders",
            "NullPointers",
            "DevDynamics"
        };

        double memberCount = 4;
        int teamCount = (int)Math.Ceiling(students.Length / memberCount);

        string[] teams = new string[teamCount];

        //Students dizimizi karıştırıyoruz
        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length);//7
            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex] = temp;
        }

        int teamCounter=0;
        string currentTeamName;
        for (int i = 0; i < students.Length; i += 4)
        {
            currentTeamName = teamNames[teamCounter];
            Console.WriteLine($"Takım Adı: {currentTeamName}");
            for (int j = 0; j < memberCount; j++)
            {
                Console.WriteLine($"\t\t-{students[i + j]}");
            }
            Console.WriteLine();
            teamCounter++;
        }
 */


    #endregion
    }
}
