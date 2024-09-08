namespace projeMethod;

class Program
{

    //Kendisine gönderilen int tipindeki sayı listesinden yer alan negatif sayıları geri döndüren bir metod hazırlayınız.

    /*  static List<int> GetNegativeNumbers(List<int> numbers)
     {
         List<int> negativeNumbers = new List<int>();
         foreach (var number in numbers)
         {
             if (number < 0)
             {
                 negativeNumbers.Add(number);
             }
         }
         return negativeNumbers;
     } */

    /*   static int TotalOfSquaers(int number1, int number2)
      {
          int result = number1*number1 + number2* number2;
          return result;

      } */

    static void RandomStudents(string[] students)
    {
        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length);//7
            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex] = temp;
        }
    }

    static void AssignToTeams(string[] students, string[] teamNames, double memberCount)
    {
        int teamCounter = 0;
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
    }

    static string[] GetStudents()
    {
        return [
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
       ];
    }
    static string[] GetTeamNames()
    {
        return [ "Debuggers",
            "CodeWars",
            "Algorithmics",
            "BinaryCoders",
            "NullPointers",
            "DevDynamics"]
    }
    static void Main(string[] args)
    {
        /*  List<int> numbers = [5, 7, 8, -5, -4, 3, -12, 4, 5, 7];
         List<int> resultnumbers = GetNegativeNumbers(numbers);
         foreach (var number in resultnumbers)
         {
             System.Console.WriteLine(number);
         } */

        //TotalOfSquaers(5,7);// 5 ve 7nin karelerini bulup toplayıp, geri döndüren metot.
        // System.Console.WriteLine(TotalOfSquaers(3,2));


        string[] students = GetStudents();
        string[] teamNames = GetTeamNames();

        double memberCount = 4;
        int teamCount = (int)Math.Ceiling(students.Length / memberCount);
        string[] teams = new string[teamCount];
        RandomStudents(students);
        // ref kullanarak yaparsak ne olur? 
        AssignToTeams(students, teamNames, memberCount);





    }
}
