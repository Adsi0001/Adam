using System;

class Program
{
    static void Main()
    {
        // Gå igennem tal fra 1 til 100. Fortsætter så længe "i" er mindre end eller lig med 100.
        for (int i = 1; i <= 100; i++)
        {
            // Beder brugeren om at skrive Fizz, Buzz, FizzBuzz eller tallet.
            Console.WriteLine($"Skriv hvad du tror, {i} skal være (Fizz, Buzz, FizzBuzz eller tallet): ");
            string input = Console.ReadLine().ToLower();

            // Tjek input. Hvis "i" er et tal der går op i både 3 og 5, og brugeren svarer "fizzbuzz" fortsætter programmet
            if (i % 3 == 0 && i % 5 == 0)
            {
                if (input != "fizzbuzz")
                {
                    Console.WriteLine("Forkert! Programmet afsluttes.");
                    break; // afslutter programmet hvis brugeren svarer forkert
                }
            }
            // Tjek input. Hvis "i" er et tal der går op i 3, og brugeren svarer "fizz" fortsætter programmet
            else if (i % 3 == 0)
            {
                if (input != "fizz")
                {
                    Console.WriteLine("Forkert! Programmet afsluttes.");
                    break; // afslutter programmet hvis brugeren svarer forkert
                }
            }
            // Tjek input. Hvis "i" er et tal der går op i 5, og brugeren svarer "buzz" fortsætter programmet
            else if (i % 5 == 0)
            {
                if (input != "buzz")
                {
                    Console.WriteLine("Forkert! Programmet afsluttes.");
                    break; // afslutter programmet hvis brugeren svarer forkert
                }
            }
            else
            {
                if (input != i.ToString())
                {
                    Console.WriteLine("Forkert! Programmet afsluttes.");
                    break; // afslutter programmet hvis brugeren skriver et forkert tal eller noget andet
                }
            }
        }
    }
}
