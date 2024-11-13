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

        Console.WriteLine("Hvilken dag er det i dag? (1 = mandag, 2 = tirsdag, ... 7 = søndag).");
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


        Console.WriteLine("Kan du lide pizza? (ja/nej)");
            string pizza = Console.ReadLine().ToLower();
                if (pizza == "ja")
                    Console.WriteLine("Du har valgt ja.");
                else if (pizza == "nej")    
                    Console.WriteLine("Du har valgt nej.");
                else
                    Console.WriteLine("Ugyldigt input. Venligst skriv 'ja' eller 'nej'.");

        Console.WriteLine("Hvad er dit yndlings computerspil?");
            string game = Console.ReadLine();

        Console.WriteLine("Hvilken følese får du af at spille?");
            string feeling = Console.ReadLine();

        Console.WriteLine("Hvad er din yndlings øl?");
            string beer = Console.ReadLine();

        Console.WriteLine("Hvilken Monster er din favorit?");
            string monster = Console.ReadLine();

        Console.WriteLine("Sidste spørgsmål. Har du en bil? (ja/nej)");
            string input = Console.ReadLine().ToLower();
            bool harDuBil = (input == "ja");
            string harDuBilString;

                if (harDuBil)
                    harDuBilString = "Du har en bil.";
                else
                    harDuBilString = "Du har ikke en bil.";

        Console.WriteLine("Okay, " + name + ". Du har besvaret spørgsmålene succesfuldt. I dag er det " + dag + ". Du er " + age + " år gammel og kommer fra " + home + ".");
        Console.WriteLine("Du har svaret " + pizza + " til at kunne lide pizza. Du drikker gerne en " + beer + ", eller en " + monster + " Monster.");
        Console.WriteLine("Din fritid bruger du på at spille " + game + ", og det giver dig en følelse af " + feeling + ".");
        Console.WriteLine(harDuBilString);


        Console.ReadKey();
    }
}