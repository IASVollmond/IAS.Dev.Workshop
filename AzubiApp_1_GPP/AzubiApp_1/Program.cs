namespace azubiapp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("~Azubi Hub~");
            Console.WriteLine("*******************");
            Console.WriteLine("");

            Console.WriteLine("Hauptmenü");

            Console.WriteLine("Bitte geben Sie die Nummer des Menüpunkts ein, denn Sie benutzen möchten");
            Console.WriteLine("1. Liste Azubis");
            Console.WriteLine("2. Azubi hinzufügen");
            Console.WriteLine("3. Azubi anmelden");
            Console.WriteLine("4. Azubi abmelden");
            Console.WriteLine("5. Countdown bis IHK Abgabe");
            Console.WriteLine();

            string eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                Console.WriteLine("Azubiliste");
            }

            else if (eingabe == "2")
            {
                Console.WriteLine("Hinzufügen");
            }

            else if (eingabe == "3")
            {
                Console.WriteLine("Anmelden");
            }

            else if (eingabe == "4")
            {
                Console.WriteLine("Abmelden");
            }

            else if (eingabe == "5") 
            {
                Console.WriteLine("Countdown");
            }

            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte nur Angaben zwischen 1-5 eingeben");
            }

            Console.Read();
        }
    }
}
