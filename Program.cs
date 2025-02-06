namespace CarApp;

// 🚗 Klasse til bilens variabler og funktioner
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public char GearType { get; set; }
    /*
get → Bruges til at læse værdien af en variabel.
set → Bruges til at ændre værdien af en variabel.
*/

    // Metode til at vise bilens oplysninger
    public void DisplayInfo()
    {
        Console.WriteLine("\n--- Biloplysninger ---");
        Console.WriteLine($"Bilmærke: {Brand}");
        Console.WriteLine($"Bilmodel: {Model}");
        Console.WriteLine($"Årgang: {Year}");
        Console.WriteLine($"Gear: {GearType}");
    }
}

// 🎯 Hovedprogrammet (Main)
class Program
{
    static void Main(string[] args)
    {
        // Opretter en bil og gemmer brugerens input
        Car myCar = new Car();

        Console.Write("Indtast dit bilmærke: ");
        myCar.Brand = Console.ReadLine();

        Console.Write("Indtast din bilmodel: ");
        myCar.Model = Console.ReadLine();

        Console.Write("Indtast bilens årgang: ");
        myCar.Year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Indtast geartype (A for automatisk, M for manuel): ");
        myCar.GearType = char.ToUpper(Console.ReadLine()[0]);

        // 📌 Viser bilens oplysninger
        myCar.DisplayInfo();
    }
}