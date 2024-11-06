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

        Console.WriteLine("Hvilken dato har vi i dag?");
        string dato = Console.ReadLine();

        Console.WriteLine("Hvad er din livret?");
        string food = Console.ReadLine();

        Console.WriteLine("Hvad er dit yndlings computerspil?");
        string game = Console.ReadLine();

        Console.WriteLine("Hvilken følese får du af at spille?");
        string feeling = Console.ReadLine();

        Console.WriteLine("Hvad er din yndlings øl?");
        string beer = Console.ReadLine();

        Console.WriteLine("Hvilken Monster er din favorit?");
        string monster = Console.ReadLine();

        Console.WriteLine("Sidste spørgsmål. Hvad er din skostørrelse?");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Okay, " + name + ". Du har besvaret spørgsmålene succesfuldt i dag, d. " + dato + ". Du er " + age + " år gammel og kommer fra " + home + ".");
        Console.WriteLine("Du kan godt lide " + food + " sammen med en " + beer + ", eller en " + monster + " Monster.");
        Console.WriteLine("Din fritid bruger du på at spille " + game + ", og det giver dig en følelse af " + feeling + ".");
        Console.WriteLine("Din skostørrelse er " + size + ".");

       Console.ReadKey();
    }
}