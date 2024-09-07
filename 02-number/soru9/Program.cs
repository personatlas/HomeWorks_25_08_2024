namespace soru9;

class Program
{
    static void Main(string[] args)
    {

        //  **9.** Kullanıcıdan alınan iki sayı arasındaki küçük olanı bulan bir program yazın.


        System.Console.WriteLine("1.sayıyı giriniz: ");
        string sayı1 = Console.ReadLine();

        System.Console.WriteLine("2.sayıyı giriniz: ");
        string sayı2 = Console.ReadLine();

        double sayı1double = double.Parse(sayı1);
        double sayı2double = double.Parse(sayı2);

        if (sayı1double < sayı2double)
        {
            System.Console.WriteLine($"{sayı2double} > {sayı1double}");
        }




        #region Team
        /* 
                string[] students ={
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
                    "Bedirhan Çay",
                    "Melisa Balcı",
                    "Merve Kahraman",
                    "Kerem Can Kırpar",
                    "Gizem Yüksel",
                    "Burhan Torun2",
                    "Miraç Katmer2",
                    "Bedirhan Çay2",
                    "Melisa Balcı2",
                    "Merve Kahraman2",
                    "Kerem Can Kırpar2",
                    "Gizem Yüksel2",

                };
                string[] teamNames = {

                    "Debuggers",
                    "CodeWars",
                    "Algorithmics",
                     "Debuggers1",
                    "CodeWars2",
                    "Algorithmics3",

                };

                double memberCount = 4;
                int teamCount = (int)Math.Ceiling(students.Length / memberCount);

                string[] teams = new string[teamCount];


                //student dizimizi karıştırıyoruz
                Random rnd = new Random();
                int randomIndex;
                for (int i = 0; i < students.Length; i++)
                {
                    randomIndex = rnd.Next(students.Length);//7
                    string temp = students[i];
                    students[i] = students[randomIndex];
                    students[randomIndex] = temp;
                }

                int teamCounter = 0;
                string currentTeamName;
                for (int i = 0; i < students.Length; i += 4)
                {
                    currentTeamName = teamNames[teamCounter];
                    System.Console.WriteLine($"Takım adı: {currentTeamName} ");
                    for (int j = 0; j < memberCount; j++)
                    {
                        System.Console.WriteLine($"     {students[i + j]}");
                    }
                    System.Console.WriteLine();
                    teamCounter++;
                }

                // foreach (string s in students)
                // {
                //     System.Console.WriteLine(s);
                // }

         */
        #endregion


    }
}
