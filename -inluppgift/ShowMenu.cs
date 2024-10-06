namespace _inluppgift;

public class Menu
{
    public static void ShowMenu()
    {
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Välj ett alternativ.");
        Console.WriteLine("1. Lägg till Kurs ");
        Console.WriteLine("2. Lägg till Studerande ");
        Console.WriteLine("3. Lägg till Lärare ");
        Console.WriteLine("4. Lägg till Handledare ");
        Console.WriteLine("5. Lägg till Administratör ");
        Console.WriteLine("6. Visa Kurser. ");
        Console.WriteLine("7. Visa Studerande. ");
        Console.WriteLine("0. Avsluta. ");
        Console.ResetColor();
        Console.WriteLine("\n");

    }
}