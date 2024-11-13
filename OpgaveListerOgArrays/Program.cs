internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hej, i dette program vil du blive stillet nogle spørgsmål.");
        Console.WriteLine("Hvad er dit navn? ");
        string name = Console.ReadLine();

        Console.WriteLine("Hvor gammel er du? ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hej, " + name + "!");
        Console.WriteLine("Du er " + age + " år gammel.");

        Console.WriteLine("Okay, " + name + ". Nu kommer der nogle lidt mere dybdegående spørgsmål.");

        Console.WriteLine("Hvor kommer du fra?");
        string home = Console.ReadLine();

        Console.WriteLine("Hvilken dag er det i dag? (1 = mandag, 2 = tirsdag, ... 7 = søndag)."); //Beder brugeren besvare spørgsmålet og giver instrukser til hvordan
        string dag = Console.ReadLine();

        if (int.TryParse(dag, out int dayNumber))
        {
            if (Enum.IsDefined(typeof(DayOfWeek), dayNumber))
            {
                DayOfWeek day = (DayOfWeek)dayNumber;
                Console.WriteLine($"I dag er det {day}.");
            }
            else
            {
                Console.WriteLine("Ugyldigt tal. Vælg et tal mellem 1 og 7.");
            }
        }
        else
        {
            Console.WriteLine("Ugyldigt input. Vælg et tal mellem 1 og 7.");
        }


        Console.WriteLine("Kan du lide pizza? (ja/nej) ");
        string pizza = Console.ReadLine().ToLower();
        if (pizza == "ja")
            Console.WriteLine("Du har valgt ja.");
        else if (pizza == "nej")
            Console.WriteLine("Du har valgt nej.");
        else
            Console.WriteLine("Ugyldigt input. Venligst skriv 'ja' eller 'nej'.");

        Console.WriteLine("Kan du lide CS2? (ja/nej) "); // Stiller brugeren et spørgsmål hvor svaret skal være enten j eller n
        string cs;
        cs = Console.ReadLine().ToLower(); // Laver input om til små bogstaver

        if (cs == "ja") // Er inputtet "ja", returnerer programmet nedenstående sætning.
            Console.WriteLine("Det er også et godt spil.");
        else if (cs == "nej") // Er inputtet "nej", returnerer programmet nedenstående sætning.
            Console.WriteLine("Hver sin smag.");
        else
            Console.WriteLine("Svar venligst enten ja eller nej. "); // Beder brugeren om at skrive enten ja eller nej i svaret, brugeren har svaret noget andet end det.

        Console.WriteLine("Hvilken følese får du af at spille?");
        string feeling = Console.ReadLine();

        Console.WriteLine("Hvad er din yndlings øl?");
        string beer = Console.ReadLine();

        Console.WriteLine("Hvor mange energidrik drikker du om dagen?");
        
         
           //Dette skal være en array, lav det inden du afleverer!!!!!!!!!!!!



        Console.WriteLine("Sidste spørgsmål. Har du en bil? (ja/nej)"); //Spørger brugeren og giver instrukser til svar
        string input = Console.ReadLine().ToLower(); //Sørger for svaret bliver med små bogstaver
        bool harDuBil = (input == "ja"); //Svaret skal være "ja" med små bogstaver
        string harDuBilString;

        if (harDuBil)
            harDuBilString = "Du har en bil."; //Hvis brugeren svarer ja, svarer programmet "Du har en bil"
        else if (harDuBil = false)
            harDuBilString = "Du har ikke en bil."; //Hvis brugeren svarer nej, svarer programmet "Du har en bil"
        else
            Console.WriteLine("Svar venligst ja eller nej.");
        
        Console.ReadKey();
    }
}
