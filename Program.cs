namespace CarApp;

class Program
{
    static void Main(string[] args)
    {
        // Spørg brugeren om biloplysninger og gem input i variabler
        Console.Write("Indtast dit bilmærke: ");
        string brand = Console.ReadLine();

        Console.Write("Indtast din bilmodel: ");
        string model = Console.ReadLine();

        Console.Write("Indtast bilens årgang: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Indtast geartype (A for automatisk, M for manuel): ");
        char gearType = Console.ReadLine()[0]; // Henter første tegn fra brugerens input

        // Udskriver de indtastede oplysninger
        Console.WriteLine("\nBilmærke: " + brand);
        Console.WriteLine("Bilmodel: " + model);
        Console.WriteLine("Årgang: " + year);
        Console.WriteLine("Gear: " + gearType);
    }
}