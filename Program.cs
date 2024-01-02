using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace övaöva
{
    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    //public enum Veckodagar
    //{
    //    Måndag,
    //    Tisdag,
    //    Onsdag,
    //    Torsdag,
    //    Fredag,
    //    Lördag,
    //    Söndag
    //}
    public class KöpLista
    {
        public List<string> minLista { get; set; }

        public MinKlass()
        {
            minLista = new List<string>();
            return;
        }
    }

    internal class Program
    {


        //public class Height
        //{

        //    private double _meter;
        //    private double _centimeter;

        //    public Height(double meter, double centimeter)
        //    {
        //        _meter = meter;
        //        _centimeter = centimeter;
        //    }

        //    public Height(double meter)
        //    {
        //        _meter = meter;
        //        _centimeter = 0;
        //    }

        //    public string DisplayHeight()
        //    {
        //        return $"{_meter} meter och {_centimeter} centimeter";
        //    }

        //}



        static void Main(string[] args)
        {
            //    var personInfo = HämtaPersonInfo("Karin Ekenberg", 35, "Utvecklare");

            //    Console.WriteLine($"Namn: {personInfo.Namn}, Ålder: {personInfo.Ålder}, Yrke: {personInfo.Yrke}");
            //}

            //static (string Namn, int Ålder, string Yrke) HämtaPersonInfo(string namn, int ålder, string yrke)
            //{
            //    return (Namn: namn, Ålder: ålder, Yrke: yrke);
            //}
            //Veckodagar dag1 = Veckodagar.Måndag;
            //Veckodagar dag2 = Veckodagar.Onsdag;

            //Console.WriteLine("Dag ett: " + dag1);
            //Console.WriteLine("Dag två: " + dag2);

            //string dag1Sträng = dag1.ToString();
            //Console.WriteLine("Dag ett som sträng: " + dag1Sträng);

            //if (Enum.TryParse("Fredag", out Veckodagar dag3))
            //{
            //    Console.WriteLine("Dag tre: " + dag3);
            //}
            //else
            //{
            //    Console.WriteLine("Ogiltig dag...");
            //}

            //Person person1 = new Person();
            //person1.Name = "Karin";
            //person1.Age = 35;

            //string namn = person1.Name;
            //int age = person1.Age;

            //Console.WriteLine($"Namn: {namn}, Ålder: {age}...");

            //Height height1 = new Height(1.75, 30.5);
            //Height height2 = new Height(1.55, 22.2);
            //Console.WriteLine("Höjd 1: " + height1.DisplayHeight());
            //Console.WriteLine("Höjd 2: " + height2.DisplayHeight());

            //Console.WriteLine("Välkommen.");
            //Console.WriteLine("Mata in höjd på triangeln:");
            //int höjd = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mata in bredd på triangeln:");
            //int bredd = int.Parse(Console.ReadLine());
            //int arean = höjd * bredd / 2;
            //Console.WriteLine("Arean av triangeln är: " + arean);

            //Console.WriteLine("Vilket land vann fotbolls VM för damere 2015?");
            //string input = Console.ReadLine().ToUpper();
            //if (input == "USA")
            //{
            //    Console.WriteLine("Du har rätt!");
            //}else
            //{
            //    Console.WriteLine("Fel...");
            //}

            //int averageAge = 39;
            //int avarageSalary = 36100;
            //Console.WriteLine("Hur gammal är du?");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hur mycket tjänar du?");
            //int salary = int.Parse(Console.ReadLine());
            //if (age == averageAge)
            //{
            //    Console.WriteLine("Du är medelålders i Göteborg!");
            //}
            //else if (age < averageAge)
            //{
            //    Console.WriteLine("Du är yngre än genomsnittet i Göteborg!");
            //}
            //else
            //{
            //    Console.WriteLine("Du är äldre än genomsnittet i Göteborg!");
            //}
            //if (salary == avarageSalary)
            //{
            //    Console.WriteLine("Du tjänar som genomsnittet i Sverige!");
            //}
            //else if (salary < avarageSalary)
            //{
            //    Console.WriteLine("Du tjänar mindre än genomsnittet i Sverige! Trist!");
            //}
            //else
            //{
            //    Console.WriteLine("Du tjänar mer än genomsnittet i Sverige! Grattis");
            //}

            //Console.WriteLine("Vad heter du?");
            //string namn = Console.ReadLine().ToLower();

            //if (namn == "felicia" || namn == "felix")
            //{
            //    Console.WriteLine("Du får gå på först för det är din namnsdag!");
            //    return;
            //}
            //Console.WriteLine("Hur gammal är du?");
            //int ålder = int.Parse(Console.ReadLine());
            //if (ålder > 75)
            //{
            //    Console.WriteLine("Ni får gå på efter namnsdagsbarnen!");
            //}
            //else if (ålder > 17 && ålder < 26)
            //{
            //    Console.WriteLine("Ni får gå på efter gamlingarna!");
            //}else
            //{
            //    Console.WriteLine("Ni får gå på sist!");
            //}

            //Console.WriteLine("Erbjudande!! Billigit kaffe för de som är 65+ eller mellan 10-17 år.");
            //Console.WriteLine("--------------------------------------------------------------------");
            //Console.WriteLine("Hur gammal är du?");
            //int ålder = int.Parse(Console.ReadLine());
            //if (ålder > 64 || ålder > 10 && ålder < 18)
            //{
            //    Console.WriteLine("Du får billigt kaffe!");
            //}
            //else
            //{
            //    Console.WriteLine("Du får betala fullt pris för kaffet! Tyvärr...");
            //}

            //Console.WriteLine("Ange ett heltal:");
            //int nummer = int.Parse(Console.ReadLine());

            //int summa = 0;
            //for (int i = 1; i <= nummer; i++)
            //{
            //    summa += i;
            //}

            //long fakultet = 1;
            //for (int i = 1; i <= nummer; i++)
            //{
            //    fakultet *= i;
            //}

            //Console.WriteLine($"Summan av siffrorna från 1 till {nummer} är: {summa}");
            //Console.WriteLine($"Fakulteten av {nummer} är: {fakultet}");


            //    bool minBool = true;
            //    while (minBool)
            //    {
            //        Console.WriteLine("Välkommen! Var god gör ditt val:");
            //        Console.WriteLine("1. Omvandla meter till kilometer.");
            //        Console.WriteLine("2. Omvandla kilometer till meter.");
            //        Console.WriteLine("3. Avsluta programmet.");
            //        double input = double.Parse(Console.ReadLine());
            //        switch (input)
            //        {
            //            case 1:
            //                Console.WriteLine("Ange hur många meter du vill omvandla till kilometer:");
            //                double mToKm = double.Parse(Console.ReadLine());
            //                double km = mToKm / 1000;
            //                Console.WriteLine("Det är " + km + "km.");
            //                break;
            //            case 2:
            //                Console.WriteLine("Ange hur många kilometer du vill omvandla till meter:");
            //                double kmToM = double.Parse(Console.ReadLine());
            //                double m = kmToM * 1000;
            //                Console.WriteLine("Det är " + m + "m.");
            //                break; 
            //            case 3:
            //                Console.WriteLine("Programmet avslutas..");
            //                minBool = false;
            //                break;
            //            default:
            //                Console.WriteLine("Felaktigt val.");
            //                break;
            //        }
            //    }
            //    Console.WriteLine();

            //double nuvarandeVärde = 1000;
            //double ränta = 2.2;
            //double önskatVärde = 1500;

            //double växandeVärde = Math.Log(önskatVärde / nuvarandeVärde) / Math.Log(1 * ränta);
            //Console.WriteLine("Det tar " + växandeVärde + " år för värdet att gå upp 500kr.");

            //for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("Vilket är Europas största land?");
            //     string input = Console.ReadLine().ToLower();
            //     if (input == "ryssland")
            //     {
            //         Console.WriteLine("Rätt! Vilket proffs!! =)");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Fel.. Försök igen!");
            //     }
            // }

            //Console.WriteLine("Gör en rektangel!!");
            //Console.WriteLine("Ange bredd på rektangeln med heltal:");
            //int bredd = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ange höjden av rektangeln med heltal:");
            //int höjd = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < höjd; i++)
            //{
            //    for (int j = 0; j < bredd; j++)
            //    {
            //        if (i == 0 || i == höjd - 1 || j == 0 || j == bredd - 1)
            //        {
            //            Console.Write("X");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();

            //}

            //Console.WriteLine("Hej");
            //Thread.Sleep(3000);
            //Console.WriteLine("Hur mår du?");

            //Console.WriteLine("Hur många sporter har du testat?");
            //int antal = int.Parse(Console.ReadLine());
            //string[] sport = new string[antal];

            //for (int i = 0; i < antal; i++)
            //{
            //    Console.WriteLine("Ange en av sporterna:");
            //    sport[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Du har testat följande sporter:");
            //for (int i = 0; i < antal; i++)
            //{
            //    Console.WriteLine(sport[i]);
            //}

            //int[] tal = {1, 2, 3, 4, 5 };
            //int summa = 0;

            //foreach (int nummer in tal)
            //{
            //    summa += nummer;
            //}
            //Console.WriteLine(summa);

            //string[] strängLista = { "Korv", "Bröd", "Ketchup", "Senap" };
            //Console.WriteLine("Osorterad lista:");
            //PrintaArray(strängLista);
            //Array.Sort(strängLista);
            //Console.WriteLine("Sorterad lista");
            //PrintaArray(strängLista);

            //static void PrintaArray(string[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] talen = { 1, 52, 13, 43, 52, 61, 22, 88 };
            //Console.WriteLine("Osorterad lista:");
            //PrintaArray(talen);
            //Console.WriteLine("Sorterad lista:");
            //Array.Sort(talen);
            //PrintaArray(talen);
            //Console.WriteLine("Omvänd lista:");
            //Array.Reverse(talen);
            //PrintaArray(talen);

            //static void PrintaArray(int[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //    int nedreGransvarde = 10;
            //    RäknaNer(nedreGransvarde);
            //}

            //static void RäknaNer(int nuvarandeNummer)
            //{
            //    if (nuvarandeNummer < 1)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        Console.Write(nuvarandeNummer + " ");
            //        RäknaNer(nuvarandeNummer - 1);
            //    }

            //}


            //Person();

            //static void Person()
            //{
            //    Console.WriteLine("Hej Karin!");
            //}


            //    WelcomeClass welcomeClass = new WelcomeClass();
            //    welcomeClass.WelcomeMessage();
            //}
            //    public class WelcomeClass {

            //    public void WelcomeMessage()
            //    {
            //        Console.WriteLine("Välkommen till 00P..");
            //    }

            //    }

            //List<int> intCollection = new List<int> { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Del 1: Collection av int-typen");
            //foreach (int num in intCollection)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine(); 
            //List<string> stringCollection = new List<string> { "Äpple", "Banan", "Apelsin", "Mango", "Kiwi" };
            //string[] stringArray = stringCollection.ToArray();

            //Console.WriteLine("\nDel 2: Collection av string-typen kopierad till Array");
            //foreach (string fruit in stringArray)
            //{
            //    Console.Write(fruit + " ");
            //}
            //Console.WriteLine();


           
        }

    }
}

